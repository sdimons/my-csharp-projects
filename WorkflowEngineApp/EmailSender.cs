using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class EmailSender : IActivity
    {
        private string _email;

        public EmailSender(string email)
        {
            this._email = email;
        }
        public void Execute()
        {
            Console.WriteLine("Sending email to {0}...", _email);
        }
    }
}
