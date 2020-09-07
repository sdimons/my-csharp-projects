using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new PlutoDBContext();
            var courses = dbContext.GetCourses();
            foreach (var c in courses)
                Console.WriteLine(c.Title);
        }
    }
}
