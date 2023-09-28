using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SattaTigerTS.Entities
{
    public class ProductsAttribute
    {
        public int Id { get; set; }

        public string Category_Name { get; set; }

        public int Requester_Amount { get; set; }

        public string Description { get; set; }

        public int DemandListId { get; set; }

    }
}
