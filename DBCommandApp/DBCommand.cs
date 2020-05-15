using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommandApp
{
    public class DBCommand
    {
        private readonly DBConnection _dbConnection;
        private readonly string _instruction;

        public DBCommand(DBConnection dbConnection, string instruction)
        {
            this._dbConnection = dbConnection ?? throw new InvalidOperationException("DBConnection is null");
            this._instruction = string.IsNullOrWhiteSpace(instruction) ? throw new InvalidOperationException("Instruction is empty") 
                : instruction;
        }
        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Run the instruction: {0}", this._instruction);
            _dbConnection.Close();
        }
    }
}
