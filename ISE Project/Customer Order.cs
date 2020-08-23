using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE_Project
{
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        DBClass db = new DBClass();
        Dashboard objdb;
        public Customer()
        {
            InitializeComponent();
        }

        public Customer(Dashboard db)
        {
            InitializeComponent();
            this.objdb = db;
        }




        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet.Item_Table' table. You can move, or remove it, as needed.
           // this.item_TableTableAdapter1.Fill(this.pMSDataSet.Item_Table);
            
           // this.item_TableTableAdapter.Fill(this.customerOrderDataSet.Item_Table);
            DataTable dt = db.RequiredItem_disp("Select SalesmenId from Salesmen_Table");
            foreach (DataRow item in dt.Rows)
            {
                SalesmanId.Items.Add(item[0].ToString());
            }
            itemFill();
        }

        public void itemFill()
        {

            try
            {
                for (int i = 0; i < ClientOrder_Gview.Rows.Count; i++)
                {
                    if (ClientOrder_Gview.Rows[i].Cells["Item_Name"].Value != null)
                    {
                        continue;
                    }
                    DataGridViewComboBoxCell c = (DataGridViewComboBoxCell)ClientOrder_Gview.Rows[i].Cells["Item_Name"];
                    db.datagridcombox(c, "Select Name From Item_Table");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void SalesmanId_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(SalesmanId.Text);
            DataTable dt = db.RequiredItem_disp("Select * from Salesmen_Table where SalesmenId='" + Id + "'");
            DataRow dr = dt.Rows[0];
            Customer_Name.Text = dr[1].ToString();
            Customer_Cnic.Text = dr[2].ToString();
            Customer_Contact.Text=dr[3].ToString();
            Customer_Email.Text = dr[4].ToString();
            Customer_Address.Text=dr[5].ToString();
           
           
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        #region  yasir working 
        SqlConnection conc;
        public string dataString = @"Data Source=DESKTOP-V5OREHE;Initial Catalog=PMS;Integrated Security=True";

        DataTable TemTABLE = new DataTable();
       
        public void GetTable()
        {

            TemTABLE.Columns.Add("Id", typeof(int));
            TemTABLE.Columns.Add("Name", typeof(string));
            TemTABLE.Columns.Add("Price", typeof(int));
            TemTABLE.Columns.Add("Qty", typeof(int));

            // Here we add five DataRows.
            //dt.Rows.Add(1, "Vinay", "India", DateTime.Now);
            //dt.Rows.Add(2, "Imran", "Pakistan", DateTime.Now);
            //dt.Rows.Add(3, "Pawan", "U.S.", DateTime.Now);
            //dt.Rows.Add(4, "Manash", "Nepal", DateTime.Now);
            //dt.Rows.Add(5, "Ranu", "Sri Lanka", DateTime.Now);
            //return TemTABLE;
        }
        #endregion

        private void label11_Click(object sender, EventArgs e)
        {
            

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int total = 0; int discount = 0; int discountAmount = 0; int TotalAmount = 0; int a = 100;
            if (Amount2_Box.Text != "")
            {
                total = Convert.ToInt32(Amount2_Box.Text);
                discount = Convert.ToInt32(Discount_text.Text);
                discountAmount = (total * discount)/a;
                TotalAmount = total - discountAmount;
                Dis_text.Text = TotalAmount.ToString();
            }
            else
            {
                Dis_text.Text = "0";
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientOrder_Gview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (ClientOrder_Gview.CurrentRow.Cells["Quantity"].Value != null)
            {
                string itemName = ClientOrder_Gview.CurrentRow.Cells[0].EditedFormattedValue.ToString();
                string type = ClientOrder_Gview.CurrentRow.Cells[1].EditedFormattedValue.ToString();
                string value = ClientOrder_Gview.CurrentRow.Cells["Quantity"].Value.ToString();
                string status = "";
                status = db.quantityCheckAll("Select Quantity From Item_Table WHERE Name = '" + itemName + "' AND Type ='"+type+"'", Convert.ToInt32(value), itemName, ClientOrder_Gview);
                if (status == "Unavailable")
                {
                    ClientOrder_Gview.CurrentRow.Cells[2].Value = "Unavailable";
                    MessageBox.Show("Item Not Available in required Quantity", "Item Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ClientOrder_Gview.CurrentRow.Cells[3].Value = "Available";
                    string query = "Select Price From Item_Table WHERE Name = '" + itemName + "'";
                    ClientOrder_Gview.CurrentRow.Cells[4].Value = db.FetchPrice(query, itemName, ClientOrder_Gview);
                }
                if (ClientOrder_Gview.CurrentRow.Cells[4].Value != null)
                {
                    string val1 = ClientOrder_Gview.CurrentRow.Cells[2].Value.ToString();
                    string val2 = ClientOrder_Gview.CurrentRow.Cells[4].Value.ToString();
                    ClientOrder_Gview.CurrentRow.Cells[5].Value = db.amountCalculator(val1, val2);
                }
            }
            itemFill();
        }
        
        public int a = 0;
        public int totalAmount = 0;
        public int totalQuantity = 0;
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            string Name = "";
            string Qty = "";
            string Price = "";
            string Amount = "";
            string Type = "";
            string Statusvar = "";
            for (int i = 0; i < ClientOrder_Gview.Rows.Count - 1; i++)
            {
                Name = ClientOrder_Gview.Rows[i].Cells[0].Value.ToString();
                Qty = ClientOrder_Gview.Rows[i].Cells[2].Value.ToString();
                Statusvar = ClientOrder_Gview.Rows[i].Cells[3].Value.ToString();
                Type = ClientOrder_Gview.Rows[i].Cells[1].Value.ToString();
                if (Statusvar == "Available")
                {
                    Price = ClientOrder_Gview.Rows[i].Cells[4].Value.ToString();
                    Amount = ClientOrder_Gview.Rows[i].Cells[5].Value.ToString();
                    Item_Grid.Rows.Add();
                    Item_Grid.Rows[a].Cells[0].Value = Name;
                    Item_Grid.Rows[a].Cells[1].Value = Qty;
                    Item_Grid.Rows[a].Cells[2].Value = Price;
                    Item_Grid.Rows[a].Cells[3].Value = Amount;
                    Item_Grid.Rows[a].Cells[4].Value = Type;
                    a++;
                }
                else
                {
                    MetroMessageBox.Show(this, "Required Qty for " + Name + " is Not Available kindly Reduce the amount");
                }
            }
            ClientOrder_Gview.Rows.Clear();
            itemFill();

            for (int i = 0; i < a; i++)
            {
                totalAmount += Convert.ToInt32(Item_Grid.Rows[i].Cells[3].Value);
                totalQuantity += Convert.ToInt32(Item_Grid.Rows[i].Cells[1].Value);
            }
            Amount2_Box.Text = totalAmount.ToString();
            Quantity_Box.Text = totalQuantity.ToString();
            totalAmount = 0;
            totalQuantity = 0;
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Item_Grid.Rows.Count; i++)
            {
                var AAA = Item_Grid.Rows[0].Cells["NameOFItem"] .Value.ToString();
            }
            try
            {
                for (int i = 0; i < Item_Grid.Rows.Count; i++)
                {
                    db.Salesmen_update_data("Update Item_Table Set Quantity-='" + Convert.ToInt32(Item_Grid.Rows[i].Cells[1].Value.ToString()) + "' where Name='" + Item_Grid.Rows[i].Cells[0].Value.ToString() + "' AND Type='" + Item_Grid.Rows[i].Cells[4].Value.ToString() + "'");
                }
                if (MetroMessageBox.Show(this, "Successfuly Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Item_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Item_Grid.CurrentRow.Cells[5].Selected == true)
            {
                if (MetroMessageBox.Show(this, "Are You sure you Want to Delete Current Row...???", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = Item_Grid.CurrentCell.RowIndex;
                    Item_Grid.Rows.RemoveAt(index);
                    a = a - 1;
                    for (int i = 0; i < a; i++)
                    {
                        totalAmount += Convert.ToInt32(Item_Grid.Rows[i].Cells[3].Value);
                        totalQuantity += Convert.ToInt32(Item_Grid.Rows[i].Cells[1].Value);
                    }
                    Amount2_Box.Text = totalAmount.ToString();
                    Quantity_Box.Text = totalQuantity.ToString();
                    totalAmount = 0;
                    totalQuantity = 0;
                }
            }
        }

        private void Customer_Leave(object sender, EventArgs e)
        {
            objdb.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void typeFill(string q)
        {

            try
            {
                for (int i = 0; i < ClientOrder_Gview.Rows.Count; i++)
                {
                    if (ClientOrder_Gview.Rows[i].Cells["Type"].Value != null)
                    {
                        continue;
                    }
                    DataGridViewComboBoxCell c = (DataGridViewComboBoxCell)ClientOrder_Gview.Rows[i].Cells["Type"];
                    db.datagridcombox(c, q);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClientOrder_Gview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClientOrder_Gview.CurrentRow.Cells[0].Value != null)
            {
                string itemName = ClientOrder_Gview.CurrentRow.Cells[0].EditedFormattedValue.ToString();
                typeFill("Select Type from Item_Table where Name='" + itemName + "'");
            }
        }

        private void ClientOrder_Gview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       

       
    }
}
