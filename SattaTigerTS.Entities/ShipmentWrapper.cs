using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SattaTigerTS.Entities
{
    public class ShipmentWrapper
    {
        [JsonProperty("root")]
        public DataSet ShipmentDataSet { get; set; }
    }
}
