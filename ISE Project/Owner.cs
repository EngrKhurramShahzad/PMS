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
    public partial class Owner : MetroFramework.Forms.MetroForm
    {
        public Owner()
        {
            InitializeComponent();
        }

       
        private void Order_Click(object sender, EventArgs e)
        {
          new Vendor().Show();
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            new Medicines().Show();
            this.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }
    }
}
