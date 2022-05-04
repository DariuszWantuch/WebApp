﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Utility;

namespace WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Mark>().HasData(
                new { Id = GenerateID(), MarkName = "Samsung" },
                new { Id = GenerateID(), MarkName = "Amica" }
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
