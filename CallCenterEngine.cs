using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class CallCenterEngine : ICallCenter
    {

        Lead CallCenterLead;

        public CallCenterEngine(Lead ccLead)
        {
            CallCenterLead = ccLead;
        }

        public void AssignToAgent()
        {
            Console.WriteLine("Queued for CC.");
        }

        public void SendCallToAgent()
        {
            Console.WriteLine("Assigned to an Agent.");
        }
    }
}
