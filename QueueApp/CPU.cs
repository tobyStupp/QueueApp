using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class CPU
    {
        private int timeSlice;
        private Job currentJob;
        private Queue<Job> jobs;
        public CPU (int timeSlice)
        {
            this.timeSlice = timeSlice;
            jobs = new Queue<Job>();
            currentJob = null;
        }
        public void AddJob (string name, int length)
        {

        }
        public void PrintAndSwapJobs()
        {
            // action that finishes job, removes from CPU. If finished, remove from queue, else reinsert but minus current run time
        }
        public bool HasJobsLeft()
        {
            throw new NotImplementedException();
        }
    }
}
