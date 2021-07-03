using ConsoleApp3.Model;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StudentAppDbContext ob = new StudentAppDbContext();

                Student s1 = new Student();
                s1.Name = "Vishnu";
                s1.Id = Guid.NewGuid().ToString();

                s1.MobileNo = "898989898";



               /// ob.Add(s1);//


                var s=ob.Students.Find("475cbce8-84cd-4ef1-8f8d-87b241fb2343");

                s.Name = "Vishnu kumar ";
                s.MobileNo = "78787878787";
               
                
                
                
                ob.SaveChanges();
                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
