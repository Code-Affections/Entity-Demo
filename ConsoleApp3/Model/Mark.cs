using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp3.Model
{
    public class Mark
    {

        [Key]
        public string MarkId { get; set; }

        [ForeignKey("Id")]
        public string StudentId { get; set; }



        public int M1 { get; set; }

        public int M2 { get; set; }

        public int M3 { get; set; }
    }
}
