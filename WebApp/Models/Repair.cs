using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class Repair
    {
        [Key]
        public virtual Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        public virtual DateTime ReportDate { get; set; }

        [DataType(DataType.Date)]
        public virtual DateTime PickupDate { get; set; }

        [DataType(DataType.Text)]
        public virtual string? DeviceModel { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string? Describe { get; set; }

        [DataType(DataType.ImageUrl)]
        public virtual string? Warranty { get; set; }

        [DataType(DataType.Text)]
        public virtual string? Tracking { get; set; }

        public virtual string StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }

        public virtual string RepairCostId { get; set; }
        [ForeignKey("RepairCostId")]
        public virtual RepairCost RepairCost { get; set; }

        public virtual string AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        public virtual string DeviceTypeId { get; set; }
        [ForeignKey("DeviceTypeId")]
        public virtual DeviceType DeviceType { get; set; }

        public virtual string MarkId { get; set; }

        [ForeignKey("MarkId")]
        public virtual Mark Mark { get; set; }

        public virtual string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser IdentityUser { get; set; }
    }
}
