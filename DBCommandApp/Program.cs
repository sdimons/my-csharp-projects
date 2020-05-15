using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCommand = new DBCommand(new SqlConnection("sql connection string"), "select * from sqltable");
            dbCommand.Execute();
            dbCommand = new DBCommand(new OracleConnection("oracle connectin string"), "select * from oracletable");
            dbCommand.Execute();
        }
    }
}
