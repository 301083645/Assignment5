using Assignment5.DollarComputersDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void PICancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PIBackButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
           

        }
    }
}
