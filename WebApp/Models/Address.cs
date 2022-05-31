using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string Id { get; set; }

        [DataType(DataType.Text)]
        public virtual string? FirstName { get; set; }

        [DataType(DataType.Text)]
        public virtual string? LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public virtual int PhoneNumber { get; set; }

        [DataType(DataType.Text)]
        public virtual string? Street { get; set; }

        [DataType(DataType.Text)]
        public virtual string? City { get; set; }

        [DataType(DataType.PostalCode)]
        public virtual int PostalCode { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
    }
}
