namespace ISE_Project
{
    partial class New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Customer_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SalesmanId = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Customer_Contact = new System.Windows.Forms.MaskedTextBox();
            this.Customer_Cnic = new System.Windows.Forms.MaskedTextBox();
            this.Customer_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Customer_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Item_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Item_type = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Item_Quantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Item_Id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.New_Type = new System.Windows.Forms.Label();
            this.New_Quantity = new System.Windows.Forms.Label();
            this.New_Name = new System.Windows.Forms.Label();
            this.New_id = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.New_Packing = new System.Windows.Forms.Label();
            this.New_Brand = new System.Windows.Forms.Label();
            this.New_Price = new System.Windows.Forms.Label();
            this.Item_Price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Item_Packing = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Item_Brand = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(9, 115);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Item_Brand);
            this.panel4.Controls.Add(this.Item_Packing);
            this.panel4.Controls.Add(this.Item_Price);
            this.panel4.Controls.Add(this.New_Price);
            this.panel4.Controls.Add(this.New_Brand);
            this.panel4.Controls.Add(this.New_Packing);
            this.panel4.Controls.Add(this.Item_Name);
            this.panel4.Controls.Add(this.Item_type);
            this.panel4.Controls.Add(this.Item_Quantity);
            this.panel4.Controls.Add(this.Item_Id);
            this.panel4.Controls.Add(this.New_Type);
            this.panel4.Controls.Add(this.New_Quantity);
            this.panel4.Controls.Add(this.New_Name);
            this.panel4.Controls.Add(this.New_id);
            this.panel4.Location = new System.Drawing.Point(13, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 184);
            this.panel4.TabIndex = 51;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Item_Name
            // 
            this.Item_Name.BorderColorFocused = System.Drawing.Color.Blue;
            this.Item_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Item_Name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Item_Name.BorderThickness = 1;
            this.Item_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.ForeColor = System.Drawing.Color.Black;
            this.Item_Name.isPassword = false;
            this.Item_Name.Location = new System.Drawing.Point(433, 21);
            this.Item_Name.Margin = new System.Windows.Forms.Padding(5);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(143, 28);
            this.Item_Name.TabIndex = 56;
            this.Item_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Item_type
            // 
            this.Item_type.BorderColorFocused = System.Drawing.Color.Blue;
            this.Item_type.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Item_type.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Item_type.BorderThickness = 1;
            this.Item_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_type.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_type.ForeColor = System.Drawing.Color.Black;
            this.Item_type.isPassword = false;
            this.Item_type.Location = new System.Drawing.Point(433, 59);
            this.Item_type.Margin = new System.Windows.Forms.Padding(5);
            this.Item_type.Name = "Item_type";
            this.Item_type.Size = new System.Drawing.Size(143, 28);
            this.Item_type.TabIndex = 55;
            this.Item_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Item_Quantity
            // 
            this.Item_Quantity.BorderColorFocused = System.Drawing.Color.Blue;
            this.Item_Quantity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Item_Quantity.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Item_Quantity.BorderThickness = 1;
            this.Item_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_Quantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Quantity.ForeColor = System.Drawing.Color.Black;
            this.Item_Quantity.isPassword = false;
            this.Item_Quantity.Location = new System.Drawing.Point(112, 59);
            this.Item_Quantity.Margin = new System.Windows.Forms.Padding(5);
            this.Item_Quantity.Name = "Item_Quantity";
            this.Item_Quantity.Size = new System.Drawing.Size(143, 28);
            this.Item_Quantity.TabIndex = 53;
            this.Item_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Item_Quantity.OnValueChanged += new System.EventHandler(this.Item_Quantity_OnValueChanged);
            // 
            // Item_Id
            // 
            this.Item_Id.BorderColorFocused = System.Drawing.Color.Blue;
            this.Item_Id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Item_Id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Item_Id.BorderThickness = 1;
            this.Item_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_Id.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Id.ForeColor = System.Drawing.Color.Black;
            this.Item_Id.isPassword = false;
            this.Item_Id.Location = new System.Drawing.Point(112, 21);
            this.Item_Id.Margin = new System.Windows.Forms.Padding(5);
            this.Item_Id.Name = "Item_Id";
            this.Item_Id.Size = new System.Drawing.Size(143, 28);
            this.Item_Id.TabIndex = 51;
            this.Item_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // New_Type
            // 
            this.New_Type.AutoSize = true;
            this.New_Type.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Type.Location = new System.Drawing.Point(326, 59);
            this.New_Type.Name = "New_Type";
            this.New_Type.Size = new System.Drawing.Size(51, 19);
            this.New_Type.TabIndex = 7;
            this.New_Type.Text = "TYPE";
            this.New_Type.Click += new System.EventHandler(this.label15_Click);
            // 
            // New_Quantity
            // 
            this.New_Quantity.AutoSize = true;
            this.New_Quantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Quantity.Location = new System.Drawing.Point(3, 59);
            this.New_Quantity.Name = "New_Quantity";
            this.New_Quantity.Size = new System.Drawing.Size(90, 19);
            this.New_Quantity.TabIndex = 6;
            this.New_Quantity.Text = "QUANTITY";
            // 
            // New_Name
            // 
            this.New_Name.AutoSize = true;
            this.New_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Name.Location = new System.Drawing.Point(326, 21);
            this.New_Name.Name = "New_Name";
            this.New_Name.Size = new System.Drawing.Size(56, 19);
            this.New_Name.TabIndex = 5;
            this.New_Name.Text = "NAME";
            // 
            // New_id
            // 
            this.New_id.AutoSize = true;
            this.New_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_id.Location = new System.Drawing.Point(10, 21);
            this.New_id.Name = "New_id";
            this.New_id.Size = new System.Drawing.Size(67, 19);
            this.New_id.TabIndex = 0;
            this.New_id.Text = "ITEM ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(583, 498);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(100, 50);
            this.bunifuThinButton24.TabIndex = 58;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // New_Packing
            // 
            this.New_Packing.AutoSize = true;
            this.New_Packing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Packing.Location = new System.Drawing.Point(2, 135);
            this.New_Packing.Name = "New_Packing";
            this.New_Packing.Size = new System.Drawing.Size(102, 19);
            this.New_Packing.TabIndex = 57;
            this.New_Packing.Text = "PACKING ID";
            // 
            // New_Brand
            // 
            this.New_Brand.AutoSize = true;
            this.New_Brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Brand.Location = new System.Drawing.Point(326, 100);
            this.New_Brand.Name = "New_Brand";
            this.New_Brand.Size = new System.Drawing.Size(88, 19);
            this.New_Brand.TabIndex = 58;
            this.New_Brand.Text = "BRAND ID";
            // 
            // New_Price
            // 
            this.New_Price.AutoSize = true;
            this.New_Price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Price.Location = new System.Drawing.Point(5, 100);
            this.New_Price.Name = "New_Price";
            this.New_Price.Size = new System.Drawing.Size(59, 19);
            this.New_Price.TabIndex = 59;
            this.New_Price.Text = "PRICE";
            // 
            // Item_Price
            // 
            this.Item_Price.BorderColorFocused = System.Drawing.Color.Blue;
            this.Item_Price.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Item_Price.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Item_Price.BorderThickness = 1;
            this.Item_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_Price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Price.ForeColor = System.Drawing.Color.Black;
            this.Item_Price.isPassword = false;
            this.Item_Price.Location = new System.Drawing.Point(112, 97);
            this.Item_Price.Margin = new System.Windows.Forms.Padding(5);
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.Size = new System.Drawing.Size(143, 28);
            this.Item_Price.TabIndex = 60;
            this.Item_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Item_Packing
            // 
            this.Item_Packing.BorderColorFocused = System.Drawing.Color.Blue;
            this.Item_Packing.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Item_Packing.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Item_Packing.BorderThickness = 1;
            this.Item_Packing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_Packing.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Packing.ForeColor = System.Drawing.Color.Black;
            this.Item_Packing.isPassword = false;
            this.Item_Packing.Location = new System.Drawing.Point(112, 135);
            this.Item_Packing.Margin = new System.Windows.Forms.Padding(5);
            this.Item_Packing.Name = "Item_Packing";
            this.Item_Packing.Size = new System.Drawing.Size(143, 28);
            this.Item_Packing.TabIndex = 61;
            this.Item_Packing.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Item_Brand
            // 
            this.Item_Brand.BorderColorFocused = System.Drawing.Color.Blue;
            this.Item_Brand.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Item_Brand.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Item_Brand.BorderThickness = 1;
            this.Item_Brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_Brand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Brand.ForeColor = System.Drawing.Color.Black;
            this.Item_Brand.isPassword = false;
            this.Item_Brand.Location = new System.Drawing.Point(433, 100);
            this.Item_Brand.Margin = new System.Windows.Forms.Padding(5);
            this.Item_Brand.Name = "Item_Brand";
            this.Item_Brand.Size = new System.Drawing.Size(143, 28);
            this.Item_Brand.TabIndex = 62;
            this.Item_Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // New
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(723, 548);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Name = "New";
            this.Text = "ADD MEDICINES";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox Customer_Cnic;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox Item_Name;
        private Bunifu.Framework.UI.BunifuMetroTextbox Item_type;
        private Bunifu.Framework.UI.BunifuMetroTextbox Item_Quantity;
        private Bunifu.Framework.UI.BunifuMetroTextbox Item_Id;
        private System.Windows.Forms.Label New_Type;
        private System.Windows.Forms.Label New_Quantity;
        private System.Windows.Forms.Label New_Name;
        private System.Windows.Forms.Label New_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.MaskedTextBox Customer_Contact;
        private System.Windows.Forms.Label New_Price;
        private System.Windows.Forms.Label New_Brand;
        private System.Windows.Forms.Label New_Packing;
        private Bunifu.Framework.UI.BunifuMetroTextbox Item_Brand;
        private Bunifu.Framework.UI.BunifuMetroTextbox Item_Packing;
        private Bunifu.Framework.UI.BunifuMetroTextbox Item_Price;
    }
}

