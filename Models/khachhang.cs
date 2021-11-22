using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("khachhang")]
    public class khachhang:Person
    {
        public string khachhangCode { get; set; }
        public string khachhangFullName { get; set; }
    }
}