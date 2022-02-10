using ConsoleApp3.Model;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentAppDbContext ob = new StudentAppDbContext();

            Student s1 = new Student();
            s1.Name = "Vishnu";
            s1.Id = Guid.NewGuid().ToString();
        
            s1.MobileNo = "898989898";

            s1.MarkList.Add(new Mark() { 
               M1=10,
               M2=90,
               M3=90,

               MarkId=Guid.NewGuid().ToString(),
               StudentId = s1.Id
            });
            ob.Students.Find();





            //  var student = ob.Students.Find("2a7c863a-0b8f-4a67-8f8a-c314160f2d7b");
            ///
            // student.Name = "Vishnu kumar";
            // student.MobileNo = "3223232323";

            //  ob.Update(student);

            ob.Add(s1);//

            ob.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
