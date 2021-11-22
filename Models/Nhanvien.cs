using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("Nhanvien")]
    public class Nhanvien:Person
    {
        
        public int NhanvienId { get; set; }
        public string NhanvienCode { get; set; }
        public string NhanvienFullName { get; set; }
    }
}