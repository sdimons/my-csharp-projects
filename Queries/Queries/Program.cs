using System;
using System.Linq;
using System.Data.Entity;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // WPF
            var authors = context.Authors.ToList();
            var author = context.Authors.Single(a => a.Id == 1);

            var course = new Course
            {
                Name = "New Course",
                Description = "New Description",
                FullPrice = 19.95f,
                Level = 1,
                Author = author
            };
            context.Courses.Add(course);
            context.SaveChanges();

            // Web applications
            var course2 = new Course
            {
                Name = "New Course 2",
                Description = "New Description 2",
                FullPrice = 19.95f,
                Level = 1,
                AuthorId = 1
            };
            context.Courses.Add(course2);
            context.SaveChanges();
        }
    }
}
