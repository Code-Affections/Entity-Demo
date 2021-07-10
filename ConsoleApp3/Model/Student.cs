using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp3.Model
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }


        public virtual List<Mark> MarkList { get; set; } = new List<Mark>();




    }
}
