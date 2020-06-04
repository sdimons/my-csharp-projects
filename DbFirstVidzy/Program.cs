using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstVidzy
{
    //DbFirstVidzy.Classification
    public enum Classification : byte
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new VidzyDbContext();
            //dbContext.AddVideo("Bird on a Wire", new DateTime(1990, 5, 18), "Comedy", (byte)Classification.Platinum);
            dbContext.AddVideo("Bird on a Wire", new DateTime(1990, 5, 18), "Comedy", Classification.Platinum);
            Console.WriteLine("\"Bird on a Wire\" added");
        }
    }
}
