using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment1_Section1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SayHello" in both code and config file together.
    public class SayHello : ISayHello
    {
        public string DoWork(string name)
        {
            int time =Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (time < 12)
                return String.Format("{0} {1}", "Good Morning", name);
            else if (time > 12 && time <18)
                return String.Format("{0} {1}", "Good Afternoon", name);
            else
                return String.Format("{0} {1}", "Good Evening", name);
        }

        public Dictionary<string, int> OpeningJobs()
        {
            Dictionary<string, int> openings = new Dictionary<string, int>();
            openings.Add("Associate", 5);
            openings.Add("Analyst", 10);
            openings.Add("Senior Associate", 3);
            return openings;
        }

        public int OpeningJobsByRole(string role)
        {
            Dictionary<string, int> openings = OpeningJobs();
            return openings.Where(h => h.Key == role).Select(p=> p.Value).FirstOrDefault();
        }
    }
}
