using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SattaTigerTS.Core;
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
    public partial class frmSupplierTrn : Form
    {

        BusinessLogicLayer BLL;
        public frmSupplierTrn()
        {
            BLL = new BusinessLogicLayer();
            InitializeComponent();
        }

        private void GetBestOfSupplier()
        {
            DataGridViewCheckBoxColumn selectedItem = new DataGridViewCheckBoxColumn();
            dgvBestOfSupplier.Columns.Insert(0, selectedItem);
            selectedItem.HeaderText = "Seç";
            selectedItem.Name = "SelectedItem";
            dgvBestOfSupplier.DataSource = BLL.GetBestOfSupplier();
        }
        private void frmSupplierTrn_Load(object sender, EventArgs e)
        {
            GetBestOfSupplier();
        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvBestOfSupplier.DataSource as DataTable).DefaultView.RowFilter = string.Format("erp_id LIKE '%{0}' OR erp_id LIKE '{0}%' OR erp_id LIKE '% {0}%'", txtCodeSearch.Text);
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvBestOfSupplier.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}' OR name LIKE '{0}%' OR name LIKE '% {0}%'", txtNameSearch.Text);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBestOfSupplier.Rows)
            {
                row.Cells["SelectedItem"].Value = true;
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBestOfSupplier.Rows)
            {
                row.Cells["SelectedItem"].Value = false;
            }
        }

        private void btnTransferSupplier_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("invited_person");
            dt.Columns.Add("phone");
            dt.Columns.Add("invited_email");
            dt.Columns.Add("tax_id");
            dt.Columns.Add("erp_id");
            dt.Columns.Add("itemSelection", typeof(bool));

            foreach (DataGridViewRow row in dgvBestOfSupplier.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectedItem"].Value);

                if (isSelected)
                {
                    dt.Rows.Add(row.Cells[3].Value,
                                row.Cells[6].Value,
                                row.Cells[8].Value,
                                row.Cells[7].Value,
                                row.Cells[10].Value,
                                row.Cells[12].Value,
                                true);
                }
            }
            dgvSendSattaBestOfSupplier.DataSource = dt;
        }

        private async void btnSendBestOfSupplier_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DataTable tablom = (dgvSendSattaBestOfSupplier.DataSource as DataTable);

            //var arrayJson = new[]{ new
            //{
            //    invited_company = tablom.AsEnumerable().Select((p) => (new
            //    {
            //        name = p.Field<String>("name"),
            //        invited_person=p.Field<String>("invited_person"),
            //        phone=p.Field<String>("phone"),
            //        invited_email=p.Field<String>("invited_email"),
            //        tax_id=p.Field<String>("tax_id"),
            //        erp_id=p.Field<String>("erp_id"),
            //    }))
            //}

            foreach (DataRow row in tablom.Rows)
            {
                var arrayJson = new [] {
                new
                {
                    invited_company =  new
                    {
                        name = row["name"].ToString(),
                        invited_person = row["invited_person"].ToString(),
                        phone = row["phone"].ToString(),
                        invited_email = row["invited_email"].ToString(),
                        tax_id = row["tax_id"].ToString(),
                        erp_id = row["erp_id"].ToString(),
                    }
                                        }
                };

                var json = arrayJson.Select((b, name) => new { b, name }).
                       ToDictionary(degisim => degisim.name, degisim => degisim.b);

                string sonuc = JsonConvert.SerializeObject(json);

                //Console.WriteLine(sonuc);
                File.WriteAllText("BestOfSupplier.json", sonuc);

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

                    var gelendata = await httpclient.PostAsync($"{ApiOperations.baseUrl}/v1/invited_companies.json", content);

                    var yeni = gelendata.Content.ReadAsStringAsync();


                }
            }
            splashScreenManager1.CloseWaitForm();
            MessageBox.Show("İşlemler Başarılı");
        }
    }
}
