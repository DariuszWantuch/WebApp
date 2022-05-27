using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string? FirstName { get; set; }

        [DataType(DataType.Text)]
        public string? LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [DataType(DataType.Text)]
        public string? Street { get; set; }

        [DataType(DataType.Text)]
        public string? City { get; set; }

        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
    }
}
