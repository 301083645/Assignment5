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
    public partial class PrintMessageBox : Form
    {
        public PrintMessageBox()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PrintMessageBox_Load(object sender, EventArgs e)
        {
            SelectedItemLabel.Text = Program.selectedProduct.model;
        }
    }
}
