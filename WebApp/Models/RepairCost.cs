using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class RepairCost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [DataType(DataType.MultilineText)]
        public string? FaultDescription { get; set; }

        [DataType(DataType.Currency)]
        public double Cost { get; set; }

        public bool IsAccepted { get; set; }

        public bool IsRejected { get; set; }
    }
}
