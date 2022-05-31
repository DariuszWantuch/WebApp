using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string Id { get; set; }

        [DataType(DataType.Text)]
        public virtual string? RepairStatus { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
    }
}
