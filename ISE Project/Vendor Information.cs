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
    public partial class VendorInf: MetroFramework.Forms.MetroForm
    {
        public VendorInf()
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
            Obj.Salesmen_insertValues("Insert into Vendor_Table values('" + Convert.ToInt32(Vendor_id.Text) + "','" + Vendor_Name.Text + "','" +Vendor_Cnic.Text.ToString()+ "','" + Vendor_Contact.Text.ToString() + "','" + Vendor_Address.Text + "','" + Vendor_Email.Text + "')");
            MessageBox.Show("Value is Inserted");
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            Obj.Salesmen_update_data("Update Vendor_Table Set name='" + Vendor_Name.Text + "',address='" + Vendor_Address.Text + "',Cnic='" + Vendor_Cnic.Text + "',PhoneNumber='" + Vendor_Contact.Text + "',Email='" + Vendor_Email.Text + "' Where SalesmenId='" + Convert.ToInt32(Vendor_id.Text) + "'");
            MessageBox.Show("Value is Updated");
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            DBClass Obj = new DBClass();
            Obj.Del_data("Delete  from Vendor_Table where VendorId='" + Convert.ToInt16(Vendor_id.Text) + "'");
            MessageBox.Show("Value is Deleted");
            this.Hide();
        }

        private void Salesmen_Cnic_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Vendor_Contact_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
