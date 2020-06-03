using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    //PlutoModels.EnumTypes has the same name "Level"!!!
    public enum Level : byte
    {
        Begginer = 1,
        Intermediate = 2,
        Advanced = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new PlutoDBContext();
            var courses = dbContext.GetCourses();

            foreach(var c in courses)
            {
                Console.WriteLine(c.Title);
            }

            var course = new Course();
            course.Level = Level.Begginer; //CourseLevel.Begginer
        }
    }
}
