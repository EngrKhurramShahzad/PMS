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
    public partial class Salesman: MetroFramework.Forms.MetroForm
    {
        public Salesman()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
                       this.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            Obj.Salesmen_insertValues("Insert into Salesmen_Table values('" + Convert.ToInt32(Salesmen_id.Text) + "','" + Salesmen_Name.Text + "','" + Salesmen_Cnic.Text.ToString() + "','" + Salesmen_Contact.Text.ToString() + "','" + Salesmen_Address.Text + "','" + Salesmen_Email.Text + "')");
            MessageBox.Show("Value is Inserted");
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            Obj.Salesmen_update_data("Update Salesmen_Table Set name='" + Salesmen_Name.Text + "',address='" + Salesmen_Address.Text + "',Cnic='" + Salesmen_Cnic.Text + "',PhoneNumber='" + Salesmen_Contact.Text + "',Email='" + Salesmen_Email.Text + "' Where SalesmenId='" + Convert.ToInt32(Salesmen_id.Text) + "'");
            MessageBox.Show("Value is Updated");
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            DBClass Obj = new DBClass();
            Obj.Del_data("Delete  from Salesmen_Table where SalesmenId='" + Convert.ToInt16(Salesmen_id.Text) + "'");
            MessageBox.Show("Value is Deleted");
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
