using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.RegisterActivity(new VideoUploader());
            workflow.RegisterActivity(new VideoEncoder());
            workflow.RegisterActivity(new EmailSender("test@yahoo.com"));
            workflow.RegisterActivity(new StatusChanger("Processing"));

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
