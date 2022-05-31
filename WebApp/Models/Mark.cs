using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Mark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public virtual string? MarkName { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
    }
}
