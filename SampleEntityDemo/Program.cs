using SampleEntityDemo.db;
using SampleEntityDemo.models;
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
           
            Student s1=new Student();
            s1.StudentId=Guid.NewGuid().ToString();  //primary
            
            s1.Name = "Vishnu";
            s1.MobileNo = "7736177715";
           


            Address a1 = new Address();
            a1.AddressId = Guid.NewGuid().ToString();  // primary
            a1.StudentId= Guid.NewGuid().ToString();//  mistake
            ///a1.StudentId = s1.StudentId;

            a1.Address1 = "Kollam";
            a1.Address2 = "Alappuzha";
            a1.City = "Kollam";

            StudentDbContext db = new StudentDbContext();
            db.Students.Add(s1);
            db.Add(a1);
            db.SaveChanges();

          

            Console.ReadKey();




        }
    }
}
