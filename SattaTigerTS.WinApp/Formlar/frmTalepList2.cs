using Newtonsoft.Json;
using SattaTigerTS.Core;
using SattaTigerTS.Entities;
using SattaTigerTS.WinApp.Operations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmTalepList2 : Form
    {
        BusinessLogicLayer BLL;
        
        public frmTalepList2()
        {
            BLL = new BusinessLogicLayer();
 
            InitializeComponent();
        }

        private void ItemListShow()
        {
            DataGridViewCheckBoxColumn selectedItem = new DataGridViewCheckBoxColumn();
            dgvItemList.Columns.Insert(0, selectedItem);
            selectedItem.HeaderText = "Seç";
            selectedItem.Name = "SelectedItem";
            dgvItemList.DataSource = BLL.GetItemTable();
        }
        private void frmTalepList_Load(object sender, EventArgs e)
        {
            ItemListShow(); 
        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvItemList.DataSource as DataTable).DefaultView.RowFilter = string.Format("product_erp_id LIKE '%{0}' OR product_erp_id LIKE '{0}%' OR product_erp_id LIKE '% {0}%'", txtCodeSearch.Text);
            //
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvItemList.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}' OR name LIKE '{0}%' OR name LIKE '% {0}%'", txtNameSearch.Text);
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName");
            dt.Columns.Add("product_erp_id");
            dt.Columns.Add("name");
            dt.Columns.Add("requester_amount");
            dt.Columns.Add("unit");
            dt.Columns.Add("itemSelection",typeof(bool));
           
            foreach (DataGridViewRow row in dgvItemList.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectedItem"].Value);
               

                if (isSelected)
                {
                    dt.Rows.Add("Diğer",
                                row.Cells[2].Value,
                                row.Cells[3].Value,
                                "1",
                                row.Cells[4].Value,
                                true                               ) ;
                }
            }
            dgvDemandList.DataSource = dt;

        }

        private async void btnSendJsonSatta_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DataTable tablom = (dgvDemandList.DataSource as DataTable);

            var list = tablom.AsEnumerable().Select((p, index) => (new
            {  
                category_name = p.Field<String>("categoryname"),
                name = p.Field<String>("name"),
                description = "",
                requester_amount = p.Field<string>("requester_amount"),
                unit = p.Field<string>("unit"),
                
                //currency_code = "TRY",
                
                product_erp_id = p.Field<string>("product_erp_id"),
            }, index));


            var json = new
            {
                demand_list = new
                {
                    delivery_date = DateTime.Now.ToString("yyyy-MM-dd"),
                    name = txtMainDescription.Text,
                    products_attributes = list.ToList()
                    .ToDictionary(degisim => degisim.index, degisim => degisim.Item1)
                }
            };

            string sonuc = JsonConvert.SerializeObject(json);

            //Console.WriteLine(sonuc);
            File.WriteAllText("Items.json", sonuc);

            byte[] data = Encoding.UTF8.GetBytes(sonuc);

            using(var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Clear();
                httpclient.DefaultRequestHeaders.Add("Authorization", $"{Globals.LoggedInApiUser.jwt}");

                var content = new StringContent(
                  sonuc,
                  System.Text.Encoding.UTF8,
                  "application/json"
                  );

                var gelendata = await httpclient.PostAsync($"{ApiOperations.baseUrl}/v1/favorite_list.json", content);
                var yeni = gelendata.Content.ReadAsStringAsync();
            }
            splashScreenManager1.CloseWaitForm();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvItemList.Rows)
            {
                row.Cells["SelectedItem"].Value = true;
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvItemList.Rows)
            {
                row.Cells["SelectedItem"].Value = false;
            }
        }

        private void btnSelectAllDemand_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDemandList.Rows)
            {
                row.Cells["itemSelection"].Value = true;
            }
        }

        private void btnUnselectAllDemand_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDemandList.Rows)
            {
                row.Cells["itemSelection"].Value = false;
            }
        }

      
    }
}
