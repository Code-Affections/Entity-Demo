using SampleEntityDemo.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.Name = "VishnuKumar ps";
            s1.MobileNo = "1212";
            s1.MobileNo2 = "7736177715";


            StudentDbContext dbContext = new StudentDbContext();
            
            s1.Id=Guid.NewGuid().ToString();

            dbContext.Add(s1);  //   for inserting data
            dbContext.SaveChanges();

            var data=dbContext.Students.ToList();  // find  (Select)

            foreach (var item in data)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.MobileNo);
                Console.WriteLine(item.MobileNo2);
            }


            //obj.SaveChangesAsync();


        }
    }
}
