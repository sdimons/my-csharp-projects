using System;
using System.Linq;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            IQueryable<Course> courses = context.Courses;
            var filtred = courses.Where(c => c.Level == 1);
            foreach(var course in filtred)
            {
                Console.WriteLine(course.Name);
            }
        }
    }
}
