using SampleEntityDemo.models;
using System.ComponentModel.DataAnnotations;

namespace SampleEntityDemo.db
{
    public class Student
    {

        [Key]
        public string StudentId { get; set; }


        public string Name { get; set; }
        public string MobileNo { get; set; }
       
        public virtual Address Addresses { get; set; }

      

    }
}