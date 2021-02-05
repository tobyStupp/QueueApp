using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class Job
    {
        private string jobName;
        private int remainingTime;
        public Job (string name, int totalTime)
        {
            this.jobName = name;
            this.remainingTime = totalTime;
        }
        public int GetRemainingTime() => remainingTime;
        public string GetJobName() => jobName;
        public bool ShortenTime (int time)
        {
            if (remainingTime - time <= 0)
            {
                remainingTime = 0;
                return false;
            }
            remainingTime -= time;
            return true;
        }
   
    }
}
