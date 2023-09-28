using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SattaTigerTS.Entities
{
    public class CurrencyList
    {
        public int LREF { get; set; }
        public int DATE_ { get; set; }
        public Int16 CRTYPE { get; set; }
        public double RATES1 { get; set; }
        public double RATES2 { get; set; }
        public DateTime EDATE { get; set; }

    }
}
