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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.Products);

            var products =
                (from product in this.dollarComputersDataSet.Products
                 orderby product.productID
                 select product).ToList();

            foreach (var product in products)
            {
                var newProduct = new Product(
                    product.productID,
                    product.cost,
                    product.manufacturer,
                    product.model,
                    product.RAM_type,
                    product.RAM_size,
                    product.displaytype,
                    product.screensize,
                    product.resolution,
                    product.CPU_Class,
                    product.CPU_brand,
                    product.CPU_type,
                    product.CPU_speed,
                    product.CPU_number,
                    product.condition,
                    product.OS,
                    product.platform,
                    product.HDD_size,
                    product.HDD_speed,
                    product.GPU_Type,
                    product.optical_drive,
                    product.Audio_type,
                    product.LAN,
                    product.WIFI,
                    product.width,
                    product.height,
                    product.depth,
                    product.weight,
                    product.moust_type,
                    product.power,
                    product.webcam

                    );

                Program.products.Add(newProduct);

            }
        }
    }
}
