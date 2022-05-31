using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class DeviceType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string Id { get; set; }

        [DataType(DataType.Text)]
        public virtual string? DeviceName { get; set; }

        [DataType(DataType.Currency)]
        public virtual double TransportCost { get; set; }
    }
}
