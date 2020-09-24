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

            var author = context.Authors.Single(a => a.Id == 1);

            // MSDN way
            context.Entry(author).Collection(a => a.Courses).Query().Where(c => c.FullPrice == 0).Load();

            // Mosh way
            context.Courses.Where(c => c.AuthorId == author.Id).Load();

            foreach(var course in author.Courses)
            {
                Console.WriteLine("{0}", course.Name);
            }

            // IN Operator for Linq
            var authors = context.Authors.ToList();
            var authorIds = authors.Select(a => a.Id);
            context.Courses.Where(c => authorIds.Contains(c.AuthorId) && c.FullPrice == 0).Load();
        }
    }
}
