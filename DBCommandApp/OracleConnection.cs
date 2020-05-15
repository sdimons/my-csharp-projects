using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommandApp
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void Close()
        {
            Console.WriteLine("OracleConnection is closed");
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection is opened");
        }
    }
}
