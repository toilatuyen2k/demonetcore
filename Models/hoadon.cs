using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("hoadon")]
    public class hoadon
    {
        [Key]
        public int hoadonId { get; set; }
        public string hoadonCode { get; set; }
        public string hoadonFullName { get; set; } 
        public khachhang khachhangs { get;set; }
    }
}