using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        // exit the program;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // move to the productInfoForm;
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        // get data from db;
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.Products);

            ProductsDataGridView_CellClick(sender, e as DataGridViewCellEventArgs);
            
            //Reading from the database
            using (var db = new ProductModel())// Entity Framework
            {
                // read from the database
                

                var query = (from product in db.Products
                             select product).ToList();

                foreach (var product in query)
                {
                    Debug.WriteLine(product.productID);
                }
            }


            /*
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
            */


        }

        // get all the data from one line 
        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.selectedProduct.productID = (short)(ProductsDataGridView.SelectedRows[0].Cells[0].Value);
            Program.selectedProduct.cost = (decimal)(ProductsDataGridView.SelectedRows[0].Cells[1].Value);
            Program.selectedProduct.manufacturer = ProductsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Program.selectedProduct.model = ProductsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Program.selectedProduct.RAM_type = ProductsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Program.selectedProduct.RAM_size = ProductsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Program.selectedProduct.displaytype = ProductsDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            Program.selectedProduct.screensize = ProductsDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Program.selectedProduct.resolution = ProductsDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            Program.selectedProduct.CPU_Class = ProductsDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            Program.selectedProduct.CPU_brand = ProductsDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            Program.selectedProduct.CPU_type = ProductsDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Program.selectedProduct.CPU_speed = ProductsDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            Program.selectedProduct.CPU_number = ProductsDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            Program.selectedProduct.condition = ProductsDataGridView.SelectedRows[0].Cells[14].Value.ToString();
            Program.selectedProduct.OS = ProductsDataGridView.SelectedRows[0].Cells[15].Value.ToString();
            Program.selectedProduct.platform = ProductsDataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Program.selectedProduct.HDD_size = ProductsDataGridView.SelectedRows[0].Cells[17].Value.ToString();
            Program.selectedProduct.HDD_speed = ProductsDataGridView.SelectedRows[0].Cells[18].Value.ToString();
            Program.selectedProduct.GPU_Type = ProductsDataGridView.SelectedRows[0].Cells[19].Value.ToString();
            Program.selectedProduct.optical_drive = ProductsDataGridView.SelectedRows[0].Cells[20].Value.ToString();
            Program.selectedProduct.Audio_type = ProductsDataGridView.SelectedRows[0].Cells[21].Value.ToString();
            Program.selectedProduct.LAN = ProductsDataGridView.SelectedRows[0].Cells[22].Value.ToString();
            Program.selectedProduct.WIFI = ProductsDataGridView.SelectedRows[0].Cells[23].Value.ToString();
            Program.selectedProduct.width = ProductsDataGridView.SelectedRows[0].Cells[24].Value.ToString();
            Program.selectedProduct.height = ProductsDataGridView.SelectedRows[0].Cells[25].Value.ToString();
            Program.selectedProduct.depth = ProductsDataGridView.SelectedRows[0].Cells[26].Value.ToString();
            Program.selectedProduct.weight = ProductsDataGridView.SelectedRows[0].Cells[27].Value.ToString();
            Program.selectedProduct.moust_type = ProductsDataGridView.SelectedRows[0].Cells[28].Value.ToString();
            Program.selectedProduct.power = ProductsDataGridView.SelectedRows[0].Cells[29].Value.ToString();
            Program.selectedProduct.webcam = ProductsDataGridView.SelectedRows[0].Cells[30].Value.ToString();
            


            SelectionTextBox.Text = $@"{Program.selectedProduct.manufacturer} {Program.selectedProduct.model} {Program.selectedProduct.cost}";
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
