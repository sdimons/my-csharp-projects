using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Импортировать статические члены
// классов Console и DateTime
using static System.Console;
using static System.DateTime;
    
namespace StaticDataAndMembers
{
    public static class TimeUtilClass
    {
        public static void PrintTime()
            => WriteLine(Now.ToShortTimeString());
        
        public static void PrintDate()
            => WriteLine(Now.ToShortDateString());
    }
}
