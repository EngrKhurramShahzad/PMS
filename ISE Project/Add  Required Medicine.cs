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
    public partial class Required : MetroFramework.Forms.MetroForm
    {
        DBClass db = new DBClass();
        public Required()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Required().Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        { 
            DataTable dt = db.RequiredItem_disp("Select SalesmenId from Salesmen_Table");
            foreach (DataRow item in dt.Rows)
            {
                SalesmanId.Items.Add(item[0].ToString());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            Obj.Salesmen_insertValues("Insert into Required_List_Table values('" + Convert.ToInt32(Item_Id.Text) + "','" + Item_Name.Text + "','" + Item_type.Text + "','" + Convert.ToInt64(Item_Quantity.Text) + "')");
            MessageBox.Show("Value is Inserted");
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Item_Quantity_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
