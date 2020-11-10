using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandString
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Args: {0}", args[i]);
            }
            Console.ReadLine();
        }
    }
}
