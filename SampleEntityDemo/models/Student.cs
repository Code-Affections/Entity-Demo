using System.ComponentModel.DataAnnotations;

namespace SampleEntityDemo.db
{
    public class Student
    {

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public string MobileNo2 { get; set; }

    }
}