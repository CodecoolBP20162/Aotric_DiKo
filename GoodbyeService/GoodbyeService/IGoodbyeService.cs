using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GoodbyeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGoodbyeService" in both code and config file together.
    [ServiceContract]
    public interface IGoodbyeService
    {
        [OperationContract]
        string GetMessage(string msg);
    }
}
