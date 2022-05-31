using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class RepairCost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string Id { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string? FaultDescription { get; set; }

        [DataType(DataType.Currency)]
        public virtual double Cost { get; set; }

        public virtual bool IsAccepted { get; set; }

        public virtual bool IsRejected { get; set; }
    }
}
