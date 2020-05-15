using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class WorkFlow : IWorkFlow
    {
        private IList<IActivity> _activities;
        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }
        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void UnregisterActivity(IActivity activity)
        {
            _activities.Remove(activity);
        }
    }
}
