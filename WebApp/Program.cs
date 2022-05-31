using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Data.EntityFramework;
using WebApp.Data.EntityFramework.Repository;
using WebApp.Data.EntityFramework.Repository.IRepository;
using WebApp.Data.Init;
using WebApp.Data.Init.IInit;
using WebApp.Data.NH;
using WebApp.Data.NH.Repository;
using WebApp.Data.NH.Repository.IRepository;
using WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin",
        builder => builder.RequireRole("Admin"));
    options.AddPolicy("All",
        builder => builder.RequireRole("Admin", "User"));

});

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IDbInitializer, DbInitializer>();

builder.Services.AddTransient<AppService>();

builder.Services.AddScoped<IEFUnitOfWork, EFUnitOfWork>();

builder.Services.AddScoped<INHUnitOfWork, NHUnitOfWork>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

NH.Init(); 

using (var scope = app.Services.CreateScope())
{
    var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    dbInitializer.Initialize(userManager);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
