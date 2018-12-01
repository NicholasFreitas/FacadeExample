using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    interface ILeadImporter
    {
        void AssignProductsAndServices();
        void AssignLocalMarket();
        void AssignRating();
        void AssignClassification();
        
    }
}
