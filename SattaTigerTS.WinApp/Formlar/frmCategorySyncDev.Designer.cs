
namespace SattaTigerTS.WinApp.Formlar
{
    partial class frmCategorySyncDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorySyncDev));
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlBestOfItem = new DevExpress.XtraEditors.PanelControl();
            this.dgvControlBestOfItem = new SattaTigerTS.WinApp.Controls.Grid.MyGridControl();
            this.dgvMyBestOfItem = new SattaTigerTS.WinApp.Controls.Grid.MyGridView();
            this.colItemRef = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colproduct_erp_id = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colNAME = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colunit = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colSAY = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colTOPLAMTUTAR = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colSONIRSALIYETARIHI = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.btnItemToCategory = new DevExpress.XtraEditors.SimpleButton();
            this.pnlCategorySync = new DevExpress.XtraEditors.PanelControl();
            this.dgvControlCategorySync = new SattaTigerTS.WinApp.Controls.Grid.MyGridControl();
            this.dgvMyCategorySyncDev = new SattaTigerTS.WinApp.Controls.Grid.MyGridView();
            this.colProductErpId = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colCategoryDesc = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colCategoryUnit = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.btnSendCategorySatta = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBestOfItem)).BeginInit();
            this.pnlBestOfItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlBestOfItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBestOfItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCategorySync)).BeginInit();
            this.pnlCategorySync.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlCategorySync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCategorySyncDev)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // pnlBestOfItem
            // 
            this.pnlBestOfItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBestOfItem.Controls.Add(this.dgvControlBestOfItem);
            this.pnlBestOfItem.Controls.Add(this.btnItemToCategory);
            this.pnlBestOfItem.Location = new System.Drawing.Point(12, 12);
            this.pnlBestOfItem.Name = "pnlBestOfItem";
            this.pnlBestOfItem.Size = new System.Drawing.Size(853, 678);
            this.pnlBestOfItem.TabIndex = 5;
            // 
            // dgvControlBestOfItem
            // 
            this.dgvControlBestOfItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControlBestOfItem.Location = new System.Drawing.Point(2, 2);
            this.dgvControlBestOfItem.MainView = this.dgvMyBestOfItem;
            this.dgvControlBestOfItem.Name = "dgvControlBestOfItem";
            this.dgvControlBestOfItem.Size = new System.Drawing.Size(849, 631);
            this.dgvControlBestOfItem.TabIndex = 6;
            this.dgvControlBestOfItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMyBestOfItem});
            // 
            // dgvMyBestOfItem
            // 
            this.dgvMyBestOfItem.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dgvMyBestOfItem.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvMyBestOfItem.Appearance.FooterPanel.Options.UseFont = true;
            this.dgvMyBestOfItem.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dgvMyBestOfItem.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvMyBestOfItem.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgvMyBestOfItem.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvMyBestOfItem.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvMyBestOfItem.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.dgvMyBestOfItem.Appearance.ViewCaption.Options.UseForeColor = true;
            this.dgvMyBestOfItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemRef,
            this.colproduct_erp_id,
            this.colNAME,
            this.colunit,
            this.colSAY,
            this.colTOPLAMTUTAR,
            this.colSONIRSALIYETARIHI});
            this.dgvMyBestOfItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvMyBestOfItem.GridControl = this.dgvControlBestOfItem;
            this.dgvMyBestOfItem.Name = "dgvMyBestOfItem";
            this.dgvMyBestOfItem.OptionsFind.AlwaysVisible = true;
            this.dgvMyBestOfItem.OptionsFind.ShowCloseButton = false;
            this.dgvMyBestOfItem.OptionsMenu.EnableGroupPanelMenu = false;
            this.dgvMyBestOfItem.OptionsNavigation.EnterMoveNextColumn = true;
            this.dgvMyBestOfItem.OptionsPrint.AutoWidth = false;
            this.dgvMyBestOfItem.OptionsSelection.CheckBoxSelectorColumnWidth = 50;
            this.dgvMyBestOfItem.OptionsSelection.CheckBoxSelectorField = "selectedItem";
            this.dgvMyBestOfItem.OptionsSelection.MultiSelect = true;
            this.dgvMyBestOfItem.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.dgvMyBestOfItem.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.dgvMyBestOfItem.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            this.dgvMyBestOfItem.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.dgvMyBestOfItem.OptionsView.RowAutoHeight = true;
            this.dgvMyBestOfItem.OptionsView.ShowAutoFilterRow = true;
            this.dgvMyBestOfItem.OptionsView.ShowGroupPanel = false;
            this.dgvMyBestOfItem.OptionsView.ShowViewCaption = true;
            this.dgvMyBestOfItem.ViewCaption = "Hareket Görmüş Ürünler";
            // 
            // colItemRef
            // 
            this.colItemRef.Caption = "ItemRef";
            this.colItemRef.FieldName = "ItemRef";
            this.colItemRef.Name = "colItemRef";
            this.colItemRef.OptionsColumn.AllowEdit = false;
            // 
            // colproduct_erp_id
            // 
            this.colproduct_erp_id.Caption = "Kategori Kodu";
            this.colproduct_erp_id.FieldName = "product_erp_id";
            this.colproduct_erp_id.Name = "colproduct_erp_id";
            this.colproduct_erp_id.OptionsColumn.AllowEdit = false;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Kategori Açıklaması";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowEdit = false;
            // 
            // colunit
            // 
            this.colunit.Caption = "Birim";
            this.colunit.FieldName = "unit";
            this.colunit.Name = "colunit";
            this.colunit.OptionsColumn.AllowEdit = false;
            // 
            // colSAY
            // 
            this.colSAY.Caption = "Say";
            this.colSAY.FieldName = "SAY";
            this.colSAY.Name = "colSAY";
            this.colSAY.OptionsColumn.AllowEdit = false;
            // 
            // colTOPLAMTUTAR
            // 
            this.colTOPLAMTUTAR.Caption = "Toplam Alım Tutar";
            this.colTOPLAMTUTAR.FieldName = "TOPLAMTUTAR";
            this.colTOPLAMTUTAR.Name = "colTOPLAMTUTAR";
            this.colTOPLAMTUTAR.OptionsColumn.AllowEdit = false;
            // 
            // colSONIRSALIYETARIHI
            // 
            this.colSONIRSALIYETARIHI.Caption = "Son İrsaliye Tarihi";
            this.colSONIRSALIYETARIHI.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colSONIRSALIYETARIHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSONIRSALIYETARIHI.FieldName = "SONIRSALIYETARIHI";
            this.colSONIRSALIYETARIHI.Name = "colSONIRSALIYETARIHI";
            this.colSONIRSALIYETARIHI.OptionsColumn.AllowEdit = false;
            // 
            // btnItemToCategory
            // 
            this.btnItemToCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItemToCategory.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnItemToCategory.Appearance.Options.UseFont = true;
            this.btnItemToCategory.Appearance.Options.UseForeColor = true;
            this.btnItemToCategory.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnItemToCategory.AppearanceDisabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnItemToCategory.AppearanceDisabled.BorderColor = System.Drawing.Color.Red;
            this.btnItemToCategory.AppearanceDisabled.Options.UseBackColor = true;
            this.btnItemToCategory.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnItemToCategory.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnItemToCategory.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnItemToCategory.AppearanceHovered.BorderColor = System.Drawing.Color.Silver;
            this.btnItemToCategory.AppearanceHovered.Options.UseBackColor = true;
            this.btnItemToCategory.AppearanceHovered.Options.UseBorderColor = true;
            this.btnItemToCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnItemToCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemToCategory.ImageOptions.Image")));
            this.btnItemToCategory.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnItemToCategory.Location = new System.Drawing.Point(2, 633);
            this.btnItemToCategory.Name = "btnItemToCategory";
            this.btnItemToCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnItemToCategory.Size = new System.Drawing.Size(849, 43);
            this.btnItemToCategory.TabIndex = 5;
            this.btnItemToCategory.Text = "Satta\'ya Gönderilecek Tabloya Aktar";
            this.btnItemToCategory.Click += new System.EventHandler(this.btnItemToCategory_Click);
            // 
            // pnlCategorySync
            // 
            this.pnlCategorySync.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategorySync.Controls.Add(this.dgvControlCategorySync);
            this.pnlCategorySync.Controls.Add(this.btnSendCategorySatta);
            this.pnlCategorySync.Location = new System.Drawing.Point(871, 12);
            this.pnlCategorySync.Name = "pnlCategorySync";
            this.pnlCategorySync.Size = new System.Drawing.Size(547, 678);
            this.pnlCategorySync.TabIndex = 6;
            // 
            // dgvControlCategorySync
            // 
            this.dgvControlCategorySync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControlCategorySync.Location = new System.Drawing.Point(2, 2);
            this.dgvControlCategorySync.MainView = this.dgvMyCategorySyncDev;
            this.dgvControlCategorySync.Name = "dgvControlCategorySync";
            this.dgvControlCategorySync.Size = new System.Drawing.Size(543, 631);
            this.dgvControlCategorySync.TabIndex = 2;
            this.dgvControlCategorySync.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMyCategorySyncDev});
            // 
            // dgvMyCategorySyncDev
            // 
            this.dgvMyCategorySyncDev.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dgvMyCategorySyncDev.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvMyCategorySyncDev.Appearance.FooterPanel.Options.UseFont = true;
            this.dgvMyCategorySyncDev.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dgvMyCategorySyncDev.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.dgvMyCategorySyncDev.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgvMyCategorySyncDev.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvMyCategorySyncDev.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvMyCategorySyncDev.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.dgvMyCategorySyncDev.Appearance.ViewCaption.Options.UseForeColor = true;
            this.dgvMyCategorySyncDev.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductErpId,
            this.colCategoryDesc,
            this.colCategoryUnit});
            this.dgvMyCategorySyncDev.GridControl = this.dgvControlCategorySync;
            this.dgvMyCategorySyncDev.Name = "dgvMyCategorySyncDev";
            this.dgvMyCategorySyncDev.OptionsFind.AlwaysVisible = true;
            this.dgvMyCategorySyncDev.OptionsFind.ShowCloseButton = false;
            this.dgvMyCategorySyncDev.OptionsMenu.EnableGroupPanelMenu = false;
            this.dgvMyCategorySyncDev.OptionsNavigation.EnterMoveNextColumn = true;
            this.dgvMyCategorySyncDev.OptionsPrint.AutoWidth = false;
            this.dgvMyCategorySyncDev.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.dgvMyCategorySyncDev.OptionsView.RowAutoHeight = true;
            this.dgvMyCategorySyncDev.OptionsView.ShowAutoFilterRow = true;
            this.dgvMyCategorySyncDev.OptionsView.ShowGroupPanel = false;
            this.dgvMyCategorySyncDev.OptionsView.ShowViewCaption = true;
            this.dgvMyCategorySyncDev.ViewCaption = "Satta\'ya Gönderilecek Kategoriler";
            // 
            // colProductErpId
            // 
            this.colProductErpId.Caption = "Kategori ID";
            this.colProductErpId.FieldName = "ProductErpId";
            this.colProductErpId.Name = "colProductErpId";
            this.colProductErpId.OptionsColumn.AllowEdit = false;
            this.colProductErpId.Visible = true;
            this.colProductErpId.VisibleIndex = 0;
            // 
            // colCategoryDesc
            // 
            this.colCategoryDesc.Caption = "Kategori Tanımı";
            this.colCategoryDesc.FieldName = "CategoryDesc";
            this.colCategoryDesc.Name = "colCategoryDesc";
            this.colCategoryDesc.OptionsColumn.AllowEdit = false;
            this.colCategoryDesc.Visible = true;
            this.colCategoryDesc.VisibleIndex = 1;
            // 
            // colCategoryUnit
            // 
            this.colCategoryUnit.Caption = "Birim";
            this.colCategoryUnit.FieldName = "CategoryUnit";
            this.colCategoryUnit.Name = "colCategoryUnit";
            this.colCategoryUnit.OptionsColumn.AllowEdit = false;
            this.colCategoryUnit.Visible = true;
            this.colCategoryUnit.VisibleIndex = 2;
            // 
            // btnSendCategorySatta
            // 
            this.btnSendCategorySatta.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendCategorySatta.Appearance.Options.UseFont = true;
            this.btnSendCategorySatta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendCategorySatta.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnSendCategorySatta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSendCategorySatta.ImageOptions.Image")));
            this.btnSendCategorySatta.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSendCategorySatta.Location = new System.Drawing.Point(2, 633);
            this.btnSendCategorySatta.Name = "btnSendCategorySatta";
            this.btnSendCategorySatta.Size = new System.Drawing.Size(543, 43);
            this.btnSendCategorySatta.TabIndex = 1;
            this.btnSendCategorySatta.Text = "Sattaya Gönder";
            this.btnSendCategorySatta.Click += new System.EventHandler(this.btnSendCategorySatta_Click);
            // 
            // frmCategorySyncDev
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 702);
            this.Controls.Add(this.pnlCategorySync);
            this.Controls.Add(this.pnlBestOfItem);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmCategorySyncDev.IconOptions.LargeImage")));
            this.Name = "frmCategorySyncDev";
            this.Text = "Satta\'ya Kategori Gönder";
            this.Load += new System.EventHandler(this.frmCategorySyncDev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBestOfItem)).EndInit();
            this.pnlBestOfItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlBestOfItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBestOfItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCategorySync)).EndInit();
            this.pnlCategorySync.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlCategorySync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCategorySyncDev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private Controls.Grid.MyGridControl dgvControlBestOfItem;
        //private Controls.Grid.MyGridView dgvMyBestOfItem;
        //private Controls.Grid.MyGridColumn colItemRef;
        //private Controls.Grid.MyGridColumn colproduct_erp_id;
        //private Controls.Grid.MyGridColumn colNAME;
        //private Controls.Grid.MyGridColumn colunit;
        private DevExpress.XtraEditors.PanelControl pnlBestOfItem;
        private DevExpress.XtraEditors.PanelControl pnlCategorySync;
        //private Controls.Grid.MyGridControl dgvControlCategorySync;
        //private Controls.Grid.MyGridView dgvMyCategorySyncDev;
        private DevExpress.XtraEditors.SimpleButton btnItemToCategory;
        private DevExpress.XtraEditors.SimpleButton btnSendCategorySatta;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        //private Controls.Grid.MyGridColumn colSAY;
        //private Controls.Grid.MyGridColumn colTOPLAMTUTAR;
        //private Controls.Grid.MyGridColumn colSONIRSALIYETARIHI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        //private Controls.Grid.MyGridColumn colProductErpId;
        //private Controls.Grid.MyGridColumn colCategoryDesc;
        //private Controls.Grid.MyGridColumn colCategoryUnit;
        private Controls.Grid.MyGridControl dgvControlBestOfItem;
        private Controls.Grid.MyGridView dgvMyBestOfItem;
        private Controls.Grid.MyGridControl dgvControlCategorySync;
        private Controls.Grid.MyGridView dgvMyCategorySyncDev;
        private Controls.Grid.MyGridColumn colItemRef;
        private Controls.Grid.MyGridColumn colproduct_erp_id;
        private Controls.Grid.MyGridColumn colNAME;
        private Controls.Grid.MyGridColumn colunit;
        private Controls.Grid.MyGridColumn colSAY;
        private Controls.Grid.MyGridColumn colTOPLAMTUTAR;
        private Controls.Grid.MyGridColumn colSONIRSALIYETARIHI;
        private Controls.Grid.MyGridColumn colProductErpId;
        private Controls.Grid.MyGridColumn colCategoryDesc;
        private Controls.Grid.MyGridColumn colCategoryUnit;
    }
}