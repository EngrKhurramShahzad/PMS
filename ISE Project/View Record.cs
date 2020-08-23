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
    public partial class Medicines: MetroFramework.Forms.MetroForm
    {
        public Medicines()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Medicines().Show();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            new Owner().Show();
            this.Close();
        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void Medicines_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

           
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            try
            {
                dataGridView1.DataSource = Obj.RequiredItem_disp("Select * from Item_Table");
                MessageBox.Show("Value is View");
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Viewing Values");
            }
        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            DBClass Obj = new DBClass();
            try
            {
                dataGridView2.DataSource = Obj.RequiredItem_disp("Select * from Required_List_Table");
                MessageBox.Show("Value is View");
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Viewing Values");
            }
        }

       
        }
    }

