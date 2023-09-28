using DevExpress.XtraEditors;
using System;


namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmCenterFlu : XtraForm
    {
        public frmCenterFlu()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Formlar.frmDemandListDev frmDemandListDev = new Formlar.frmDemandListDev();
            frmDemandListDev.MdiParent = this;
            frmDemandListDev.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void accordionControlCategorySync_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Formlar.frmCategorySyncAll frmCategorySyncAll = new Formlar.frmCategorySyncAll();
            frmCategorySyncAll.MdiParent = this;
            frmCategorySyncAll.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void accordionControlOrderToTiger_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Formlar.frmOrderList frmOrderList = new Formlar.frmOrderList();
            frmOrderList.MdiParent = this;
            frmOrderList.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void accordionControlBestOfSuppliers_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Formlar.frmSupplierTrn frmSupplierTrn = new Formlar.frmSupplierTrn();
            frmSupplierTrn.MdiParent = this;
            frmSupplierTrn.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Formlar.frmCategorySyncDev frmCategorySyncDev = new Formlar.frmCategorySyncDev();
            frmCategorySyncDev.MdiParent = this;
            frmCategorySyncDev.Show();
            splashScreenManager1.CloseWaitForm();

            //xtraTabbedMdiManager1
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Formlar.frmShipmentDev frmshipmentDev = new Formlar.frmShipmentDev();
            frmshipmentDev.MdiParent = this;
            frmshipmentDev.Show();
            splashScreenManager1.CloseWaitForm();
        }
    }
}