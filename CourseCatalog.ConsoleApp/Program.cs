using System;
using CourseCatalog.Data;

namespace CourseCatalog.ConsoleApp
{
    class Program
    {
        private static CourseContext _context = new CourseContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            _context.Database.EnsureCreated();
        }
    }
}
