
namespace SattaTigerTS.WinApp.Formlar
{
    partial class frmTalepList2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTalepList2));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUnselectAllDemand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectAllDemand = new System.Windows.Forms.Button();
            this.txtMainDescription = new System.Windows.Forms.TextBox();
            this.btnSendJsonSatta = new System.Windows.Forms.Button();
            this.dgvDemandList = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_erp_id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requester_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnUnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.ItemRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_erp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCodeSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.frmTalepList2layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SattaTigerTS.WinApp.Formlar.WaitForm1), true, true);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmTalepList2layoutControl1ConvertedLayout)).BeginInit();
            this.frmTalepList2layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnUnselectAllDemand);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSelectAllDemand);
            this.panel3.Controls.Add(this.txtMainDescription);
            this.panel3.Controls.Add(this.btnSendJsonSatta);
            this.panel3.Controls.Add(this.dgvDemandList);
            this.panel3.Location = new System.Drawing.Point(606, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 645);
            this.panel3.TabIndex = 4;
            // 
            // btnUnselectAllDemand
            // 
            this.btnUnselectAllDemand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnselectAllDemand.Location = new System.Drawing.Point(137, 49);
            this.btnUnselectAllDemand.Name = "btnUnselectAllDemand";
            this.btnUnselectAllDemand.Size = new System.Drawing.Size(88, 23);
            this.btnUnselectAllDemand.TabIndex = 9;
            this.btnUnselectAllDemand.Text = "Seçimi Kaldır";
            this.btnUnselectAllDemand.UseVisualStyleBackColor = true;
            this.btnUnselectAllDemand.Click += new System.EventHandler(this.btnUnselectAllDemand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Konu:";
            // 
            // btnSelectAllDemand
            // 
            this.btnSelectAllDemand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAllDemand.Location = new System.Drawing.Point(43, 50);
            this.btnSelectAllDemand.Name = "btnSelectAllDemand";
            this.btnSelectAllDemand.Size = new System.Drawing.Size(88, 23);
            this.btnSelectAllDemand.TabIndex = 8;
            this.btnSelectAllDemand.Text = "Tümünü Seç";
            this.btnSelectAllDemand.UseVisualStyleBackColor = true;
            this.btnSelectAllDemand.Click += new System.EventHandler(this.btnSelectAllDemand_Click);
            // 
            // txtMainDescription
            // 
            this.txtMainDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainDescription.Location = new System.Drawing.Point(85, 3);
            this.txtMainDescription.Name = "txtMainDescription";
            this.txtMainDescription.Size = new System.Drawing.Size(485, 20);
            this.txtMainDescription.TabIndex = 6;
            // 
            // btnSendJsonSatta
            // 
            this.btnSendJsonSatta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendJsonSatta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendJsonSatta.Location = new System.Drawing.Point(3, 598);
            this.btnSendJsonSatta.Name = "btnSendJsonSatta";
            this.btnSendJsonSatta.Size = new System.Drawing.Size(572, 44);
            this.btnSendJsonSatta.TabIndex = 0;
            this.btnSendJsonSatta.Text = "Listeyi Sattaya Gönder";
            this.btnSendJsonSatta.UseVisualStyleBackColor = true;
            this.btnSendJsonSatta.Click += new System.EventHandler(this.btnSendJsonSatta_Click);
            // 
            // dgvDemandList
            // 
            this.dgvDemandList.AllowUserToAddRows = false;
            this.dgvDemandList.AllowUserToDeleteRows = false;
            this.dgvDemandList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDemandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemandList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.product_erp_id2,
            this.name2,
            this.requester_amount,
            this.unit2,
            this.itemSelection});
            this.dgvDemandList.Location = new System.Drawing.Point(3, 96);
            this.dgvDemandList.Name = "dgvDemandList";
            this.dgvDemandList.Size = new System.Drawing.Size(572, 499);
            this.dgvDemandList.TabIndex = 3;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Kategori";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 71;
            // 
            // product_erp_id2
            // 
            this.product_erp_id2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.product_erp_id2.DataPropertyName = "product_erp_id";
            this.product_erp_id2.HeaderText = "Ürün Kodu";
            this.product_erp_id2.Name = "product_erp_id2";
            this.product_erp_id2.Width = 77;
            // 
            // name2
            // 
            this.name2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name2.DataPropertyName = "name";
            this.name2.HeaderText = "Ürün Açıklaması";
            this.name2.Name = "name2";
            // 
            // requester_amount
            // 
            this.requester_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.requester_amount.DataPropertyName = "requester_amount";
            this.requester_amount.HeaderText = "Miktar";
            this.requester_amount.Name = "requester_amount";
            this.requester_amount.Width = 61;
            // 
            // unit2
            // 
            this.unit2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unit2.DataPropertyName = "unit";
            this.unit2.HeaderText = "Birim";
            this.unit2.Name = "unit2";
            this.unit2.Width = 54;
            // 
            // itemSelection
            // 
            this.itemSelection.DataPropertyName = "itemSelection";
            this.itemSelection.HeaderText = "Seç";
            this.itemSelection.Name = "itemSelection";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnItemAdd);
            this.panel1.Controls.Add(this.btnUnSelectAll);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNameSearch);
            this.panel1.Controls.Add(this.dgvItemList);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.txtCodeSearch);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 645);
            this.panel1.TabIndex = 1;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItemAdd.Location = new System.Drawing.Point(3, 598);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(579, 44);
            this.btnItemAdd.TabIndex = 4;
            this.btnItemAdd.Text = ">>>";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnUnSelectAll
            // 
            this.btnUnSelectAll.Location = new System.Drawing.Point(108, 53);
            this.btnUnSelectAll.Name = "btnUnSelectAll";
            this.btnUnSelectAll.Size = new System.Drawing.Size(88, 23);
            this.btnUnSelectAll.TabIndex = 7;
            this.btnUnSelectAll.Text = "Seçimi Kaldır";
            this.btnUnSelectAll.UseVisualStyleBackColor = true;
            this.btnUnSelectAll.Click += new System.EventHandler(this.btnUnSelectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(14, 54);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(88, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "Tümünü Seç";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Açıklamasına Göre Arama";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(176, 31);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(317, 20);
            this.txtNameSearch.TabIndex = 2;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemRef,
            this.product_erp_id,
            this.name,
            this.unit});
            this.dgvItemList.Location = new System.Drawing.Point(3, 96);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.Size = new System.Drawing.Size(579, 499);
            this.dgvItemList.TabIndex = 5;
            // 
            // ItemRef
            // 
            this.ItemRef.DataPropertyName = "ItemRef";
            this.ItemRef.HeaderText = "ItemRef";
            this.ItemRef.Name = "ItemRef";
            this.ItemRef.ReadOnly = true;
            this.ItemRef.Visible = false;
            // 
            // product_erp_id
            // 
            this.product_erp_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.product_erp_id.DataPropertyName = "product_erp_id";
            this.product_erp_id.HeaderText = "Ürün Kodu";
            this.product_erp_id.Name = "product_erp_id";
            this.product_erp_id.ReadOnly = true;
            this.product_erp_id.Width = 77;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Ürün Açıklaması";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Birim";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 54;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(7, 8);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(91, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Koda Göre Arama";
            // 
            // txtCodeSearch
            // 
            this.txtCodeSearch.Location = new System.Drawing.Point(176, 5);
            this.txtCodeSearch.Name = "txtCodeSearch";
            this.txtCodeSearch.Size = new System.Drawing.Size(317, 20);
            this.txtCodeSearch.TabIndex = 0;
            this.txtCodeSearch.TextChanged += new System.EventHandler(this.txtCodeSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 651);
            this.panel2.TabIndex = 5;
            // 
            // frmTalepList2layoutControl1ConvertedLayout
            // 
            this.frmTalepList2layoutControl1ConvertedLayout.Controls.Add(this.panel2);
            this.frmTalepList2layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmTalepList2layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmTalepList2layoutControl1ConvertedLayout.Name = "frmTalepList2layoutControl1ConvertedLayout";
            this.frmTalepList2layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmTalepList2layoutControl1ConvertedLayout.Size = new System.Drawing.Size(1199, 663);
            this.frmTalepList2layoutControl1ConvertedLayout.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.panel2item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1199, 663);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // panel2item
            // 
            this.panel2item.Control = this.panel2;
            this.panel2item.Location = new System.Drawing.Point(0, 0);
            this.panel2item.Name = "panel2item";
            this.panel2item.Size = new System.Drawing.Size(1189, 653);
            this.panel2item.TextSize = new System.Drawing.Size(0, 0);
            this.panel2item.TextVisible = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmTalepList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1199, 663);
            this.Controls.Add(this.frmTalepList2layoutControl1ConvertedLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTalepList2";
            this.Text = "Sattaya Favori Listesi Gönder";
            this.Load += new System.EventHandler(this.frmTalepList_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmTalepList2layoutControl1ConvertedLayout)).EndInit();
            this.frmTalepList2layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUnselectAllDemand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectAllDemand;
        private System.Windows.Forms.TextBox txtMainDescription;
        private System.Windows.Forms.Button btnSendJsonSatta;
        private System.Windows.Forms.DataGridView dgvDemandList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_erp_id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn requester_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemSelection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnSelectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_erp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCodeSearch;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraLayout.LayoutControl frmTalepList2layoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem panel2item;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}