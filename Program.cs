using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class Program
    {

        /*
         In this implementation we have a service for importing leads from an API. So the API hand off a URI
         and then we just process the result. We have a host of underlying systems responsible for the entire process.
         However, from the consumption side of the code. It's a fairly straightforward process. We've successfully
         abstracted away four subsystems. and in this implementation we don't need to worry about what subsystem(s) 
         are in use. We can focus strictly on our high level process.
             */
                         
        static void Main(string[] args)
        {

            var uri = "htts//example.com/method?firstname=JOHN&lastname=DOE&age=33&phonenumber=555-0909";
            var leadService = new LeadImportService();

            var lead = leadService.BindURIToLeadObject(uri);

            var leadIsValid = leadService.ValidateLeadInformation(lead);

            if (leadIsValid)
            {

                leadService.ImportLeadIntoSystem(lead);

                leadService.QueueLeadForCallcenter(lead);

            }
            

        }
    }
}
