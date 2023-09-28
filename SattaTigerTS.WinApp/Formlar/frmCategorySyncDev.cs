using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using SattaTigerTS.Core;
using SattaTigerTS.WinApp.Operations;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmCategorySyncDev : DevExpress.XtraEditors.XtraForm
    {
        BusinessLogicLayer BLL;
        public frmCategorySyncDev()
        {
            BLL = new BusinessLogicLayer();
            InitializeComponent();
        }

        private void BesOfItemListShow()
        {
            GridColumn selectedItem = new GridColumn();

            dgvControlBestOfItem.DataSource = BLL.GetBestOfItem();
            dgvMyBestOfItem.Columns.Insert(0, selectedItem);
            selectedItem.Caption = "Seç";
            selectedItem.Name = "SelectedItem";
        }

        private void frmCategorySyncDev_Load(object sender, EventArgs e)
        {
            dgvMyBestOfItem.OptionsSelection.MultiSelect = true;
            dgvMyBestOfItem.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            dgvMyBestOfItem.OptionsSelection.CheckBoxSelectorField = "SelectedItem";
            BesOfItemListShow();
        }

        private void btnItemToCategory_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("product_erp_id");
            dt.Columns.Add("NAME");
            dt.Columns.Add("unit");

            int[] selectedRows = dgvMyBestOfItem.GetSelectedRows();

            foreach (int index in selectedRows)
            {
                dt.Rows.Add((string)dgvMyCategorySyncDev.GetRowCellValue(index, "product_erp_id"),
                               (string)dgvMyCategorySyncDev.GetRowCellValue(index, "NAME"),
                                (string)dgvMyCategorySyncDev.GetRowCellValue(index, "unit")
                               );
                dgvControlCategorySync.DataSource = dt;
            }
        }

        private async void btnSendCategorySatta_Click(object sender, EventArgs e)
        {
            
            DataTable tablom = (dgvMyBestOfItem.DataSource as DataTable);

            foreach (DataRow row in tablom.Rows)
            {
                var arrayJson = new[] {
                new
                {
                    category =  new
                    {
                       
                        erp_id = row["product_erp_id"].ToString(),
                        name = row["NAME"].ToString(),
                        unit = row["unit"].ToString(),

                    }
                }
                                      };

                var json = arrayJson.Select((b, name) => new { b, name }).
                       ToDictionary(degisim => degisim.name, degisim => degisim.b);

                string sonuc = JsonConvert.SerializeObject(json);

                //Console.WriteLine(sonuc);
                File.WriteAllText("category.json", sonuc);

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

                    var gelendata = await httpclient.PostAsync($"{ApiOperations.baseUrl}/v1/categories.json", content);

                    var yeni = gelendata.Content.ReadAsStringAsync();
                }
            }
            
            MessageBox.Show("İşlemler Başarılı");
        }
    }
}