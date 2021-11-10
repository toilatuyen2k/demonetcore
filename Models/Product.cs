using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public string ProductID { get; set; }
        public string Productname { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
    }
}