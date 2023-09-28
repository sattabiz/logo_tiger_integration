
using Newtonsoft.Json;
using SattaTigerTS.Core;
using SattaTigerTS.Entities;
using SattaTigerTS.WinApp.Operations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using UnityObjects;
using static SattaTigerTS.Entities.OrderList;

namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmOrderList : Form
    {
        BusinessLogicLayer BLL;
        private Root root { get; set; }
        public frmOrderList()
        {
            BLL = new BusinessLogicLayer();
            InitializeComponent();
            //DataGridViewCheckBoxColumn selectedItem = new DataGridViewCheckBoxColumn();
            //dgvMasterOrderList.Columns.Insert(0, selectedItem);
            //selectedItem.FalseValue = false;
            //selectedItem.HeaderText = "Seç";
            //selectedItem.Name = "SelectedItem";
            dgvMasterOrderList.AutoGenerateColumns = false;
            dgvMasterOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void frmOrderList_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            GetOrderDataTable();
            splashScreenManager1.CloseWaitForm();
        }

        async void GetOrderDataTable()
        {
            
            var httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Clear();
            //httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpclient.DefaultRequestHeaders.Add("Authorization", $"{Globals.LoggedInApiUser.jwt}");


            var gelendata = await httpclient.GetAsync($"{ApiOperations.baseUrl}/v1/order_list.json?state='order_approved','order_confirmed'")
                                            .ConfigureAwait(false);


            if (gelendata.IsSuccessStatusCode)
            {
                //dynamic result = await gelendata.Content.ReadAsStringAsync();
                var result = await gelendata.Content.ReadAsStringAsync();
                Root root = JsonConvert.DeserializeObject<Root>(result);
                dgvMasterOrderList.BeginInvoke(new Action(delegate ()
                {
                    dgvMasterOrderList.DataSource = root.Orders;
                }));

            }
            
        }

        private void SatirSec(object sender, EventArgs e)
        {

            if (dgvMasterOrderList.SelectedRows.Count > 0)
            {
                Order order = dgvMasterOrderList.SelectedRows[0].DataBoundItem as Order;
                if (order != null)
                {
                    dgvDetailOrderList.DataSource = order.Products;
                    foreach (DataGridViewRow detail in dgvDetailOrderList.Rows)
                    {
                        detail.Cells["SelectedItemProduct"].Value = true;
                    }
                }
            }
        }

        //int orderRef = 0;
        //int orderNum = 0;
        private async void btnTigerOrderTrans_Click(object sender, EventArgs e)
        {            
            try

            {
                splashScreenManager1.ShowWaitForm();
                if (Global.uApp.Connect())

                {
                    
                    if (Global.uApp.UserLogin("LOGO", "LOGO"))

                    {

                        if (Global.uApp.CompanyLogin(XXX, XX))

                        {

                            List<Order> orders = ((List<Order>)dgvMasterOrderList.DataSource).Where(p => p.SelectedItem).ToList();
                            List<Product> products = new List<Product>();
                            
                            foreach (Order item in orders)
                            {
                                object date_ = 0;
                                Global.uApp.PackDate(item.OrderDate.Day, item.OrderDate.Month, item.OrderDate.Year, ref date_);
                                DataTable dt = BLL.GetCurrencyTable(date_);
                                var rowCollRC = dt.AsEnumerable();
                                double rateRC = rowCollRC
                                    .Where(myRow => myRow.Field<Int16>("CRTYPE") == 1)
                                    .Select(myRow => myRow.Field<double>("RATES1")).ToList().FirstOrDefault();

                                UnityObjects.Data order = Global.uApp.NewDataObject(DataObjectType.doPurchOrderSlip);
                                order.New();
                                order.DataFields.FieldByName("NUMBER").Value = item.Id;
                                order.DataFields.FieldByName("DATE").Value = item.OrderDate;
                                order.DataFields.FieldByName("ARP_CODE").Value = item.SupplierErpId;  //item.SupplierErpId;
                                order.DataFields.FieldByName("RC_RATE").Value = rateRC;
                                order.DataFields.FieldByName("ORDER_STATUS").Value = 4;
                                order.DataFields.FieldByName("CURRSEL_TOTAL").Value = 2;
                                order.DataFields.FieldByName("CURRSEL_DETAILS").Value = 4;
                                //order.DataFields.FieldByName("CURR_TRANSACTION").Value = 1;
                                //order.DataFields.FieldByName("TC_RATE").Value = 16.8237;


                                foreach (Product tt in item.Products.Where(k => k.SelectedItemProduct))
                                {
                                    products.Add(tt);
                                    Lines detay = order.DataFields.FieldByName("TRANSACTIONS").Lines;
                                    detay.AppendLine();
                                    detay[detay.Count - 1].FieldByName("TYPE").Value = 0; // Mal

                                    if (tt.ProductErpId != null)
                                    {
                                        detay[detay.Count - 1].FieldByName("MASTER_CODE").Value = tt.ProductErpId;
                                    }
                                    else
                                    {
                                        detay[detay.Count - 1].FieldByName("MASTER_CODE").Value = tt.CategoryErpId;
                                    }
                                    detay[detay.Count - 1].FieldByName("TRANS_DESCRIPTION").Value = tt.Name;
                                    detay[detay.Count - 1].FieldByName("QUANTITY").Value = tt.Amount;
                                    
                                    if (tt.CurrencyCode == "TRY")
                                    {
                                        detay[detay.Count - 1].FieldByName("PRICE").Value = tt.Price;
                                    }

                                    if (tt.CurrencyCode == "USD")
                                    {
                                        //DataTable dt = BLL.GetCurrencyTable(date_);
                                        var rowColl = dt.AsEnumerable();
                                        double rate = rowColl
                                            .Where(myRow => myRow.Field<Int16>("CRTYPE") == 1)
                                            .Select(myRow => myRow.Field<double>("RATES1")).ToList().FirstOrDefault();
                                        
                                        detay[detay.Count - 1].FieldByName("CURR_PRICE").Value = 1;
                                        detay[detay.Count - 1].FieldByName("EDT_CURR").Value = 1;
                                        detay[detay.Count - 1].FieldByName("PC_PRICE").Value = tt.Price;
                                        detay[detay.Count - 1].FieldByName("PR_RATE").Value = rate;
                                        detay[detay.Count - 1].FieldByName("EDT_PRICE").Value = tt.Price;
                                    }

                                    if (tt.CurrencyCode == "EUR")
                                    {
                                        //DataTable dt = BLL.GetCurrencyTable(date_);
                                        var rowColl = dt.AsEnumerable();
                                        double rate = rowColl
                                            .Where(myRow => myRow.Field<Int16>("CRTYPE") == 20)
                                            .Select(myRow => myRow.Field<double>("RATES1")).ToList().FirstOrDefault();

                                        detay[detay.Count - 1].FieldByName("CURR_PRICE").Value = 20;
                                        detay[detay.Count - 1].FieldByName("EDT_CURR").Value = 20;
                                        detay[detay.Count - 1].FieldByName("PC_PRICE").Value = tt.Price;
                                        detay[detay.Count - 1].FieldByName("PR_RATE").Value = rate;
                                        detay[detay.Count - 1].FieldByName("EDT_PRICE").Value = tt.Price;
                                    }

                                    if (tt.CurrencyCode == "GBP")
                                    {
                                        //DataTable dt = BLL.GetCurrencyTable(date_);
                                        var rowColl = dt.AsEnumerable();
                                        double rate = rowColl
                                            .Where(myRow => myRow.Field<Int16>("CRTYPE") == 17)
                                            .Select(myRow => myRow.Field<double>("RATES1")).ToList().FirstOrDefault();

                                        detay[detay.Count - 1].FieldByName("CURR_PRICE").Value = 17;
                                        detay[detay.Count - 1].FieldByName("EDT_CURR").Value = 17;
                                        detay[detay.Count - 1].FieldByName("PC_PRICE").Value = tt.Price;
                                        detay[detay.Count - 1].FieldByName("PR_RATE").Value = rate;
                                        detay[detay.Count - 1].FieldByName("EDT_PRICE").Value = tt.Price;
                                    }

                                    detay[detay.Count - 1].FieldByName("UNIT_CODE").Value = tt.Unit;
                                    detay[detay.Count - 1].FieldByName("UNIT_CONV1").Value = 1;
                                    detay[detay.Count - 1].FieldByName("UNIT_CONV2").Value = 1;
                                } //product in products

                                ValidateErrors err = order.ValidateErrors;

                                string snc = "";

                                if (order.Post())

                                {
                                   
                                    string orderRef = order.DataFields.FieldByName("INTERNAL_REFERENCE").Value.ToString();
                                    string orderNum = order.DataFields.FieldByName("NUMBER").Value.ToString();
                                    POList poList = new POList
                                    {
                                        order_id = orderNum,
                                        po_number = orderRef

                                    };
                                    string sonuc = JsonConvert.SerializeObject(poList);
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

                                        var gelendata = await httpclient.PostAsync($"{ApiOperations.baseUrl}/v1/update_order_with_po_number.json", content);

                                        var yeni = gelendata.Content.ReadAsStringAsync();


                                    }

                                    if (order.Read(Int32.Parse(orderRef)))
                                    {

                                        order.DataFields.FieldByName("NUMBER").Value = orderRef;

                                if (order.ErrorCode == 8)

                                {

                                    MessageBox.Show("Doğrulama Hatası");

                                }

                                else

                                {

                                    snc = "Fault: ";

                                    if (order.ErrorCode != 0)

                                    {

                                        snc = snc + order.ErrorCode.ToString() + order.ErrorDesc + "\n"
                                                  + order.DBErrorDesc.ToString();



                                        for (int i = 0; i < err.Count; i++)

                                            snc = snc + err[i].Error + "\n";

                                        MessageBox.Show(snc);



                                        MessageBox.Show("Yeni Ayrıntı Satırı Ekleme Sırasında Problem");

                                        //return false;

                                    }

                                }

                            }                             //order in orders
                        } //company dönem logo 

                        else
                        {
                            MessageBox.Show("Firma ya da dönem no hatalı");
                        }

                    } //user login 

                    else
                    {
                        MessageBox.Show("Tiger kullanıcı adı veya parola hatalı");
                    }

                } //uapp Connect

                else
                {
                    MessageBox.Show("Tigera doğru bağlantı başarısız");
                }

                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("İşlemler başarılı");
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }//catch
            

        } //buttonend

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMasterOrderList.Rows)
            {
                row.Cells["SelectedItem"].Value = true;
                foreach (DataGridViewRow detail in dgvDetailOrderList.Rows)
                {
                    detail.Cells["SelectedItemProduct"].Value = true;
                }
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMasterOrderList.Rows)
            {
                row.Cells["SelectedItem"].Value = false;
                foreach (DataGridViewRow detail in dgvDetailOrderList.Rows)
                {
                    detail.Cells["SelectedItemProduct"].Value = false;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetOrderDataTable();
        }


        private void txtTedarikci_TextChanged(object sender, EventArgs e)
        {
            //DataTable tablom = dgvMasterOrderList.DataSource as DataTable;

            //DataView view = tablom.AsDataView();
            //view.RowFilter= string.Format(@"Supplier LIKE '%{0}' OR Supplier LIKE '{0}%' OR Supplier LIKE '% {0}%'", txtTedarikci.Text);




            //(dgvMasterOrderList.DataSource as DataTable).AsDataView(Supplier).RowFilter = string.Format(@"Supplier LIKE '%{5}' OR Supplier LIKE '{5}%' OR Supplier LIKE '% {5}%'", txtTedarikci.Text);
            //(dgvMasterOrderList.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{5}'", txtTedarikci.Text);
            if (txtTedarikci.Text.Length > 0)
            {
                List<Order> orders = ((List<Order>)dgvMasterOrderList.DataSource).Where(item => item.Supplier.Contains(txtTedarikci.Text)).ToList();
                //|| item.DemandNo.Name.ToLower().Contains(searchString) || item.le.Name.ToLower().Contains(searchString) || item.le.lecture_extern_id.ToString().Contains(searchString) || item.c.customer_fullname.ToLower().Contains(searchString));
                dgvMasterOrderList.DataSource = orders;
            }
            else
            {
                GetOrderDataTable();
            }

        }
        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text.Length > 0)
            {
                List<Order> orders = ((List<Order>)dgvMasterOrderList.DataSource).Where(item => item.Id.ToString().ToLower().Contains(txtOrderNumber.Text)).ToList();
                dgvMasterOrderList.DataSource = orders;
            }
            else
            {
                GetOrderDataTable();
            }
        }

        //private readonly BindingSource _bindingSource = new BindingSource();
        //private string response;
        //private short CurrId;
        //private string currName;

        private void txtTalepNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTalepNo.Text.Length > 0)
            {
                List<Order> orders = ((List<Order>)dgvMasterOrderList.DataSource).Where(item => item.DemandNo.ToString().ToLower().Contains(txtTalepNo.Text)).ToList();
                dgvMasterOrderList.DataSource = orders;
            }
            else
            {
                GetOrderDataTable();
            }
        }

        private void txtTedarikciVergiNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTedarikciVergiNo.Text.Length > 0)
            {
                List<Order> orders = ((List<Order>)dgvMasterOrderList.DataSource).Where(item => item.SupplierTaxId.ToString().ToLower().Contains(txtTedarikciVergiNo.Text)).ToList();
                dgvMasterOrderList.DataSource = orders;
            }
            else
            {
                GetOrderDataTable();
            }
        }

        private void btnStaticData_Click(object sender, EventArgs e)
        {
            TigerOperations.SiparisAktar();
        }
    }
}

