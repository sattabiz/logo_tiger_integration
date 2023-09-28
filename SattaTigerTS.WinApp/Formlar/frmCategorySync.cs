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
using DevExpress.XtraBars.ToolbarForm;

namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmCategorySync : Form
    {
        BusinessLogicLayer BLL;
        public frmCategorySync()
        {
            BLL = new BusinessLogicLayer();
            InitializeComponent();
        }

        private void ItemListShow()
        {
            DataGridViewCheckBoxColumn selectedItem = new DataGridViewCheckBoxColumn();
            
            dgvCategory.DataSource = BLL.GetItemTable2();
            dgvCategory.Columns.Insert(0, selectedItem);
            selectedItem.HeaderText = "Seç";
            selectedItem.Name = "SelectedItem";
        }
        private void frmCategorySync_Load(object sender, EventArgs e)
        {
            ItemListShow();
        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvCategory.DataSource as DataTable).DefaultView.RowFilter = string.Format("product_erp_id LIKE '%{0}' OR product_erp_id LIKE '{0}%' OR product_erp_id LIKE '% {0}%'", txtCodeSearch.Text);
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvCategory.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}' OR name LIKE '{0}%' OR name LIKE '% {0}%'", txtNameSearch.Text);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                row.Cells["SelectedItem"].Value = true;
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                row.Cells["SelectedItem"].Value = false;
            }
        }

        private void btnTransferCategory_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("erp_id");
            dt.Columns.Add("category_name");
            dt.Columns.Add("category_unit");
            

            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectedItem"].Value);


                if (isSelected)
                {
                    dt.Rows.Add(row.Cells[2].Value,
                                row.Cells[3].Value,
                                row.Cells[4].Value
                                );
                }
            }
            dgvCategorySatta.DataSource = dt;
        }

        private async void btnSendBestOfSupplier_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DataTable tablom = (dgvCategorySatta.DataSource as DataTable);

            foreach (DataRow row in tablom.Rows)
            {
                var arrayJson = new[] {
                new
                {
                    category =  new
                    {
                        erp_id = row["erp_id"].ToString(),
                        name = row["category_name"].ToString(),
                        unit = row["category_unit"].ToString(),

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
            splashScreenManager1.CloseWaitForm();
            MessageBox.Show("İşlemler Başarılı");
        }
    }
}
