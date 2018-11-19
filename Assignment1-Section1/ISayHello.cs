using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment1_Section1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISayHello" in both code and config file together.
    [ServiceContract]
    public interface ISayHello
    {
        [OperationContract]
        string DoWork(string name);
        [OperationContract]
        Dictionary<string, int> OpeningJobs();
        [OperationContract]
        int OpeningJobsByRole(string role);
    }
}
