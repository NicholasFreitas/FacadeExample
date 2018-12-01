using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class QueryStringProcessor : IAPIProcessor
    {
        private Lead NewLead;

        public Lead BuildLeadObject()
        {
            Console.WriteLine("Build Object");
            return NewLead;
        }

        public void ParseURI(string uri)
        {
            string NotUsedBecauseWeMocked = uri;
            Console.WriteLine("Parse URI");
            //Mocking the Lead for demonstration purposes.
            NewLead = new Lead("John", "Doe", 33, "555-0909");


        }



    }
}
