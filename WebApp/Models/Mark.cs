using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Mark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string MarkName { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
    }
}
