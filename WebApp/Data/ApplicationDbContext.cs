using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.Repository;
using WebApp.Data.Repository.IRepository;
using WebApp.Models;
using WebApp.Utility;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Mark>().HasData(
                new { Id = GenerateID(), MarkName = "Samsung" },
                new { Id = GenerateID(), MarkName = "Amica" },
                new { Id = GenerateID(), MarkName = "Philips" },
                new { Id = GenerateID(), MarkName = "Sony" },
                new { Id = GenerateID(), MarkName = "Huawei" },
                new { Id = GenerateID(), MarkName = "Siemens" },
                new { Id = GenerateID(), MarkName = "Bosh" },
                new { Id = GenerateID(), MarkName = "Whirlpool" },
                new { Id = GenerateID(), MarkName = "AEG" },
                new { Id = GenerateID(), MarkName = "Logitech" }
                );

            builder.Entity<Status>().HasData(
                new { Id = GenerateID(), RepairStatus = StatusSD.Start },
                new { Id = GenerateID(), RepairStatus = StatusSD.SentCourier },
                new { Id = GenerateID(), RepairStatus = StatusSD.Valuation },
                new { Id = GenerateID(), RepairStatus = StatusSD.Approval },
                new { Id = GenerateID(), RepairStatus = StatusSD.Rejected },
                new { Id = GenerateID(), RepairStatus = StatusSD.Accepted },
                new { Id = GenerateID(), RepairStatus = StatusSD.RepairFinish },
                new { Id = GenerateID(), RepairStatus = StatusSD.SentBack },
                new { Id = GenerateID(), RepairStatus = StatusSD.Finish },
                new { Id = GenerateID(), RepairStatus = StatusSD.Cancel }
                );

            builder.Entity<Address>().HasData(
                new { Id = GenerateID(), FirstName = "Stanisław", LastName = "Jabłoński", PhoneNumber = 786828418, Street = "ul. Błogosławionej Siedliskiej Franciszki 62", City = "Kraków", PostalCode = 30614 },
                new { Id = GenerateID(), FirstName = "Karina", LastName = "Nowicka", PhoneNumber = 793247715, Street = "ul. Kinetyczna 85", City = "Warszawa", PostalCode = 02198 },
                new { Id = GenerateID(), FirstName = "Klaudia", LastName = "Rutkowska", PhoneNumber = 722623711, Street = "ul. Deotymy 12", City = "Kraków", PostalCode = 30419 },
                new { Id = GenerateID(), FirstName = "Iwo", LastName = "Adamczyk", PhoneNumber = 888569892, Street = "ul. Malarska 107", City = "Wrocław", PostalCode = 50111 },
                new { Id = GenerateID(), FirstName = "Joasia", LastName = "Kowalczyk", PhoneNumber = 723999750, Street = "ul. Kłodawska 87", City = "Warszawa", PostalCode = 01715 }
                );

            builder.Entity<DeviceType>().HasData(
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.Fridge, TransportCost = DeviceTypeSD.FridgeCost },
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.Induction, TransportCost = DeviceTypeSD.InductionCost },
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.Microwave, TransportCost = DeviceTypeSD.MicrowaveCost },
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.Other, TransportCost = DeviceTypeSD.OtherCost },
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.Oven, TransportCost = DeviceTypeSD.OvenCost },
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.TV, TransportCost = DeviceTypeSD.TVCost },
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.Washer, TransportCost = DeviceTypeSD.WasherCost },
                new { Id = GenerateID(), DeviceName = DeviceTypeSD.WashingMachine, TransportCost = DeviceTypeSD.WashingMachineCost }
                );
        }

        private string GenerateID()
        {
            return Guid.NewGuid().ToString();
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<RepairCost> RepairCost { get; set; }
        public DbSet<DeviceType> DeviceType { get; set; }
    }
}
