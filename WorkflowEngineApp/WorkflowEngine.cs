using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class WorkflowEngine
    {
        public WorkflowEngine()
        {
            
        }
        public void Run(IWorkFlow workFlow)
        {
            foreach(var activity in workFlow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
