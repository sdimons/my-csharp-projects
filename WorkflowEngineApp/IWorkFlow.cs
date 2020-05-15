using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public interface IWorkFlow
    {
        void RegisterActivity(IActivity activity);
        void UnregisterActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
