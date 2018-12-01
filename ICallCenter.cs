using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    interface ICallCenter
    {
        void AssignToAgent();
        void SendCallToAgent();

    }
}
