using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("Student")]
    public class Student:Person
    {
    
        public string University { get; set; }
        
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}