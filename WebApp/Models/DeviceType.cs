using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class DeviceType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [DataType(DataType.Text)]
        public string DeviceName { get; set; }

        [DataType(DataType.Currency)]
        public double TransportCost { get; set; }
    }
}
