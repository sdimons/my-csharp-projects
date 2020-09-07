using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new VidzyDbContext();
            dbContext.AddVideo("Terminator 3: Rise of the Machines", new DateTime(2003, 6, 30), "Action", Classification.Platinum);
        }
    }
}
