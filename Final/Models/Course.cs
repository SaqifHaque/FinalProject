using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Course
    {
        [Key]
        public int C_Id { get; set; }
        public int Instructor_Id { get; set; }
        public int Category_Id { get; set; }
        public string C_Name { get; set; }
        public string C_Description { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
        public string C_Image { get; set; }
        public Category Category { get; set; }
    }
}