
namespace SattaTigerTS.WinApp.Formlar
{
    partial class frmDemandListDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemandListDev));
            this.pnlItemSender = new DevExpress.XtraEditors.PanelControl();
            this.pnlSendProduct = new DevExpress.XtraEditors.PanelControl();
            this.btnItemSync = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSendList = new DevExpress.XtraEditors.PanelControl();
            this.myControlDemandList = new SattaTigerTS.WinApp.Controls.Grid.MyGridControl();
            this.mydgvDemanList = new SattaTigerTS.WinApp.Controls.Grid.MyGridView();
            this.pnlDesc2 = new DevExpress.XtraEditors.PanelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtMainDescription = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.myControlItemList = new SattaTigerTS.WinApp.Controls.Grid.MyGridControl();
            this.mydgvItemlist = new SattaTigerTS.WinApp.Controls.Grid.MyGridView();
            this.colItemRef = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colproduct_erp_id = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colNAME = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.colunit = new SattaTigerTS.WinApp.Controls.Grid.MyGridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.myGridView1 = new SattaTigerTS.WinApp.Controls.Grid.MyGridView();
            this.btnItemSender = new DevExpress.XtraEditors.SimpleButton();
            this.pnlDesc1 = new DevExpress.XtraEditors.PanelControl();
            this.lblAciklamaStatic = new DevExpress.XtraEditors.LabelControl();
            this.pnlItemSelector = new DevExpress.XtraEditors.PanelControl();
            this.pnlAddList = new DevExpress.XtraEditors.PanelControl();
            this.pnlTigerProduct = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlItemSender)).BeginInit();
            this.pnlItemSender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSendProduct)).BeginInit();
            this.pnlSendProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSendList)).BeginInit();
            this.pnlSendList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myControlDemandList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydgvDemanList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesc2)).BeginInit();
            this.pnlDesc2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myControlItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydgvItemlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesc1)).BeginInit();
            this.pnlDesc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlItemSelector)).BeginInit();
            this.pnlItemSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddList)).BeginInit();
            this.pnlAddList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTigerProduct)).BeginInit();
            this.pnlTigerProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlItemSender
            // 
            this.pnlItemSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemSender.Controls.Add(this.pnlSendProduct);
            this.pnlItemSender.Controls.Add(this.pnlSendList);
            this.pnlItemSender.Controls.Add(this.pnlDesc2);
            this.pnlItemSender.Location = new System.Drawing.Point(693, 12);
            this.pnlItemSender.Name = "pnlItemSender";
            this.pnlItemSender.Size = new System.Drawing.Size(651, 774);
            this.pnlItemSender.TabIndex = 1;
            // 
            // pnlSendProduct
            // 
            this.pnlSendProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSendProduct.Controls.Add(this.btnItemSync);
            this.pnlSendProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSendProduct.Location = new System.Drawing.Point(2, 708);
            this.pnlSendProduct.Name = "pnlSendProduct";
            this.pnlSendProduct.Size = new System.Drawing.Size(647, 64);
            this.pnlSendProduct.TabIndex = 5;
            // 
            // btnItemSync
            // 
            this.btnItemSync.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnItemSync.Appearance.Options.UseFont = true;
            this.btnItemSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItemSync.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSync.ImageOptions.Image")));
            this.btnItemSync.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnItemSync.Location = new System.Drawing.Point(2, 2);
            this.btnItemSync.Name = "btnItemSync";
            this.btnItemSync.Size = new System.Drawing.Size(643, 60);
            this.btnItemSync.TabIndex = 2;
            this.btnItemSync.Text = "Listeye Ürün Ekle";
            this.btnItemSync.Click += new System.EventHandler(this.btnItemSync_Click);
            // 
            // pnlSendList
            // 
            this.pnlSendList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSendList.Controls.Add(this.myControlDemandList);
            this.pnlSendList.Location = new System.Drawing.Point(6, 92);
            this.pnlSendList.Name = "pnlSendList";
            this.pnlSendList.Size = new System.Drawing.Size(640, 618);
            this.pnlSendList.TabIndex = 4;
            // 
            // myControlDemandList
            // 
            this.myControlDemandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myControlDemandList.Location = new System.Drawing.Point(2, 2);
            this.myControlDemandList.MainView = this.mydgvDemanList;
            this.myControlDemandList.Name = "myControlDemandList";
            this.myControlDemandList.Size = new System.Drawing.Size(636, 614);
            this.myControlDemandList.TabIndex = 0;
            this.myControlDemandList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mydgvDemanList});
            // 
            // mydgvDemanList
            // 
            this.mydgvDemanList.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.mydgvDemanList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.mydgvDemanList.Appearance.FooterPanel.Options.UseFont = true;
            this.mydgvDemanList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.mydgvDemanList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.mydgvDemanList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.mydgvDemanList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.mydgvDemanList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mydgvDemanList.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.mydgvDemanList.Appearance.ViewCaption.Options.UseForeColor = true;
            this.mydgvDemanList.GridControl = this.myControlDemandList;
            this.mydgvDemanList.Name = "mydgvDemanList";
            this.mydgvDemanList.OptionsFind.AlwaysVisible = true;
            this.mydgvDemanList.OptionsFind.ShowCloseButton = false;
            this.mydgvDemanList.OptionsMenu.EnableGroupPanelMenu = false;
            this.mydgvDemanList.OptionsNavigation.EnterMoveNextColumn = true;
            this.mydgvDemanList.OptionsPrint.AutoWidth = false;
            this.mydgvDemanList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.mydgvDemanList.OptionsView.RowAutoHeight = true;
            this.mydgvDemanList.OptionsView.ShowAutoFilterRow = true;
            this.mydgvDemanList.OptionsView.ShowFooter = true;
            this.mydgvDemanList.OptionsView.ShowGroupPanel = false;
            this.mydgvDemanList.OptionsView.ShowViewCaption = true;
            this.mydgvDemanList.ViewCaption = "Satta Listelerime Gönderilecek Ürünler";
            // 
            // pnlDesc2
            // 
            this.pnlDesc2.Controls.Add(this.lblDescription);
            this.pnlDesc2.Controls.Add(this.txtMainDescription);
            this.pnlDesc2.Location = new System.Drawing.Point(8, 6);
            this.pnlDesc2.Name = "pnlDesc2";
            this.pnlDesc2.Size = new System.Drawing.Size(650, 77);
            this.pnlDesc2.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(6, 8);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(24, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Konu";
            // 
            // txtMainDescription
            // 
            this.txtMainDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainDescription.Location = new System.Drawing.Point(36, 5);
            this.txtMainDescription.Name = "txtMainDescription";
            this.txtMainDescription.Size = new System.Drawing.Size(609, 20);
            this.txtMainDescription.TabIndex = 0;
            // 
            // myControlItemList
            // 
            this.myControlItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myControlItemList.Location = new System.Drawing.Point(2, 2);
            this.myControlItemList.MainView = this.mydgvItemlist;
            this.myControlItemList.Name = "myControlItemList";
            this.myControlItemList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.myControlItemList.Size = new System.Drawing.Size(661, 589);
            this.myControlItemList.TabIndex = 0;
            this.myControlItemList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mydgvItemlist,
            this.myGridView1});
            // 
            // mydgvItemlist
            // 
            this.mydgvItemlist.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.mydgvItemlist.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.mydgvItemlist.Appearance.FooterPanel.Options.UseFont = true;
            this.mydgvItemlist.Appearance.FooterPanel.Options.UseForeColor = true;
            this.mydgvItemlist.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.mydgvItemlist.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.mydgvItemlist.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.mydgvItemlist.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mydgvItemlist.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.mydgvItemlist.Appearance.ViewCaption.Options.UseForeColor = true;
            this.mydgvItemlist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemRef,
            this.colproduct_erp_id,
            this.colNAME,
            this.colunit});
            this.mydgvItemlist.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.mydgvItemlist.GridControl = this.myControlItemList;
            this.mydgvItemlist.Name = "mydgvItemlist";
            this.mydgvItemlist.OptionsFind.AlwaysVisible = true;
            this.mydgvItemlist.OptionsFind.ShowCloseButton = false;
            this.mydgvItemlist.OptionsMenu.EnableGroupPanelMenu = false;
            this.mydgvItemlist.OptionsNavigation.EnterMoveNextColumn = true;
            this.mydgvItemlist.OptionsPrint.AutoWidth = false;
            this.mydgvItemlist.OptionsSelection.CheckBoxSelectorColumnWidth = 50;
            this.mydgvItemlist.OptionsSelection.CheckBoxSelectorField = "selectedProducts";
            this.mydgvItemlist.OptionsSelection.MultiSelect = true;
            this.mydgvItemlist.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.mydgvItemlist.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.mydgvItemlist.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            this.mydgvItemlist.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.mydgvItemlist.OptionsView.RowAutoHeight = true;
            this.mydgvItemlist.OptionsView.ShowAutoFilterRow = true;
            this.mydgvItemlist.OptionsView.ShowFooter = true;
            this.mydgvItemlist.OptionsView.ShowGroupPanel = false;
            this.mydgvItemlist.OptionsView.ShowViewCaption = true;
            this.mydgvItemlist.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.mydgvItemlist.ViewCaption = "Tiger Ürün Listesi";
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
            this.colproduct_erp_id.Caption = "Ürün Kodu";
            this.colproduct_erp_id.FieldName = "product_erp_id";
            this.colproduct_erp_id.Name = "colproduct_erp_id";
            this.colproduct_erp_id.OptionsColumn.AllowEdit = false;
            this.colproduct_erp_id.Visible = true;
            this.colproduct_erp_id.VisibleIndex = 1;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Ürün Açıklaması";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowEdit = false;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 2;
            // 
            // colunit
            // 
            this.colunit.Caption = "Birim";
            this.colunit.FieldName = "unit";
            this.colunit.Name = "colunit";
            this.colunit.OptionsColumn.AllowEdit = false;
            this.colunit.Visible = true;
            this.colunit.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit1.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // myGridView1
            // 
            this.myGridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.myGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.myGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.myGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView1.GridControl = this.myControlItemList;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsFind.AlwaysVisible = true;
            this.myGridView1.OptionsFind.ShowCloseButton = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.myGridView1.OptionsPrint.AutoWidth = false;
            this.myGridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.myGridView1.OptionsView.RowAutoHeight = true;
            this.myGridView1.OptionsView.ShowAutoFilterRow = true;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            // 
            // btnItemSender
            // 
            this.btnItemSender.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnItemSender.Appearance.Options.UseFont = true;
            this.btnItemSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItemSender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSender.ImageOptions.Image")));
            this.btnItemSender.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnItemSender.Location = new System.Drawing.Point(2, 2);
            this.btnItemSender.Name = "btnItemSender";
            this.btnItemSender.Size = new System.Drawing.Size(654, 57);
            this.btnItemSender.TabIndex = 1;
            this.btnItemSender.Text = "Listeye Ürün Ekle";
            this.btnItemSender.Click += new System.EventHandler(this.btnItemSender_Click);
            // 
            // pnlDesc1
            // 
            this.pnlDesc1.Controls.Add(this.lblAciklamaStatic);
            this.pnlDesc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDesc1.Location = new System.Drawing.Point(2, 2);
            this.pnlDesc1.Name = "pnlDesc1";
            this.pnlDesc1.Size = new System.Drawing.Size(671, 80);
            this.pnlDesc1.TabIndex = 2;
            // 
            // lblAciklamaStatic
            // 
            this.lblAciklamaStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAciklamaStatic.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblAciklamaStatic.LineVisible = true;
            this.lblAciklamaStatic.Location = new System.Drawing.Point(5, 5);
            this.lblAciklamaStatic.Name = "lblAciklamaStatic";
            this.lblAciklamaStatic.Size = new System.Drawing.Size(661, 26);
            this.lblAciklamaStatic.TabIndex = 2;
            this.lblAciklamaStatic.Text = "Sağ taraftaki konu başlığını doldurarak istediğiniz ürünleri Satta Talep Listesin" +
    "e dönüştürebilirsiniz. Ürünleri seçip sağ tarafa ekleyin. Konuyu boş bırakmayını" +
    "z. ";
            // 
            // pnlItemSelector
            // 
            this.pnlItemSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemSelector.Controls.Add(this.pnlAddList);
            this.pnlItemSelector.Controls.Add(this.pnlTigerProduct);
            this.pnlItemSelector.Controls.Add(this.pnlDesc1);
            this.pnlItemSelector.Location = new System.Drawing.Point(12, 13);
            this.pnlItemSelector.Name = "pnlItemSelector";
            this.pnlItemSelector.Size = new System.Drawing.Size(675, 753);
            this.pnlItemSelector.TabIndex = 0;
            // 
            // pnlAddList
            // 
            this.pnlAddList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddList.Controls.Add(this.btnItemSender);
            this.pnlAddList.Location = new System.Drawing.Point(6, 687);
            this.pnlAddList.Name = "pnlAddList";
            this.pnlAddList.Size = new System.Drawing.Size(658, 61);
            this.pnlAddList.TabIndex = 4;
            // 
            // pnlTigerProduct
            // 
            this.pnlTigerProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTigerProduct.Controls.Add(this.myControlItemList);
            this.pnlTigerProduct.Location = new System.Drawing.Point(5, 88);
            this.pnlTigerProduct.Name = "pnlTigerProduct";
            this.pnlTigerProduct.Size = new System.Drawing.Size(665, 593);
            this.pnlTigerProduct.TabIndex = 3;
            // 
            // frmDemandListDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 770);
            this.Controls.Add(this.pnlItemSender);
            this.Controls.Add(this.pnlItemSelector);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmDemandListDev.IconOptions.Image")));
            this.Name = "frmDemandListDev";
            this.Text = "Liste Oluşturma";
            this.Load += new System.EventHandler(this.frmDemandListDev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlItemSender)).EndInit();
            this.pnlItemSender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSendProduct)).EndInit();
            this.pnlSendProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSendList)).EndInit();
            this.pnlSendList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myControlDemandList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydgvDemanList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesc2)).EndInit();
            this.pnlDesc2.ResumeLayout(false);
            this.pnlDesc2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myControlItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydgvItemlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesc1)).EndInit();
            this.pnlDesc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlItemSelector)).EndInit();
            this.pnlItemSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddList)).EndInit();
            this.pnlAddList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTigerProduct)).EndInit();
            this.pnlTigerProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnlItemSender;
        private DevExpress.XtraEditors.SimpleButton btnItemSync;
        private Controls.Grid.MyGridControl myControlDemandList;
        private Controls.Grid.MyGridView mydgvDemanList;
        private DevExpress.XtraEditors.PanelControl pnlDesc2;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtMainDescription;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Controls.Grid.MyGridControl myControlItemList;
        private Controls.Grid.MyGridView mydgvItemlist;
        private Controls.Grid.MyGridColumn colItemRef;
        private Controls.Grid.MyGridColumn colproduct_erp_id;
        private Controls.Grid.MyGridColumn colNAME;
        private Controls.Grid.MyGridColumn colunit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private Controls.Grid.MyGridView myGridView1;
        private DevExpress.XtraEditors.SimpleButton btnItemSender;
        private DevExpress.XtraEditors.PanelControl pnlDesc1;
        private DevExpress.XtraEditors.LabelControl lblAciklamaStatic;
        private DevExpress.XtraEditors.PanelControl pnlItemSelector;
        private DevExpress.XtraEditors.PanelControl pnlAddList;
        private DevExpress.XtraEditors.PanelControl pnlTigerProduct;
        private DevExpress.XtraEditors.PanelControl pnlSendProduct;
        private DevExpress.XtraEditors.PanelControl pnlSendList;
    }
}