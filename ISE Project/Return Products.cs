using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE_Project
{
    public partial class Return : MetroFramework.Forms.MetroForm
    {
        DBClass db = new DBClass();
        
        public Return()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Return().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Return_Load(object sender, EventArgs e)
        {

            DataTable dt = db.RequiredItem_disp("Select VendorId from Vendor_Table");
            foreach (DataRow item in dt.Rows)
            {
                Vendor_Id.Items.Add(item[0].ToString());
            }

            DataTable dt1 = db.RequiredItem_disp("Select Name from Item_Table");
            foreach (DataRow item in dt1.Rows)
            {
                Item_Name.Items.Add(item[0].ToString());
            }
            DataTable dt2 = db.RequiredItem_disp("Select Name from Type_Table");
            foreach (DataRow item in dt2.Rows)
            {
                Item_Type.Items.Add(item[0].ToString());
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            try
            {
                gv_Return.DataSource = Obj.RequiredItem_disp("Select * from Return_Item_Table");
                MessageBox.Show("Value is View");
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Viewing Values");
            }

            
            //for (int i = 0; i < gv_Return.Rows.Count; i++)
           // {
             //   db.Salesmen_update_data("Update Item_Table Set Quantity-='" + Convert.ToInt32(gv_Return.Rows[i].Cells[2].Value.ToString()) + "' where ItemId='" + Convert.ToInt32(gv_Return.Rows[i].Cells[0].Value.ToString()) + "'");
           // }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vendor_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Vendor_Id.Text);
            DataTable dt = db.RequiredItem_disp("Select * from Vendor_Table where VendorId='" + Id + "'");
            DataRow dr = dt.Rows[0];
            Vendor_Name.Text = dr[1].ToString();
            Vendor_Cnic.Text = dr[2].ToString();
            Vendor_Contact.Text = dr[3].ToString();
            Vendor_Email.Text = dr[4].ToString();
            Vendor_Address.Text = dr[5].ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Vendor_Address_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Item_Click(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            Obj.Salesmen_insertValues("Insert into Return_Item_Table values('" + Convert.ToInt32(Item_Id.Text) + "','" + Item_Name.Text + "','" + Convert.ToInt64(Item_Quantity.Text) + "','" + Item_Type.Text + "')");
            MessageBox.Show("Value is Inserted");
            
        }

        private void Update_Item_Click(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            Obj.Salesmen_update_data("Update Item_Table Set name='" + Item_Name.Text + "',Quantity-='" + Convert.ToInt32(Item_Quantity.Text) + "' Where itemId='" + Convert.ToInt32(Item_Id.Text) + "' AND Type='" + Item_Type.Text + "'");
            MessageBox.Show("Value is Updated");
           
           // DataTable dt = db.RequiredItem_disp("SELECT * FROM Return_Item_Table WHERE ReturnItemId Like  '%" +Search.Text + "%'");
            //gv_Return.DataSource = dt;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
