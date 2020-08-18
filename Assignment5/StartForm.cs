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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        
        // exit the application
        private void StartFormExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //move to the selectForm;
        private void ToSelectFormButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        // move to the productInfoForm;
        private void ToProductInfoFormButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            
            this.Hide();
        }
    }
}
