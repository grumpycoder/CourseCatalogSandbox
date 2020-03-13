using System;
using System.Linq;
using CourseCatalog.Data;

namespace CourseCatalog.ConsoleApp
{
    class Program
    {
        private static CourseContext _context = new CourseContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //_context.Database.EnsureCreated();

            var courses = _context.Courses.Take(20).ToList();

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseCode);
            }
        }
    }
}
