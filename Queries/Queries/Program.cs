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

            // With Cascade Delete
            var course = context.Courses.Find(6);
            context.Courses.Remove(course);

            context.SaveChanges();

            // Without Cascade Delete
            var author = context.Authors.Include(a => a.Courses).Single(a => a.Id == 2);
            context.Courses.RemoveRange(author.Courses);
            context.Authors.Remove(author);

            context.SaveChanges();
        }
    }
}
