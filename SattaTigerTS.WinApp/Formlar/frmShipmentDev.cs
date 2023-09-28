using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using SattaTigerTS.Entities;
using SattaTigerTS.WinApp.Operations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using static DevExpress.Utils.Svg.CommonSvgImages;
using static SattaTigerTS.Entities.ShipmentList;

namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmShipmentDev : DevExpress.XtraEditors.XtraForm
    {
        public frmShipmentDev()
        {
            InitializeComponent();
        }
        protected async void frmShipmentDev_Load(object sender, EventArgs e)
        {
            
            dgvmyGridMasterShipmentView.OptionsSelection.MultiSelect = true;
            dgvmyGridMasterShipmentView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            dgvmyGridMasterShipmentView.OptionsSelection.CheckBoxSelectorField = "SelectedShipment";

            GetShipment();
            
        }

         async void GetShipment()
        {
            
            var httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Clear();
            //httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpclient.DefaultRequestHeaders.Add("Authorization", $"{Globals.LoggedInApiUser.jwt}");


            var gelendata = await httpclient.GetAsync($"{ApiOperations.baseUrl}/v1/shipment_list.json?state='order_on_the_way'")
                                            .ConfigureAwait(false);


            if (gelendata.IsSuccessStatusCode)
            {
                dynamic result = await gelendata.Content.ReadAsStringAsync();
                var shipmentList = JsonConvert.DeserializeObject<Root>(result);

                dgvmyGridMasterShipmentControl.BeginInvoke(new Action(delegate ()
                {
                    dgvmyGridMasterShipmentControl.DataSource = shipmentList.Shipments;
                }));
            }

        }


            private void SatirSec(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            if (dgvmyGridMasterShipmentView.SelectedRowsCount > 0)
            {
                dgvmyGridMasterShipmentView.GetRow(dgvmyGridMasterShipmentView.FocusedRowHandle);
                Shipment shipment = dgvmyGridMasterShipmentView.GetRow(dgvmyGridMasterShipmentView.SelectedRowsCount) as Shipment;
                if (shipment != null)
                {
                    dgvmyGridDetailShipmentControl.DataSource = shipment.Products;

                }
            }

        }

        private void dgvmyGridMasterShipmentView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvmyGridMasterShipmentView.SelectedRowsCount > 0)
            {
                //GridView.GetRow(GridView.FocusedRowHandle)
                Shipment shipmentList = dgvmyGridMasterShipmentView.GetRow(dgvmyGridMasterShipmentView.FocusedRowHandle) as Shipment;
                if (shipmentList != null)
                {
                    dgvmyGridDetailShipmentControl.DataSource = shipmentList.Products;
                }
            }

        }

        
    }
}
