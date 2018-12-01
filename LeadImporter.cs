using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class LeadImporter : ILeadImporter
    {

        private Lead LeadForImport;

        public LeadImporter(Lead lead)
        {
            LeadForImport = lead;
        }

        public void AssignClassification()
        {
            Console.WriteLine("Importer Business process: Classification");
        }

        public void AssignLocalMarket()
        {
            Console.WriteLine("Importer Business process: Market ");
        }

        public void AssignProductsAndServices()
        {
            Console.WriteLine("Importer Business process: Products/Services");
        }

        public void AssignRating()
        {
            Console.WriteLine("Importer Business process: Rating ");
        }
    }
}
