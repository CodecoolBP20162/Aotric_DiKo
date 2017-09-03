using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GoodbyeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GoodbyeService" in both code and config file together.
    public class GoodbyeService : IGoodbyeService
    {
        public string GetMessage(string msg)
        {
            return "Goodbye" + msg;
        }
    }
}
