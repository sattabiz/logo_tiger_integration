
namespace SattaTigerTS.WinApp.Formlar
{
    partial class frmShipmentDev
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
            this.pnlShipmentMaster = new DevExpress.XtraEditors.PanelControl();
            this.dgvmyGridMasterShipmentControl = new SattaTigerTS.WinApp.Controls.Grid.MyGridControl();
            this.dgvmyGridMasterShipmentView = new SattaTigerTS.WinApp.Controls.Grid.MyGridView();
            this.ShipmentId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.WaybillNo = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.ShipmentDate = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.Carrier = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.TrackingNo = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.State = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.SenderName = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.SenderErpId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.Products = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlButton = new DevExpress.XtraEditors.PanelControl();
            this.btnShipmentTiger = new DevExpress.XtraEditors.SimpleButton();
            this.pnlShipmentDetail = new DevExpress.XtraEditors.PanelControl();
            this.dgvmyGridDetailShipmentControl = new SattaTigerTS.WinApp.Controls.Grid.MyGridControl();
            this.dgvmyGridDetailShipmentView = new SattaTigerTS.WinApp.Controls.Grid.MyGridView();
            this.OrderId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.OrderPoNo = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.ProductsProposalId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.ProductName = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.CategoryId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.CategoryErpId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.Description = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.ShippedAmount = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.Unit = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.Price = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.CurrencyCode = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.ErpId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.ProductErpId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.ProposalNote = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlShipmentMaster)).BeginInit();
            this.pnlShipmentMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridMasterShipmentControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridMasterShipmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlShipmentDetail)).BeginInit();
            this.pnlShipmentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridDetailShipmentControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridDetailShipmentView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShipmentMaster
            // 
            this.pnlShipmentMaster.Controls.Add(this.dgvmyGridMasterShipmentControl);
            this.pnlShipmentMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShipmentMaster.Location = new System.Drawing.Point(0, 0);
            this.pnlShipmentMaster.Name = "pnlShipmentMaster";
            this.pnlShipmentMaster.Size = new System.Drawing.Size(1112, 417);
            this.pnlShipmentMaster.TabIndex = 0;
            // 
            // dgvmyGridMasterShipmentControl
            // 
            this.dgvmyGridMasterShipmentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmyGridMasterShipmentControl.Location = new System.Drawing.Point(2, 2);
            this.dgvmyGridMasterShipmentControl.MainView = this.dgvmyGridMasterShipmentView;
            this.dgvmyGridMasterShipmentControl.Name = "dgvmyGridMasterShipmentControl";
            this.dgvmyGridMasterShipmentControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.dgvmyGridMasterShipmentControl.Size = new System.Drawing.Size(1108, 413);
            this.dgvmyGridMasterShipmentControl.TabIndex = 0;
            this.dgvmyGridMasterShipmentControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvmyGridMasterShipmentView});
            // 
            // dgvmyGridMasterShipmentView
            // 
            this.dgvmyGridMasterShipmentView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dgvmyGridMasterShipmentView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvmyGridMasterShipmentView.Appearance.FooterPanel.Options.UseFont = true;
            this.dgvmyGridMasterShipmentView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dgvmyGridMasterShipmentView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvmyGridMasterShipmentView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgvmyGridMasterShipmentView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvmyGridMasterShipmentView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvmyGridMasterShipmentView.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.dgvmyGridMasterShipmentView.Appearance.ViewCaption.Options.UseForeColor = true;
            this.dgvmyGridMasterShipmentView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ShipmentId,
            this.WaybillNo,
            this.ShipmentDate,
            this.Carrier,
            this.TrackingNo,
            this.State,
            this.SenderName,
            this.SenderErpId,
            this.Products});
            this.dgvmyGridMasterShipmentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvmyGridMasterShipmentView.GridControl = this.dgvmyGridMasterShipmentControl;
            this.dgvmyGridMasterShipmentView.Name = "dgvmyGridMasterShipmentView";
            this.dgvmyGridMasterShipmentView.OptionsCustomization.AllowGroup = false;
            this.dgvmyGridMasterShipmentView.OptionsDetail.AllowZoomDetail = false;
            this.dgvmyGridMasterShipmentView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic;
            this.dgvmyGridMasterShipmentView.OptionsDetail.EnableMasterViewMode = false;
            this.dgvmyGridMasterShipmentView.OptionsDetail.ShowEmbeddedDetailIndent = DevExpress.Utils.DefaultBoolean.False;
            this.dgvmyGridMasterShipmentView.OptionsDetail.SmartDetailExpand = false;
            this.dgvmyGridMasterShipmentView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            this.dgvmyGridMasterShipmentView.OptionsFind.AlwaysVisible = true;
            this.dgvmyGridMasterShipmentView.OptionsFind.ShowCloseButton = false;
            this.dgvmyGridMasterShipmentView.OptionsMenu.EnableGroupPanelMenu = false;
            this.dgvmyGridMasterShipmentView.OptionsNavigation.EnterMoveNextColumn = true;
            this.dgvmyGridMasterShipmentView.OptionsPrint.AutoWidth = false;
            this.dgvmyGridMasterShipmentView.OptionsSelection.CheckBoxSelectorColumnWidth = 50;
            this.dgvmyGridMasterShipmentView.OptionsSelection.CheckBoxSelectorField = "selectedShipments";
            this.dgvmyGridMasterShipmentView.OptionsSelection.MultiSelect = true;
            this.dgvmyGridMasterShipmentView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.dgvmyGridMasterShipmentView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.dgvmyGridMasterShipmentView.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            this.dgvmyGridMasterShipmentView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.dgvmyGridMasterShipmentView.OptionsView.RowAutoHeight = true;
            this.dgvmyGridMasterShipmentView.OptionsView.ShowAutoFilterRow = true;
            this.dgvmyGridMasterShipmentView.OptionsView.ShowGroupPanel = false;
            this.dgvmyGridMasterShipmentView.OptionsView.ShowViewCaption = true;
            this.dgvmyGridMasterShipmentView.SynchronizeClones = false;
            this.dgvmyGridMasterShipmentView.ViewCaption = "İrsaliye Fişi Genel Bilgileri";
            this.dgvmyGridMasterShipmentView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.SatirSec);
            this.dgvmyGridMasterShipmentView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvmyGridMasterShipmentView_FocusedRowChanged);
            // 
            // ShipmentId
            // 
            this.ShipmentId.Caption = "Sevk No";
            this.ShipmentId.FieldName = "ShipmentId";
            this.ShipmentId.Name = "ShipmentId";
            this.ShipmentId.OptionsColumn.AllowEdit = false;
            this.ShipmentId.Visible = true;
            this.ShipmentId.VisibleIndex = 1;
            // 
            // WaybillNo
            // 
            this.WaybillNo.Caption = "İrsaliye No";
            this.WaybillNo.FieldName = "WaybillNo";
            this.WaybillNo.Name = "WaybillNo";
            this.WaybillNo.OptionsColumn.AllowEdit = false;
            this.WaybillNo.Visible = true;
            this.WaybillNo.VisibleIndex = 2;
            // 
            // ShipmentDate
            // 
            this.ShipmentDate.Caption = "İrsaliye Tarihi";
            this.ShipmentDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ShipmentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ShipmentDate.FieldName = "ShipmentDate";
            this.ShipmentDate.Name = "ShipmentDate";
            this.ShipmentDate.OptionsColumn.AllowEdit = false;
            this.ShipmentDate.Visible = true;
            this.ShipmentDate.VisibleIndex = 3;
            // 
            // Carrier
            // 
            this.Carrier.Caption = "Kargo";
            this.Carrier.FieldName = "Carrier";
            this.Carrier.Name = "Carrier";
            this.Carrier.OptionsColumn.AllowEdit = false;
            this.Carrier.Visible = true;
            this.Carrier.VisibleIndex = 4;
            // 
            // TrackingNo
            // 
            this.TrackingNo.Caption = "Kargo Takip No";
            this.TrackingNo.FieldName = "TrackingNo";
            this.TrackingNo.Name = "TrackingNo";
            this.TrackingNo.OptionsColumn.AllowEdit = false;
            this.TrackingNo.Visible = true;
            this.TrackingNo.VisibleIndex = 5;
            // 
            // State
            // 
            this.State.Caption = "Durum";
            this.State.FieldName = "State";
            this.State.Name = "State";
            this.State.OptionsColumn.AllowEdit = false;
            this.State.Visible = true;
            this.State.VisibleIndex = 6;
            // 
            // SenderName
            // 
            this.SenderName.Caption = "Gönderici";
            this.SenderName.FieldName = "SenderName";
            this.SenderName.Name = "SenderName";
            this.SenderName.OptionsColumn.AllowEdit = false;
            this.SenderName.Visible = true;
            this.SenderName.VisibleIndex = 7;
            // 
            // SenderErpId
            // 
            this.SenderErpId.Caption = "Gönderici ERP Kodu";
            this.SenderErpId.FieldName = "SenderErpId";
            this.SenderErpId.Name = "SenderErpId";
            this.SenderErpId.OptionsColumn.AllowEdit = false;
            this.SenderErpId.Visible = true;
            this.SenderErpId.VisibleIndex = 8;
            // 
            // Products
            // 
            this.Products.Caption = "Products";
            this.Products.FieldName = "Products";
            this.Products.Name = "Products";
            this.Products.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit2.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnShipmentTiger);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 657);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1112, 52);
            this.pnlButton.TabIndex = 2;
            // 
            // btnShipmentTiger
            // 
            this.btnShipmentTiger.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShipmentTiger.Appearance.Options.UseFont = true;
            this.btnShipmentTiger.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShipmentTiger.Location = new System.Drawing.Point(804, 2);
            this.btnShipmentTiger.Name = "btnShipmentTiger";
            this.btnShipmentTiger.Size = new System.Drawing.Size(306, 48);
            this.btnShipmentTiger.TabIndex = 0;
            this.btnShipmentTiger.Text = "Tiger\'a İrsaliye Gönder";
            // 
            // pnlShipmentDetail
            // 
            this.pnlShipmentDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShipmentDetail.Controls.Add(this.dgvmyGridDetailShipmentControl);
            this.pnlShipmentDetail.Location = new System.Drawing.Point(0, 423);
            this.pnlShipmentDetail.Name = "pnlShipmentDetail";
            this.pnlShipmentDetail.Size = new System.Drawing.Size(1112, 228);
            this.pnlShipmentDetail.TabIndex = 1;
            // 
            // dgvmyGridDetailShipmentControl
            // 
            this.dgvmyGridDetailShipmentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmyGridDetailShipmentControl.Location = new System.Drawing.Point(2, 2);
            this.dgvmyGridDetailShipmentControl.MainView = this.dgvmyGridDetailShipmentView;
            this.dgvmyGridDetailShipmentControl.Name = "dgvmyGridDetailShipmentControl";
            this.dgvmyGridDetailShipmentControl.Size = new System.Drawing.Size(1108, 224);
            this.dgvmyGridDetailShipmentControl.TabIndex = 0;
            this.dgvmyGridDetailShipmentControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvmyGridDetailShipmentView});
            // 
            // dgvmyGridDetailShipmentView
            // 
            this.dgvmyGridDetailShipmentView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dgvmyGridDetailShipmentView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvmyGridDetailShipmentView.Appearance.FooterPanel.Options.UseFont = true;
            this.dgvmyGridDetailShipmentView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dgvmyGridDetailShipmentView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvmyGridDetailShipmentView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgvmyGridDetailShipmentView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvmyGridDetailShipmentView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvmyGridDetailShipmentView.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.dgvmyGridDetailShipmentView.Appearance.ViewCaption.Options.UseForeColor = true;
            this.dgvmyGridDetailShipmentView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderId,
            this.OrderPoNo,
            this.ProductsProposalId,
            this.ProductName,
            this.CategoryId,
            this.CategoryErpId,
            this.Description,
            this.ShippedAmount,
            this.Unit,
            this.Price,
            this.CurrencyCode,
            this.ErpId,
            this.ProductErpId,
            this.ProposalNote});
            this.dgvmyGridDetailShipmentView.GridControl = this.dgvmyGridDetailShipmentControl;
            this.dgvmyGridDetailShipmentView.Name = "dgvmyGridDetailShipmentView";
            this.dgvmyGridDetailShipmentView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic;
            this.dgvmyGridDetailShipmentView.OptionsFind.AlwaysVisible = true;
            this.dgvmyGridDetailShipmentView.OptionsFind.ShowCloseButton = false;
            this.dgvmyGridDetailShipmentView.OptionsMenu.EnableGroupPanelMenu = false;
            this.dgvmyGridDetailShipmentView.OptionsNavigation.EnterMoveNextColumn = true;
            this.dgvmyGridDetailShipmentView.OptionsPrint.AutoWidth = false;
            this.dgvmyGridDetailShipmentView.OptionsSelection.CheckBoxSelectorColumnWidth = 50;
            this.dgvmyGridDetailShipmentView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.dgvmyGridDetailShipmentView.OptionsView.RowAutoHeight = true;
            this.dgvmyGridDetailShipmentView.OptionsView.ShowAutoFilterRow = true;
            this.dgvmyGridDetailShipmentView.OptionsView.ShowGroupPanel = false;
            this.dgvmyGridDetailShipmentView.OptionsView.ShowViewCaption = true;
            this.dgvmyGridDetailShipmentView.ViewCaption = "İrsaliye Fişi Satırları";
            // 
            // OrderId
            // 
            this.OrderId.Caption = "Sip No";
            this.OrderId.FieldName = "OrderId";
            this.OrderId.Name = "OrderId";
            this.OrderId.OptionsColumn.AllowEdit = false;
            this.OrderId.Visible = true;
            this.OrderId.VisibleIndex = 0;
            // 
            // OrderPoNo
            // 
            this.OrderPoNo.Caption = "Sip Po No";
            this.OrderPoNo.FieldName = "OrderPoNo";
            this.OrderPoNo.Name = "OrderPoNo";
            this.OrderPoNo.OptionsColumn.AllowEdit = false;
            this.OrderPoNo.Visible = true;
            this.OrderPoNo.VisibleIndex = 1;
            // 
            // ProductsProposalId
            // 
            this.ProductsProposalId.Caption = "Product Prpsl Id";
            this.ProductsProposalId.FieldName = "ProductsProposalId";
            this.ProductsProposalId.Name = "ProductsProposalId";
            this.ProductsProposalId.OptionsColumn.AllowEdit = false;
            this.ProductsProposalId.Visible = true;
            this.ProductsProposalId.VisibleIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Ürün Açıklaması";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 3;
            // 
            // CategoryId
            // 
            this.CategoryId.Caption = "Kategori Id";
            this.CategoryId.FieldName = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.OptionsColumn.AllowEdit = false;
            this.CategoryId.Visible = true;
            this.CategoryId.VisibleIndex = 4;
            // 
            // CategoryErpId
            // 
            this.CategoryErpId.Caption = "Kategory ERP Id";
            this.CategoryErpId.FieldName = "CategoryErpId";
            this.CategoryErpId.Name = "CategoryErpId";
            this.CategoryErpId.OptionsColumn.AllowEdit = false;
            this.CategoryErpId.Visible = true;
            this.CategoryErpId.VisibleIndex = 5;
            // 
            // Description
            // 
            this.Description.Caption = "Açıklama ";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 6;
            // 
            // ShippedAmount
            // 
            this.ShippedAmount.Caption = "Miktar";
            this.ShippedAmount.FieldName = "ShippedAmount";
            this.ShippedAmount.Name = "ShippedAmount";
            this.ShippedAmount.OptionsColumn.AllowEdit = false;
            this.ShippedAmount.Visible = true;
            this.ShippedAmount.VisibleIndex = 7;
            // 
            // Unit
            // 
            this.Unit.Caption = "Birim";
            this.Unit.FieldName = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.OptionsColumn.AllowEdit = false;
            this.Unit.Visible = true;
            this.Unit.VisibleIndex = 8;
            // 
            // Price
            // 
            this.Price.Caption = "Birim Fiyat";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 9;
            // 
            // CurrencyCode
            // 
            this.CurrencyCode.Caption = "Döviz Türü";
            this.CurrencyCode.FieldName = "CurrencyCode";
            this.CurrencyCode.Name = "CurrencyCode";
            this.CurrencyCode.OptionsColumn.AllowEdit = false;
            this.CurrencyCode.Visible = true;
            this.CurrencyCode.VisibleIndex = 10;
            // 
            // ErpId
            // 
            this.ErpId.Caption = "ERP Id";
            this.ErpId.FieldName = "ErpId";
            this.ErpId.Name = "ErpId";
            this.ErpId.OptionsColumn.AllowEdit = false;
            this.ErpId.Visible = true;
            this.ErpId.VisibleIndex = 11;
            // 
            // ProductErpId
            // 
            this.ProductErpId.Caption = "Ürün ERP Id";
            this.ProductErpId.FieldName = "ProductErpId";
            this.ProductErpId.Name = "ProductErpId";
            this.ProductErpId.OptionsColumn.AllowEdit = false;
            this.ProductErpId.Visible = true;
            this.ProductErpId.VisibleIndex = 12;
            // 
            // ProposalNote
            // 
            this.ProposalNote.Caption = "Teklif Notu";
            this.ProposalNote.FieldName = "ProposalNote";
            this.ProposalNote.Name = "ProposalNote";
            this.ProposalNote.OptionsColumn.AllowEdit = false;
            this.ProposalNote.Visible = true;
            this.ProposalNote.VisibleIndex = 13;
            // 
            // frmShipmentDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 709);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlShipmentMaster);
            this.Controls.Add(this.pnlShipmentDetail);
            this.Name = "frmShipmentDev";
            this.Text = "İrsaliye Girişi";
            this.Load += new System.EventHandler(this.frmShipmentDev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlShipmentMaster)).EndInit();
            this.pnlShipmentMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridMasterShipmentControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridMasterShipmentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlShipmentDetail)).EndInit();
            this.pnlShipmentDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridDetailShipmentControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmyGridDetailShipmentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlShipmentMaster;
        private DevExpress.XtraEditors.PanelControl pnlButton;
        private Controls.Grid.MyGridControl dgvmyGridMasterShipmentControl;
        private Controls.Grid.MyGridView dgvmyGridMasterShipmentView;
        private DevExpress.XtraEditors.SimpleButton btnShipmentTiger;
        private DevExpress.XtraEditors.PanelControl pnlShipmentDetail;
        private Controls.Grid.MyGridControl dgvmyGridDetailShipmentControl;
        private Controls.Grid.MyGridView dgvmyGridDetailShipmentView;
        private Controls.Grid.MyGridColumn ShipmentId;
        private Controls.Grid.MyGridColumn WaybillNo;
        private Controls.Grid.MyGridColumn ShipmentDate;
        private Controls.Grid.MyGridColumn Carrier;
        private Controls.Grid.MyGridColumn TrackingNo;
        private Controls.Grid.MyGridColumn State;
        private Controls.Grid.MyGridColumn SenderName;
        private Controls.Grid.MyGridColumn SenderErpId;
        private Controls.Grid.MyGridColumn Products;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private Controls.Grid.MyGridColumn OrderId;
        private Controls.Grid.MyGridColumn OrderPoNo;
        private Controls.Grid.MyGridColumn ProductsProposalId;
        private Controls.Grid.MyGridColumn ProductName;
        private Controls.Grid.MyGridColumn CategoryId;
        private Controls.Grid.MyGridColumn CategoryErpId;
        private Controls.Grid.MyGridColumn Description;
        private Controls.Grid.MyGridColumn ShippedAmount;
        private Controls.Grid.MyGridColumn Unit;
        private Controls.Grid.MyGridColumn Price;
        private Controls.Grid.MyGridColumn CurrencyCode;
        private Controls.Grid.MyGridColumn ErpId;
        private Controls.Grid.MyGridColumn ProductErpId;
        private Controls.Grid.MyGridColumn ProposalNote;
    }
}