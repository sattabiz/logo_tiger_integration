using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json;
using SattaTigerTS.Core;
using SattaTigerTS.Entities;
using SattaTigerTS.WinApp.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmDemandListDev : XtraForm
    {
        BusinessLogicLayer BLL;
        public frmDemandListDev()
        {
            BLL = new BusinessLogicLayer();
            InitializeComponent();
        }

        private void ItemListShow()
        {
            //DataGridViewCheckBoxColumn selectedItem = new DataGridViewCheckBoxColumn();
            //mydgvItemlist.Columns.Insert(0, selectedItem);
            //selectedItem.HeaderText = "Seç";
            //selectedItem.Name = "SelectedItem";
            //mydgvItemlist.DataSource = BLL.GetItemTable();

            //GridColumn selectedItem = new GridColumn();
            
            myControlItemList.DataSource = BLL.GetItemTable();
            
            
            //mydgvItemlist.Columns.Insert(0, selectedItem);
            //selectedItem.Caption = "Seç";
            //selectedItem.Name = "SelectedItem";
        }

        private void frmDemandListDev_Load(object sender, EventArgs e)
        {
            myControlItemList.ForceInitialize();
            mydgvItemlist.OptionsSelection.MultiSelect = true;
            mydgvItemlist.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            mydgvItemlist.OptionsSelection.CheckBoxSelectorField = "SelectedItem";
            ItemListShow();
        }

        private void btnItemSender_Click(object sender, EventArgs e)
        {
            if (mydgvItemlist.SelectedRowsCount > 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("product_erp_id");
                dt.Columns.Add("NAME");
                dt.Columns.Add("unit");

                int[] selectedRows = mydgvItemlist.GetSelectedRows();

                foreach (int index in selectedRows)
                {
                    dt.Rows.Add((string)mydgvItemlist.GetRowCellValue(index, "product_erp_id"),
                                   (string)mydgvItemlist.GetRowCellValue(index, "NAME"),
                                    (string)mydgvItemlist.GetRowCellValue(index, "unit")
                                   );
                    myControlDemandList.DataSource = dt;
                }
            }
            
        }

        private async void btnItemSync_Click(object sender, EventArgs e)
        {
            
            DataTable tablom = (myControlDemandList.DataSource as DataTable);

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

            using (var httpclient = new HttpClient())
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
           
            //DataTable tablom = (myControlItemList.DataSource as DataTable);

            //foreach (DataRow row in tablom.Rows)
            //{
            //    var arrayJson = new[] {
            //    new
            //    {
            //        category =  new
            //        {

            //            erp_id = row["product_erp_id"].ToString(),
            //            name = row["NAME"].ToString(),
            //            unit = row["unit"].ToString(),

            //        }
            //    }
            //                          };

            //    var json = arrayJson.Select((b, name) => new { b, name }).
            //           ToDictionary(degisim => degisim.name, degisim => degisim.b);

            //    string sonuc = JsonConvert.SerializeObject(json);

            //    //Console.WriteLine(sonuc);
            //    File.WriteAllText("category.json", sonuc);

            //    byte[] data = Encoding.UTF8.GetBytes(sonuc);

            //    using (var httpclient = new HttpClient())
            //    {
            //        httpclient.DefaultRequestHeaders.Clear();
            //        httpclient.DefaultRequestHeaders.Add("Authorization", $"{Globals.LoggedInApiUser.jwt}");

            //        var content = new StringContent(
            //          sonuc,
            //          System.Text.Encoding.UTF8,
            //          "application/json"
            //          );

            //        var gelendata = await httpclient.PostAsync($"{ApiOperations.baseUrl}/v1/categories.json", content);

            //        var yeni = gelendata.Content.ReadAsStringAsync();
            //    }
            //}

            //MessageBox.Show("İşlemler Başarılı");
        }

    
    }
}