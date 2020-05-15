using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommandApp
{
    public class SqlConnection : DBConnection
    {
        public SqlConnection(string sqlConnection) : base(sqlConnection)
        {

        }
        public override void Close()
        {
            Console.WriteLine("SqlConnection is closed");
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection is opened");
        }
    }
}
