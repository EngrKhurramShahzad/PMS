namespace ISE_Project
{
    partial class Vendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendor));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Vendor_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.itemTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet = new ISE_Project.PMSDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.VendorId = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Vendor_Cnic = new System.Windows.Forms.MaskedTextBox();
            this.Vendor_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Vendor_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.customerOrderDataSet = new ISE_Project.CustomerOrderDataSet();
            this.itemTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_TableTableAdapter = new ISE_Project.CustomerOrderDataSetTableAdapters.Item_TableTableAdapter();
            this.item_TableTableAdapter1 = new ISE_Project.PMSDataSetTableAdapters.Item_TableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Serach = new System.Windows.Forms.TextBox();
            this.gv_Product = new System.Windows.Forms.DataGridView();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.gv_orderItems = new System.Windows.Forms.DataGridView();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_QtySum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Qty_2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customer_Contact = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_orderItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "NAME";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "CONTACT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "ADDRESS";
            // 
            // Vendor_Address
            // 
            this.Vendor_Address.BorderColorFocused = System.Drawing.Color.Blue;
            this.Vendor_Address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Vendor_Address.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Vendor_Address.BorderThickness = 1;
            this.Vendor_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Vendor_Address.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendor_Address.ForeColor = System.Drawing.Color.Black;
            this.Vendor_Address.isPassword = false;
            this.Vendor_Address.Location = new System.Drawing.Point(178, 127);
            this.Vendor_Address.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Vendor_Address.Name = "Vendor_Address";
            this.Vendor_Address.Size = new System.Drawing.Size(258, 31);
            this.Vendor_Address.TabIndex = 39;
            this.Vendor_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "EMAIL";
            // 
            // itemTableBindingSource3
            // 
            this.itemTableBindingSource3.DataMember = "Item_Table";
            this.itemTableBindingSource3.DataSource = this.pMSDataSet;
            // 
            // pMSDataSet
            // 
            this.pMSDataSet.DataSetName = "PMSDataSet";
            this.pMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VendorId
            // 
            this.VendorId.AllowDrop = true;
            this.VendorId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VendorId.DropDownHeight = 606;
            this.VendorId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorId.FormattingEnabled = true;
            this.VendorId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VendorId.IntegralHeight = false;
            this.VendorId.Location = new System.Drawing.Point(177, 10);
            this.VendorId.MaxDropDownItems = 40;
            this.VendorId.Name = "VendorId";
            this.VendorId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VendorId.Size = new System.Drawing.Size(143, 28);
            this.VendorId.TabIndex = 46;
            this.VendorId.SelectedIndexChanged += new System.EventHandler(this.SalesmanId_Combobox_SelectedIndexChanged);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "CONFIRM ORDER";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(541, 10);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(100, 50);
            this.bunifuThinButton24.TabIndex = 47;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Customer_Contact);
            this.panel3.Controls.Add(this.Vendor_Cnic);
            this.panel3.Controls.Add(this.Vendor_Name);
            this.panel3.Controls.Add(this.Vendor_Email);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.VendorId);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Vendor_Address);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(9, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 168);
            this.panel3.TabIndex = 49;
            // 
            // Vendor_Cnic
            // 
            this.Vendor_Cnic.BackColor = System.Drawing.Color.White;
            this.Vendor_Cnic.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendor_Cnic.Location = new System.Drawing.Point(494, 9);
            this.Vendor_Cnic.Mask = "00000-0000000-0";
            this.Vendor_Cnic.Name = "Vendor_Cnic";
            this.Vendor_Cnic.Size = new System.Drawing.Size(156, 26);
            this.Vendor_Cnic.TabIndex = 50;
            // 
            // Vendor_Name
            // 
            this.Vendor_Name.BorderColorFocused = System.Drawing.Color.Blue;
            this.Vendor_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Vendor_Name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Vendor_Name.BorderThickness = 1;
            this.Vendor_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Vendor_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendor_Name.ForeColor = System.Drawing.Color.Black;
            this.Vendor_Name.isPassword = false;
            this.Vendor_Name.Location = new System.Drawing.Point(177, 49);
            this.Vendor_Name.Margin = new System.Windows.Forms.Padding(5);
            this.Vendor_Name.Name = "Vendor_Name";
            this.Vendor_Name.Size = new System.Drawing.Size(143, 31);
            this.Vendor_Name.TabIndex = 48;
            this.Vendor_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Vendor_Email
            // 
            this.Vendor_Email.BorderColorFocused = System.Drawing.Color.Blue;
            this.Vendor_Email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Vendor_Email.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Vendor_Email.BorderThickness = 1;
            this.Vendor_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Vendor_Email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendor_Email.ForeColor = System.Drawing.Color.Black;
            this.Vendor_Email.isPassword = false;
            this.Vendor_Email.Location = new System.Drawing.Point(177, 90);
            this.Vendor_Email.Margin = new System.Windows.Forms.Padding(5);
            this.Vendor_Email.Name = "Vendor_Email";
            this.Vendor_Email.Size = new System.Drawing.Size(490, 31);
            this.Vendor_Email.TabIndex = 47;
            this.Vendor_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 664);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 55;
            this.label10.Text = "Vendor Payment:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // customerOrderDataSet
            // 
            this.customerOrderDataSet.DataSetName = "CustomerOrderDataSet";
            this.customerOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableBindingSource
            // 
            this.itemTableBindingSource.DataMember = "Item_Table";
            this.itemTableBindingSource.DataSource = this.customerOrderDataSet;
            // 
            // item_TableTableAdapter
            // 
            this.item_TableTableAdapter.ClearBeforeFill = true;
            // 
            // item_TableTableAdapter1
            // 
            this.item_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(255, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Serach
            // 
            this.txt_Serach.Location = new System.Drawing.Point(20, 313);
            this.txt_Serach.Multiline = true;
            this.txt_Serach.Name = "txt_Serach";
            this.txt_Serach.Size = new System.Drawing.Size(209, 20);
            this.txt_Serach.TabIndex = 62;
            this.txt_Serach.TextChanged += new System.EventHandler(this.txt_Serach_TextChanged);
            // 
            // gv_Product
            // 
            this.gv_Product.AllowUserToAddRows = false;
            this.gv_Product.AllowUserToDeleteRows = false;
            this.gv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Product.Location = new System.Drawing.Point(17, 339);
            this.gv_Product.Name = "gv_Product";
            this.gv_Product.ReadOnly = true;
            this.gv_Product.Size = new System.Drawing.Size(654, 125);
            this.gv_Product.TabIndex = 63;
            this.gv_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Product_CellContentClick);
            this.gv_Product.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Product_CellEnter);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(30, 467);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 19);
            this.lbl_Name.TabIndex = 59;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(228, 467);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(48, 19);
            this.lbl_Price.TabIndex = 64;
            this.lbl_Price.Text = "Price";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(100, 518);
            this.txt_qty.Multiline = true;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(74, 20);
            this.txt_qty.TabIndex = 65;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(201, 518);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 66;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(30, 518);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(45, 19);
            this.lbl_qty.TabIndex = 67;
            this.lbl_qty.Text = "Qty :";
            // 
            // gv_orderItems
            // 
            this.gv_orderItems.AllowUserToAddRows = false;
            this.gv_orderItems.AllowUserToDeleteRows = false;
            this.gv_orderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_orderItems.Location = new System.Drawing.Point(23, 549);
            this.gv_orderItems.Name = "gv_orderItems";
            this.gv_orderItems.ReadOnly = true;
            this.gv_orderItems.Size = new System.Drawing.Size(641, 97);
            this.gv_orderItems.TabIndex = 68;
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalAmount.Location = new System.Drawing.Point(155, 664);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(0, 19);
            this.lbl_totalAmount.TabIndex = 59;
            // 
            // lbl_QtySum
            // 
            this.lbl_QtySum.AutoSize = true;
            this.lbl_QtySum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtySum.Location = new System.Drawing.Point(481, 664);
            this.lbl_QtySum.Name = "lbl_QtySum";
            this.lbl_QtySum.Size = new System.Drawing.Size(0, 19);
            this.lbl_QtySum.TabIndex = 59;
            this.lbl_QtySum.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 668);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 69;
            this.label9.Text = "Total Quantity :";
            // 
            // Qty_2
            // 
            this.Qty_2.AutoSize = true;
            this.Qty_2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_2.Location = new System.Drawing.Point(517, 664);
            this.Qty_2.Name = "Qty_2";
            this.Qty_2.Size = new System.Drawing.Size(0, 23);
            this.Qty_2.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Location = new System.Drawing.Point(9, 695);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 62);
            this.panel1.TabIndex = 71;
            // 
            // Customer_Contact
            // 
            this.Customer_Contact.BackColor = System.Drawing.Color.White;
            this.Customer_Contact.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Contact.Location = new System.Drawing.Point(494, 44);
            this.Customer_Contact.Mask = "0000-0000000";
            this.Customer_Contact.Name = "Customer_Contact";
            this.Customer_Contact.Size = new System.Drawing.Size(156, 26);
            this.Customer_Contact.TabIndex = 51;
            this.Customer_Contact.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Vendor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(819, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Qty_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_QtySum);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.gv_orderItems);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.gv_Product);
            this.Controls.Add(this.txt_Serach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Name = "Vendor";
            this.Text = "Vendor Order";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_orderItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox Vendor_Address;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.ComboBox VendorId;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox Vendor_Name;
        private Bunifu.Framework.UI.BunifuMetroTextbox Vendor_Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox Vendor_Cnic;
        private CustomerOrderDataSet customerOrderDataSet;
        private System.Windows.Forms.BindingSource itemTableBindingSource;
        private CustomerOrderDataSetTableAdapters.Item_TableTableAdapter item_TableTableAdapter;
      //  private PMSDataSet pMSDataSet;
        private System.Windows.Forms.BindingSource itemTableBindingSource1;
      //  private PMSDataSetTableAdapters.Item_TableTableAdapter item_TableTableAdapter1;
       // private PMSDataSet1 pMSDataSet1;
        private System.Windows.Forms.BindingSource itemTableBindingSource2;
        // private PMSDataSet1TableAdapters.Item_TableTableAdapter item_TableTableAdapter2;
        private PMSDataSet pMSDataSet;
        private System.Windows.Forms.BindingSource itemTableBindingSource3;
        private PMSDataSetTableAdapters.Item_TableTableAdapter item_TableTableAdapter1;
        private System.Windows.Forms.TextBox txt_Serach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gv_Product;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.DataGridView gv_orderItems;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_QtySum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Qty_2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox Customer_Contact;
    }
}

