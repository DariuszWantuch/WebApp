using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.Repository;
using WebApp.Data.Repository.IRepository;
using WebApp.Models;
using WebApp.Utility;

namespace WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<RepairCost> RepairCost { get; set; }
        public DbSet<DeviceType> DeviceType { get; set; }
    }
}
