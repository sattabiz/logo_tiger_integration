using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SattaTigerTS.Entities
{
    public class Item
    {
        //[Browsable(false)]
        public bool SelectedItem { get; set; }
        public int ItemRef { get; set; }

        [DisplayName("Ürün Kodu")]
        public string product_erp_id { get; set; }

        [DisplayName("Ürün Açıklaması")]
        public string name { get; set; }

        [DisplayName("Birim")]
        public string unit { get; set; }

    }
}
