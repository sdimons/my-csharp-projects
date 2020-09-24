﻿using System;
using System.Linq;
using System.Data.Entity;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var courses = context.Courses.Include(c => c.Author).ToList();
            foreach(var course in courses)
            {
                Console.WriteLine("{0} by {1}", course.Name, course.Author.Name);
            }
        }
    }
}
