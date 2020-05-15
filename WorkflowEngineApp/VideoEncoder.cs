using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class VideoEncoder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Encoding the video...");
        }
    }
}
