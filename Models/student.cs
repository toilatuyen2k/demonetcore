using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoNetcore.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public String StudentID { get; set; }
        public String StudentName { get; set; }
        public String Address { get; set; }
    }
}