using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post()
            {
                Title = "Title",
                Description = "Description",
                Created = DateTime.Now
            };
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                if (random.Next(100) % 2 == 0)
                    post.Up_Vote();
                else
                    post.Down_Vote();
            }
            Console.WriteLine("Votes: {0}", post.Votes);
        }
    }
}
