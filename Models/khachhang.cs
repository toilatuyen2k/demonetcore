using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("khachhang")]
    public class khachhang
    {
        [Key]
        public int khachhangId { get; set; }
        public string khachhangCode { get; set; }
        public string khachhangFullName { get; set; }
        public ICollection<hoadon> hoadons {get; set;}
    }
}