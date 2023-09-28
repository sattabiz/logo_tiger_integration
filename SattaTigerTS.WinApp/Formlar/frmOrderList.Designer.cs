
namespace SattaTigerTS.WinApp.Formlar
{
    partial class frmOrderList
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
            this.dgvMasterOrderList = new System.Windows.Forms.DataGridView();
            this.SelectedItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProposalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierErpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierTaxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandCreatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcurementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetailOrderList = new System.Windows.Forms.DataGridView();
            this.SelectedItemProduct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductErpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProductErpId = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProposalNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryErpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductProposalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTigerOrderTrans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTalepNo = new System.Windows.Forms.TextBox();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.txtTedarikciVergiNo = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SattaTigerTS.WinApp.Formlar.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrderList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMasterOrderList
            // 
            this.dgvMasterOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasterOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedItem,
            this.Id,
            this.OrderDate,
            this.ProposalId,
            this.State,
            this.Supplier,
            this.SupplierErpId,
            this.SupplierTaxId,
            this.DeliveryDate,
            this.PaymentDueDate,
            this.PaymentType,
            this.DemandName,
            this.DemandNo,
            this.DemandCreatorName,
            this.ProcurementName});
            this.dgvMasterOrderList.Location = new System.Drawing.Point(13, 69);
            this.dgvMasterOrderList.Name = "dgvMasterOrderList";
            this.dgvMasterOrderList.Size = new System.Drawing.Size(1177, 253);
            this.dgvMasterOrderList.TabIndex = 0;
            this.dgvMasterOrderList.SelectionChanged += new System.EventHandler(this.SatirSec);
            // 
            // SelectedItem
            // 
            this.SelectedItem.DataPropertyName = "SelectedItem";
            this.SelectedItem.HeaderText = "Seç";
            this.SelectedItem.Name = "SelectedItem";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Sipariş No";
            this.Id.Name = "Id";
            this.Id.Width = 74;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Sipariş Tarihi";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 85;
            // 
            // ProposalId
            // 
            this.ProposalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProposalId.DataPropertyName = "ProposalId";
            this.ProposalId.HeaderText = "Teklif No";
            this.ProposalId.Name = "ProposalId";
            this.ProposalId.Width = 69;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Durum";
            this.State.Name = "State";
            this.State.Width = 63;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Tedarikçi";
            this.Supplier.Name = "Supplier";
            this.Supplier.Width = 76;
            // 
            // SupplierErpId
            // 
            this.SupplierErpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SupplierErpId.DataPropertyName = "SupplierErpId";
            this.SupplierErpId.HeaderText = "Tedarikçi ERP";
            this.SupplierErpId.Name = "SupplierErpId";
            this.SupplierErpId.Width = 93;
            // 
            // SupplierTaxId
            // 
            this.SupplierTaxId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SupplierTaxId.DataPropertyName = "SupplierTaxId";
            this.SupplierTaxId.HeaderText = "Tedarikçi Vergi No";
            this.SupplierTaxId.Name = "SupplierTaxId";
            this.SupplierTaxId.Width = 97;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Teslim Tarihi";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Width = 84;
            // 
            // PaymentDueDate
            // 
            this.PaymentDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentDueDate.DataPropertyName = "PaymentDueDate";
            this.PaymentDueDate.HeaderText = "Vade";
            this.PaymentDueDate.Name = "PaymentDueDate";
            this.PaymentDueDate.Width = 57;
            // 
            // PaymentType
            // 
            this.PaymentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "Ödeme Tipi";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Width = 79;
            // 
            // DemandName
            // 
            this.DemandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DemandName.DataPropertyName = "DemandName";
            this.DemandName.HeaderText = "Talep Açıklaması";
            this.DemandName.Name = "DemandName";
            // 
            // DemandNo
            // 
            this.DemandNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DemandNo.DataPropertyName = "DemandNo";
            this.DemandNo.HeaderText = "Talep No";
            this.DemandNo.Name = "DemandNo";
            this.DemandNo.Width = 70;
            // 
            // DemandCreatorName
            // 
            this.DemandCreatorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DemandCreatorName.DataPropertyName = "DemandCreatorName";
            this.DemandCreatorName.HeaderText = "Talep Sahibi";
            this.DemandCreatorName.Name = "DemandCreatorName";
            this.DemandCreatorName.Width = 84;
            // 
            // ProcurementName
            // 
            this.ProcurementName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProcurementName.DataPropertyName = "ProcurementName";
            this.ProcurementName.HeaderText = "Satın Alma Yetkili";
            this.ProcurementName.Name = "ProcurementName";
            this.ProcurementName.Width = 104;
            // 
            // dgvDetailOrderList
            // 
            this.dgvDetailOrderList.AllowUserToAddRows = false;
            this.dgvDetailOrderList.AllowUserToDeleteRows = false;
            this.dgvDetailOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedItemProduct,
            this.Name_,
            this.Description,
            this.Amount,
            this.Unit,
            this.Price,
            this.CurrencyCode,
            this.ErpId,
            this.ProductErpId,
            this.btnProductErpId,
            this.ProposalNote,
            this.CategoryErpId,
            this.ProductProposalId,
            this.CategoryId});
            this.dgvDetailOrderList.Location = new System.Drawing.Point(12, 328);
            this.dgvDetailOrderList.Name = "dgvDetailOrderList";
            this.dgvDetailOrderList.Size = new System.Drawing.Size(1178, 236);
            this.dgvDetailOrderList.TabIndex = 1;
            // 
            // SelectedItemProduct
            // 
            this.SelectedItemProduct.DataPropertyName = "SelectedItemProduct";
            this.SelectedItemProduct.HeaderText = "Seç";
            this.SelectedItemProduct.Name = "SelectedItemProduct";
            // 
            // Name_
            // 
            this.Name_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_.DataPropertyName = "Name";
            this.Name_.HeaderText = "Ürün Adı";
            this.Name_.Name = "Name_";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Açıklaması";
            this.Description.Name = "Description";
            this.Description.Width = 82;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Miktar";
            this.Amount.Name = "Amount";
            this.Amount.Width = 61;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Birim";
            this.Unit.Name = "Unit";
            this.Unit.Width = 54;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Fiyat";
            this.Price.Name = "Price";
            this.Price.Width = 54;
            // 
            // CurrencyCode
            // 
            this.CurrencyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CurrencyCode.DataPropertyName = "CurrencyCode";
            this.CurrencyCode.HeaderText = "Döviz Türü";
            this.CurrencyCode.Name = "CurrencyCode";
            this.CurrencyCode.Width = 78;
            // 
            // ErpId
            // 
            this.ErpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ErpId.DataPropertyName = "ErpId";
            this.ErpId.HeaderText = "ErpId";
            this.ErpId.Name = "ErpId";
            this.ErpId.Width = 57;
            // 
            // ProductErpId
            // 
            this.ProductErpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductErpId.DataPropertyName = "ProductErpId";
            this.ProductErpId.HeaderText = "ProductErpId";
            this.ProductErpId.Name = "ProductErpId";
            this.ProductErpId.Width = 94;
            // 
            // btnProductErpId
            // 
            this.btnProductErpId.HeaderText = "Ürün Değiştir";
            this.btnProductErpId.Name = "btnProductErpId";
            // 
            // ProposalNote
            // 
            this.ProposalNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProposalNote.DataPropertyName = "ProposalNote";
            this.ProposalNote.HeaderText = "Teklif Notu";
            this.ProposalNote.Name = "ProposalNote";
            // 
            // CategoryErpId
            // 
            this.CategoryErpId.DataPropertyName = "CategoryErpId";
            this.CategoryErpId.HeaderText = "Kategori ERP ID";
            this.CategoryErpId.Name = "CategoryErpId";
            // 
            // ProductProposalId
            // 
            this.ProductProposalId.DataPropertyName = "ProductProposalId";
            this.ProductProposalId.HeaderText = "Satınalma Teklif No";
            this.ProductProposalId.Name = "ProductProposalId";
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "Satta Kategori Id";
            this.CategoryId.Name = "CategoryId";
            // 
            // btnTigerOrderTrans
            // 
            this.btnTigerOrderTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTigerOrderTrans.Location = new System.Drawing.Point(1028, 571);
            this.btnTigerOrderTrans.Name = "btnTigerOrderTrans";
            this.btnTigerOrderTrans.Size = new System.Drawing.Size(159, 33);
            this.btnTigerOrderTrans.TabIndex = 2;
            this.btnTigerOrderTrans.Text = "Sipariş Aktar";
            this.btnTigerOrderTrans.UseVisualStyleBackColor = true;
            this.btnTigerOrderTrans.Click += new System.EventHandler(this.btnTigerOrderTrans_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTalepNo);
            this.panel1.Controls.Add(this.txtTedarikci);
            this.panel1.Controls.Add(this.txtTedarikciVergiNo);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnUnSelectAll);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 51);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(889, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vergi No Ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(889, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Talep No Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sip No Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tedarikçi Ara";
            // 
            // txtTalepNo
            // 
            this.txtTalepNo.Location = new System.Drawing.Point(965, 3);
            this.txtTalepNo.Name = "txtTalepNo";
            this.txtTalepNo.Size = new System.Drawing.Size(206, 20);
            this.txtTalepNo.TabIndex = 6;
            this.txtTalepNo.TextChanged += new System.EventHandler(this.txtTalepNo_TextChanged);
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Location = new System.Drawing.Point(567, 3);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(206, 20);
            this.txtTedarikci.TabIndex = 5;
            this.txtTedarikci.TextChanged += new System.EventHandler(this.txtTedarikci_TextChanged);
            // 
            // txtTedarikciVergiNo
            // 
            this.txtTedarikciVergiNo.Location = new System.Drawing.Point(965, 26);
            this.txtTedarikciVergiNo.Name = "txtTedarikciVergiNo";
            this.txtTedarikciVergiNo.Size = new System.Drawing.Size(206, 20);
            this.txtTedarikciVergiNo.TabIndex = 4;
            this.txtTedarikciVergiNo.TextChanged += new System.EventHandler(this.txtTedarikciVergiNo_TextChanged);
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(567, 29);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(206, 20);
            this.txtOrderNumber.TabIndex = 3;
            this.txtOrderNumber.TextChanged += new System.EventHandler(this.txtOrderNumber_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(381, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Listeyi Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUnSelectAll
            // 
            this.btnUnSelectAll.Location = new System.Drawing.Point(95, 24);
            this.btnUnSelectAll.Name = "btnUnSelectAll";
            this.btnUnSelectAll.Size = new System.Drawing.Size(85, 23);
            this.btnUnSelectAll.TabIndex = 1;
            this.btnUnSelectAll.Text = "Seçimi Kaldır";
            this.btnUnSelectAll.UseVisualStyleBackColor = true;
            this.btnUnSelectAll.Click += new System.EventHandler(this.btnUnSelectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(4, 24);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(85, 23);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Tümünü Seç";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTigerOrderTrans);
            this.Controls.Add(this.dgvDetailOrderList);
            this.Controls.Add(this.dgvMasterOrderList);
            this.Name = "frmOrderList";
            this.Text = "Sipariş Listesi";
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMasterOrderList;
        private System.Windows.Forms.DataGridView dgvDetailOrderList;
        private System.Windows.Forms.Button btnTigerOrderTrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnSelectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTalepNo;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.TextBox txtTedarikciVergiNo;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProposalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierErpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierTaxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandCreatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcurementName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedItemProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductErpId;
        private System.Windows.Forms.DataGridViewButtonColumn btnProductErpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProposalNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryErpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductProposalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}