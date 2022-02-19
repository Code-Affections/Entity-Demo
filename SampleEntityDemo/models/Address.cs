using SampleEntityDemo.db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityDemo.models
{
    public class Address
    {
        [Key]
        public string AddressId { get; set; }

        [ForeignKey("StudentId")]
        public string StudentId { get; set; }




        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }

        public virtual Student Student { get; set; }

    }
}
