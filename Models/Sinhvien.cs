using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("Sinhvien")]
    public class Sinhvien
    {
    
        public string University { get; set; }
        
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}