namespace ISE_Project
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Customer_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            //this.itemTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
           // this.pMSDataSet = new ISE_Project.PMSDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SalesmanId = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Customer_Contact = new System.Windows.Forms.MaskedTextBox();
            this.Customer_Cnic = new System.Windows.Forms.MaskedTextBox();
            this.Customer_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Customer_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Dis_text = new System.Windows.Forms.TextBox();
            this.Discount_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            //this.customerOrderDataSet = new ISE_Project.CustomerOrderDataSet();
            this.itemTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.item_TableTableAdapter = new ISE_Project.CustomerOrderDataSetTableAdapters.Item_TableTableAdapter();
            //this.item_TableTableAdapter1 = new ISE_Project.PMSDataSetTableAdapters.Item_TableTableAdapter();
            this.lbl_QtySum = new System.Windows.Forms.Label();
            this.Qty_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton24 = new System.Windows.Forms.Button();
            this.ClientOrder_Gview = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Grid = new System.Windows.Forms.DataGridView();
            this.NameOFItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoryyyy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.Quantity_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount2_Box = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            //((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource3)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientOrder_Gview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Grid)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salesman ID";
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
            this.label4.Location = new System.Drawing.Point(446, 46);
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
            // Customer_Address
            // 
            this.Customer_Address.BorderColorFocused = System.Drawing.Color.Blue;
            this.Customer_Address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Customer_Address.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Customer_Address.BorderThickness = 1;
            this.Customer_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Customer_Address.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Address.ForeColor = System.Drawing.Color.Black;
            this.Customer_Address.isPassword = false;
            this.Customer_Address.Location = new System.Drawing.Point(178, 127);
            this.Customer_Address.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.Size = new System.Drawing.Size(258, 31);
            this.Customer_Address.TabIndex = 39;
            this.Customer_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            //this.itemTableBindingSource3.DataMember = "Item_Table";
            //this.itemTableBindingSource3.DataSource = this.pMSDataSet;
            // 
            // pMSDataSet
            // 
            //this.pMSDataSet.DataSetName = "PMSDataSet";
           // this.pMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesmanId
            // 
            this.SalesmanId.AllowDrop = true;
            this.SalesmanId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SalesmanId.DropDownHeight = 606;
            this.SalesmanId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesmanId.FormattingEnabled = true;
            this.SalesmanId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SalesmanId.IntegralHeight = false;
            this.SalesmanId.Location = new System.Drawing.Point(177, 10);
            this.SalesmanId.MaxDropDownItems = 40;
            this.SalesmanId.Name = "SalesmanId";
            this.SalesmanId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalesmanId.Size = new System.Drawing.Size(143, 28);
            this.SalesmanId.TabIndex = 46;
            this.SalesmanId.SelectedIndexChanged += new System.EventHandler(this.SalesmanId_Combobox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Customer_Contact);
            this.panel3.Controls.Add(this.Customer_Cnic);
            this.panel3.Controls.Add(this.Customer_Name);
            this.panel3.Controls.Add(this.Customer_Email);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SalesmanId);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Customer_Address);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(9, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 168);
            this.panel3.TabIndex = 49;
            // 
            // Customer_Contact
            // 
            this.Customer_Contact.BackColor = System.Drawing.Color.White;
            this.Customer_Contact.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Contact.Location = new System.Drawing.Point(494, 47);
            this.Customer_Contact.Mask = "0000-0000000";
            this.Customer_Contact.Name = "Customer_Contact";
            this.Customer_Contact.Size = new System.Drawing.Size(160, 26);
            this.Customer_Contact.TabIndex = 51;
            this.Customer_Contact.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Customer_Cnic
            // 
            this.Customer_Cnic.BackColor = System.Drawing.Color.White;
            this.Customer_Cnic.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Cnic.Location = new System.Drawing.Point(494, 9);
            this.Customer_Cnic.Mask = "00000-0000000-0";
            this.Customer_Cnic.Name = "Customer_Cnic";
            this.Customer_Cnic.Size = new System.Drawing.Size(160, 26);
            this.Customer_Cnic.TabIndex = 50;
            // 
            // Customer_Name
            // 
            this.Customer_Name.BorderColorFocused = System.Drawing.Color.Blue;
            this.Customer_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Customer_Name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Customer_Name.BorderThickness = 1;
            this.Customer_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Customer_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name.ForeColor = System.Drawing.Color.Black;
            this.Customer_Name.isPassword = false;
            this.Customer_Name.Location = new System.Drawing.Point(177, 49);
            this.Customer_Name.Margin = new System.Windows.Forms.Padding(5);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(143, 31);
            this.Customer_Name.TabIndex = 48;
            this.Customer_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Customer_Email
            // 
            this.Customer_Email.BorderColorFocused = System.Drawing.Color.Blue;
            this.Customer_Email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Customer_Email.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Customer_Email.BorderThickness = 1;
            this.Customer_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Customer_Email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Email.ForeColor = System.Drawing.Color.Black;
            this.Customer_Email.isPassword = false;
            this.Customer_Email.Location = new System.Drawing.Point(177, 90);
            this.Customer_Email.Margin = new System.Windows.Forms.Padding(5);
            this.Customer_Email.Name = "Customer_Email";
            this.Customer_Email.Size = new System.Drawing.Size(490, 31);
            this.Customer_Email.TabIndex = 47;
            this.Customer_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // Dis_text
            // 
            this.Dis_text.Location = new System.Drawing.Point(382, 26);
            this.Dis_text.Name = "Dis_text";
            this.Dis_text.Size = new System.Drawing.Size(84, 20);
            this.Dis_text.TabIndex = 71;
            // 
            // Discount_text
            // 
            this.Discount_text.Location = new System.Drawing.Point(102, 27);
            this.Discount_text.Name = "Discount_text";
            this.Discount_text.Size = new System.Drawing.Size(76, 20);
            this.Discount_text.TabIndex = 70;
            this.Discount_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 56;
            this.label11.Text = "Discount";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(208, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 19);
            this.label12.TabIndex = 57;
            this.label12.Text = "Discount Amount";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // customerOrderDataSet
            // 
           // this.customerOrderDataSet.DataSetName = "CustomerOrderDataSet";
           // this.customerOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableBindingSource
            // 
            this.itemTableBindingSource.DataMember = "Item_Table";
            //this.itemTableBindingSource.DataSource = this.customerOrderDataSet;
            // 
            // item_TableTableAdapter
            // 
            //this.item_TableTableAdapter.ClearBeforeFill = true;
            // 
            // item_TableTableAdapter1
            // 
          //  this.item_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_QtySum
            // 
            this.lbl_QtySum.AutoSize = true;
            this.lbl_QtySum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtySum.Location = new System.Drawing.Point(485, 625);
            this.lbl_QtySum.Name = "lbl_QtySum";
            this.lbl_QtySum.Size = new System.Drawing.Size(0, 19);
            this.lbl_QtySum.TabIndex = 59;
            this.lbl_QtySum.Click += new System.EventHandler(this.label9_Click);
            // 
            // Qty_1
            // 
            this.Qty_1.AutoSize = true;
            this.Qty_1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_1.Location = new System.Drawing.Point(521, 621);
            this.Qty_1.Name = "Qty_1";
            this.Qty_1.Size = new System.Drawing.Size(0, 23);
            this.Qty_1.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Discount_text);
            this.panel1.Controls.Add(this.Dis_text);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(16, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 65);
            this.panel1.TabIndex = 72;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bunifuThinButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.Image = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.Image")));
            this.bunifuThinButton24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuThinButton24.Location = new System.Drawing.Point(527, 17);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(133, 35);
            this.bunifuThinButton24.TabIndex = 72;
            this.bunifuThinButton24.Text = "Confirm Order";
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuThinButton24.UseVisualStyleBackColor = true;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click_1);
            // 
            // ClientOrder_Gview
            // 
            this.ClientOrder_Gview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientOrder_Gview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientOrder_Gview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Type,
            this.Quantity,
            this.Status,
            this.Price,
            this.Amount});
            this.ClientOrder_Gview.Location = new System.Drawing.Point(9, 272);
            this.ClientOrder_Gview.Name = "ClientOrder_Gview";
            this.ClientOrder_Gview.Size = new System.Drawing.Size(674, 113);
            this.ClientOrder_Gview.TabIndex = 73;
            this.ClientOrder_Gview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientOrder_Gview_CellClick);
            this.ClientOrder_Gview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientOrder_Gview_CellContentClick);
            this.ClientOrder_Gview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientOrder_Gview_CellEndEdit);
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 8;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Item_Name.Sorted = true;
            this.Item_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Item_Name.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Item_Grid
            // 
            this.Item_Grid.AllowUserToAddRows = false;
            this.Item_Grid.AllowUserToDeleteRows = false;
            this.Item_Grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Item_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Item_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOFItem,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Categoryyyy,
            this.Delete});
            this.Item_Grid.Location = new System.Drawing.Point(37, 433);
            this.Item_Grid.Name = "Item_Grid";
            this.Item_Grid.ReadOnly = true;
            this.Item_Grid.Size = new System.Drawing.Size(623, 117);
            this.Item_Grid.TabIndex = 78;
            this.Item_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Item_Grid_CellClick);
            // 
            // NameOFItem
            // 
            this.NameOFItem.HeaderText = "Item Name";
            this.NameOFItem.MinimumWidth = 8;
            this.NameOFItem.Name = "NameOFItem";
            this.NameOFItem.ReadOnly = true;
            this.NameOFItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameOFItem.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Categoryyyy
            // 
            this.Categoryyyy.HeaderText = "Type";
            this.Categoryyyy.Name = "Categoryyyy";
            this.Categoryyyy.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(110, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 18);
            this.label10.TabIndex = 77;
            this.label10.Text = "Total Amount:";
            // 
            // Quantity_Box
            // 
            this.Quantity_Box.Location = new System.Drawing.Point(489, 553);
            this.Quantity_Box.Name = "Quantity_Box";
            this.Quantity_Box.Size = new System.Drawing.Size(121, 20);
            this.Quantity_Box.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Total Quantity:";
            // 
            // Amount2_Box
            // 
            this.Amount2_Box.Location = new System.Drawing.Point(226, 553);
            this.Amount2_Box.Name = "Amount2_Box";
            this.Amount2_Box.Size = new System.Drawing.Size(121, 20);
            this.Amount2_Box.TabIndex = 76;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(610, 391);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 35);
            this.btn_add.TabIndex = 79;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // Customer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(711, 670);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Item_Grid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Quantity_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amount2_Box);
            this.Controls.Add(this.ClientOrder_Gview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Qty_1);
            this.Controls.Add(this.lbl_QtySum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Name = "Customer";
            this.Text = "Customer Order";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.Leave += new System.EventHandler(this.Customer_Leave);
           // ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource3)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientOrder_Gview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Grid)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMetroTextbox Customer_Address;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox SalesmanId;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox Customer_Name;
        private Bunifu.Framework.UI.BunifuMetroTextbox Customer_Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox Customer_Cnic;
       // private CustomerOrderDataSet customerOrderDataSet;
        private System.Windows.Forms.BindingSource itemTableBindingSource;
       // private CustomerOrderDataSetTableAdapters.Item_TableTableAdapter item_TableTableAdapter;
      //  private PMSDataSet pMSDataSet;
        private System.Windows.Forms.BindingSource itemTableBindingSource1;
      //  private PMSDataSetTableAdapters.Item_TableTableAdapter item_TableTableAdapter1;
       // private PMSDataSet1 pMSDataSet1;
        private System.Windows.Forms.BindingSource itemTableBindingSource2;
        // private PMSDataSet1TableAdapters.Item_TableTableAdapter item_TableTableAdapter2;
       // private PMSDataSet pMSDataSet;
       // private System.Windows.Forms.BindingSource itemTableBindingSource3;
       // private PMSDataSetTableAdapters.Item_TableTableAdapter item_TableTableAdapter1;
        private System.Windows.Forms.Label lbl_QtySum;
        private System.Windows.Forms.TextBox Dis_text;
        private System.Windows.Forms.TextBox Discount_text;
        private System.Windows.Forms.Label Qty_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ClientOrder_Gview;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView Item_Grid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Quantity_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount2_Box;
        private System.Windows.Forms.Button bunifuThinButton24;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOFItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoryyyy;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.MaskedTextBox Customer_Contact;
        private System.Windows.Forms.DataGridViewComboBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

