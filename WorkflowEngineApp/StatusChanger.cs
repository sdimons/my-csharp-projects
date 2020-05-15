using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class StatusChanger : IActivity
    {
        private string _status;
        public StatusChanger(string status)
        {
            this._status = status;
        }
        public void Execute()
        {
            Console.WriteLine("Changing status to \"{0}\"...", _status);
        }
    }
}
