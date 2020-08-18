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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        // close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // back to ProductInfoForm
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        // back to ProductInfoForm
        private void oBackButton_Click(object sender, EventArgs e)
        {
            ResetForm();
            Program.productInfoForm.Show();
            this.Hide();
        }

        // Reset the form
        private void ResetForm()
        {
            oConditionTextBox.Clear();
            oPlatformTextBox.Clear();
            oManufacturerTextBox.Clear();
            oModelTextBox.Clear();
            oScrrenSizeTextBox.Clear();
            oMemoryTextBox.Clear();
            oCPUBrandTextBox.Clear();
            oCPUNumberTextBox.Clear();
            oCPUSpeedTextBox.Clear();
            oCPUTypeTextBox.Clear();
            oHDDTextBox.Clear();
            oGPUTypeTextBox.Clear();
            oWebCamTextBox.Clear();
            oOSTextBox.Clear();
            oCostTextBox.Clear();
            oTaxTextBox.Clear();
            oTotalTextBox.Clear();

        }

        // call the data
        private void OrderForm_Load(object sender, EventArgs e)
        {
            oConditionTextBox.Text = Program.selectedProduct.condition;
            oPlatformTextBox.Text = Program.selectedProduct.platform;
            oManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
            oModelTextBox.Text = Program.selectedProduct.model;
            oScrrenSizeTextBox.Text = Program.selectedProduct.screensize;
            oMemoryTextBox.Text = Program.selectedProduct.RAM_size;
            oCPUBrandTextBox.Text = Program.selectedProduct.CPU_brand;
            oCPUNumberTextBox.Text = Program.selectedProduct.CPU_number;
            oCPUSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
            oCPUTypeTextBox.Text = Program.selectedProduct.CPU_type;
            oHDDTextBox.Text = Program.selectedProduct.HDD_size;
            oGPUTypeTextBox.Text = Program.selectedProduct.GPU_Type;
            oWebCamTextBox.Text = Program.selectedProduct.webcam;
            oOSTextBox.Text = Program.selectedProduct.OS;
            oCostTextBox.Text = Program.selectedProduct.cost.ToString();
            double cost = Convert.ToDouble(oCostTextBox.Text);
            double tax = cost * 0.13;
            oTaxTextBox.Text = tax.ToString();
            double total = cost + tax;
            oTotalTextBox.Text = total.ToString();
        }


        // exit the application
        private void oCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // set the page
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            oConditionTextBox.Text = Program.selectedProduct.condition;
            oPlatformTextBox.Text = Program.selectedProduct.platform;
            oManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
            oModelTextBox.Text = Program.selectedProduct.model;
            oScrrenSizeTextBox.Text = Program.selectedProduct.screensize;
            oMemoryTextBox.Text = Program.selectedProduct.RAM_size;
            oCPUBrandTextBox.Text = Program.selectedProduct.CPU_brand;
            oCPUNumberTextBox.Text = Program.selectedProduct.CPU_number;
            oCPUSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
            oCPUTypeTextBox.Text = Program.selectedProduct.CPU_type;
            oHDDTextBox.Text = Program.selectedProduct.HDD_size;
            oGPUTypeTextBox.Text = Program.selectedProduct.GPU_Type;
            oWebCamTextBox.Text = Program.selectedProduct.webcam;
            oOSTextBox.Text = Program.selectedProduct.OS;
            oCostTextBox.Text = Program.selectedProduct.cost.ToString();
            double cost = Convert.ToDouble(oCostTextBox.Text);
            double tax = cost * 0.13;
            oTaxTextBox.Text = tax.ToString();
            double total = cost + tax;
            oTotalTextBox.Text = total.ToString();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.aboutBoxForm.Show();

        }
    }
}
