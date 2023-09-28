
namespace SattaTigerTS.WinApp.Formlar
{
    partial class frmCenterFlu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCenterFlu));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSendFavList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCategorySync = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlOrders = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlOrderToTiger = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSuppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBestOfSuppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SattaTigerTS.WinApp.Formlar.WaitForm1), true, true);
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlOrders,
            this.accordionControlSuppliers,
            this.accordionControlElement3});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(251, 502);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSendFavList,
            this.accordionControlCategorySync,
            this.accordionControlElement2});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Ürün İşlemleri";
            // 
            // accordionControlSendFavList
            // 
            this.accordionControlSendFavList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSendFavList.ImageOptions.Image")));
            this.accordionControlSendFavList.Name = "accordionControlSendFavList";
            this.accordionControlSendFavList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSendFavList.Text = "Sattaya Favori Listesi Gönder";
            this.accordionControlSendFavList.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlCategorySync
            // 
            this.accordionControlCategorySync.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCategorySync.ImageOptions.Image")));
            this.accordionControlCategorySync.Name = "accordionControlCategorySync";
            this.accordionControlCategorySync.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCategorySync.Text = "Ürün-Kategori İşlemi Tüm Ürünler";
            this.accordionControlCategorySync.Click += new System.EventHandler(this.accordionControlCategorySync_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Ürün-Kategori İşlemi Hareketli Ürünler";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click_1);
            // 
            // accordionControlOrders
            // 
            this.accordionControlOrders.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlOrderToTiger});
            this.accordionControlOrders.Expanded = true;
            this.accordionControlOrders.Name = "accordionControlOrders";
            this.accordionControlOrders.Text = "Sipariş İşlemleri";
            // 
            // accordionControlOrderToTiger
            // 
            this.accordionControlOrderToTiger.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlOrderToTiger.ImageOptions.Image")));
            this.accordionControlOrderToTiger.Name = "accordionControlOrderToTiger";
            this.accordionControlOrderToTiger.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlOrderToTiger.Text = "Tigera Sipariş Aktar";
            this.accordionControlOrderToTiger.Click += new System.EventHandler(this.accordionControlOrderToTiger_Click);
            // 
            // accordionControlSuppliers
            // 
            this.accordionControlSuppliers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlBestOfSuppliers});
            this.accordionControlSuppliers.Expanded = true;
            this.accordionControlSuppliers.Name = "accordionControlSuppliers";
            this.accordionControlSuppliers.Text = "Tedarikçi İşlemleri";
            // 
            // accordionControlBestOfSuppliers
            // 
            this.accordionControlBestOfSuppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBestOfSuppliers.ImageOptions.Image")));
            this.accordionControlBestOfSuppliers.Name = "accordionControlBestOfSuppliers";
            this.accordionControlBestOfSuppliers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBestOfSuppliers.Text = "Sattaya Tedarikçi Eşleme";
            this.accordionControlBestOfSuppliers.Click += new System.EventHandler(this.accordionControlBestOfSuppliers_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement4});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "İrsaliye İşlemleri";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Tigera İrsaliye Aktar";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // frmCenterFlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 502);
            this.Controls.Add(this.accordionControl1);
            this.IconOptions.Image = global::SattaTigerTS.WinApp.Properties.Resources.productivity;
            this.IsMdiContainer = true;
            this.Name = "frmCenterFlu";
            this.Text = "SattaTiger İşlem Merkezi";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSendFavList;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCategorySync;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlOrders;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlOrderToTiger;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSuppliers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBestOfSuppliers;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
    }
}