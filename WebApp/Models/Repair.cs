﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class Repair
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public int RepairId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ReportDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime PickupDate { get; set; }

        [DataType(DataType.Text)]
        public string DeviceModel { get; set; }

        [DataType(DataType.MultilineText)]
        public string Describe { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Warranty { get; set; }

        [DataType(DataType.Text)]
        public string Tracking { get; set; }

        public string StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }

        public string RepairCostId { get; set; }
        [ForeignKey("RepairCostId")]
        public RepairCost RepairCost { get; set; }

        public string AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public string DeviceTypeId { get; set; }
        [ForeignKey("DeviceTypeId")]
        public DeviceType DeviceType { get; set; }

        public string MarkId { get; set; }

        [ForeignKey("MarkId")]
        public Mark Mark { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser IdentityUser { get; set; }
    }
}
