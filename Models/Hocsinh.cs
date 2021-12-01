using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("Hocsinh")]
    public class Hocsinh:Person
    {
        [Range(1, 100)]
        public int Age { get; set; }
        [StringLength(60)]

        public string Address {get; set; }
    }
}