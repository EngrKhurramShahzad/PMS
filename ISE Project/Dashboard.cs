using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ISE_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Customer(this).Show();
                      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Salesman().Show();
                               }

        private void button2_Click(object sender, EventArgs e)
        {
            new Return().Show();
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Select().Show();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Owner().Show();
            
            
                   }

        private void button6_Click(object sender, EventArgs e)
        {
            new VendorInf().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        
    }
}
