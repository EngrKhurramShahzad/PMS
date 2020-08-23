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
    public partial class Vendor: MetroFramework.Forms.MetroForm
    {
        DBClass db = new DBClass();
        public Vendor()
        {
            InitializeComponent();
            GetTable();
        }




        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Vendor
                ().Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet.Item_Table' table. You can move, or remove it, as needed.
           // this.item_TableTableAdapter1.Fill(this.pMSDataSet.Item_Table);
            
           // this.item_TableTableAdapter.Fill(this.customerOrderDataSet.Item_Table);
            DataTable dt = db.RequiredItem_disp("Select VendorId from Vendor_Table");
            foreach (DataRow item in dt.Rows)
            {
                VendorId.Items.Add(item[0].ToString());
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void SalesmanId_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(VendorId.Text);
            DataTable dt = db.RequiredItem_disp("Select * from Vendor_Table where VendorId='" + Id + "'");
            DataRow dr = dt.Rows[0];
            Vendor_Name.Text = dr[1].ToString();
            Vendor_Cnic.Text = dr[2].ToString();
            Customer_Contact.Text=dr[3].ToString();
            Vendor_Email.Text = dr[4].ToString();
            Vendor_Address.Text=dr[5].ToString();
           
           
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
        
        //DataTable TemTABLE = new DataTable();
        
        //public DataTable  SerachProduct()
        //{
        //    DataTable dt = new DataTable();
            
        //    try
        //    {
        //        using (db)
        //        {
        //            string query = "SELECT * FROM Item_Table WHERE Name Like  '%" + txt_Serach.Text + "%'";
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                SqlDataAdapter da = new SqlDataAdapter(cmd);
        //                da.Fill(dt);
        //                conc.Close();                       
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
                
        //      //  throw;
        //    }
        //    return dt;

        //}


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_Serach.Text!=""){

                DataTable dt = db.RequiredItem_disp("SELECT * FROM Item_Table WHERE Name Like  '%" + txt_Serach.Text + "%'");
                gv_Product.DataSource = dt;
                }
                    else if (txt_Serach.Text == "")
                {
                    MessageBox.Show("Please Insert Product");

                }
                // gv_ShowResult.DataBindings();
            
            }
            catch (Exception ex)
            {
                if (txt_Serach.Text == "")
                {
                    MessageBox.Show("Please Insert Product");

                }

            }
        }

        DataTable TemTABLE = new DataTable();
        private void btn_add_Click(object sender, EventArgs e)
        {
            //var dt= GetTable();

            TemTABLE.Rows.Add(gv_Product.CurrentRow.Cells[0].Value, lbl_Name.Text, (int.Parse(lbl_Price.Text) * int.Parse(txt_qty.Text)), txt_qty.Text);

            gv_orderItems.DataSource = TemTABLE;
            int sum = Convert.ToInt32(TemTABLE.Compute("SUM(Price)", string.Empty));
            lbl_totalAmount.Text = sum.ToString();
            int qtysum = Convert.ToInt32(TemTABLE.Compute("SUM(Qty)", string.Empty));
            Qty_2.Text = qtysum.ToString();

       
        }
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

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_orderItems.Rows.Count; i++)
            {
                db.Salesmen_update_data("Update Item_Table Set Quantity+='"+ Convert.ToInt32(gv_orderItems.Rows[i].Cells[3].Value.ToString()) + "' where ItemId='" + Convert.ToInt32(gv_orderItems.Rows[i].Cells[0].Value.ToString()) + "'");
               
            }
          MetroMessageBox.Show(this,"Order Is Updated");
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
            

        }

        private void txt_Serach_TextChanged(object sender, EventArgs e)
        {

        }

        private void gv_Product_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string name = gv_Product.CurrentRow.Cells[1].Value.ToString();
            string Price = gv_Product.CurrentRow.Cells[2].Value.ToString();
            lbl_Name.Text = name;
            lbl_Price.Text = Price;
        }

        private void gv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //private void gv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (gv_Product.Columns[e.ColumnIndex].Name == "Select")
        //    {
        //        string name = gv_Product.Rows[e.RowIndex].Cells[2].Value.ToString();
        //        string Price = gv_Product.Rows[e.RowIndex].Cells[3].Value.ToString();
        //        string Chemical_Name = gv_Product.Rows[e.RowIndex].Cells[4].Value.ToString();

        //        lbl_Name.Text = name;
        //        lbl_Price.Text = Price;

        //    }
        //}

       

       

       
    }
}
