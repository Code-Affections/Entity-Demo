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
        
            s1.MobileNo = "898989898";



            ob.Add(s1);//

            ob.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
