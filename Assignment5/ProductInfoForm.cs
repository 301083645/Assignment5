using Assignment5.DollarComputersDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Assignment5
{
    
    public partial class ProductInfoForm : Form
    {
        public List<Product> Products { get; set; }
        
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
            ResetForm();
            Program.selectForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {

            ProductIDTextBox.Text = Program.selectedProduct.productID.ToString();
            ConditionTextBox.Text = Program.selectedProduct.condition;
            CostTextBox.Text = Program.selectedProduct.cost.ToString();
            PlatformTextBox.Text = Program.selectedProduct.platform;
            OSTextBox.Text = Program.selectedProduct.OS;
            ManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
            ModelTextBox.Text = Program.selectedProduct.model;
            MemoryTextBox.Text = Program.selectedProduct.RAM_size;
            LCDSizeTextBox.Text = Program.selectedProduct.screensize;
            HDDTextBox.Text = Program.selectedProduct.HDD_size;
            CPUBrandTextBox.Text = Program.selectedProduct.CPU_brand;
            CPUNumberTextBox.Text = Program.selectedProduct.CPU_number;
            GPUTypeTextBox.Text = Program.selectedProduct.GPU_Type;
            CPUTypeTextBox.Text = Program.selectedProduct.CPU_type;
            CPUSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
            WebCamTextBox.Text = Program.selectedProduct.webcam;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Products = new List<Product>();

            // configure the open file dialog
            ProductInfoOpenFile.InitialDirectory = Directory.GetCurrentDirectory();

            var openFileDialogResult = ProductInfoOpenFile.ShowDialog();

            string check = null;

            if (openFileDialogResult != DialogResult.Cancel)
            {
                // create a new stream reader
                StreamReader streamReader = new StreamReader(ProductInfoOpenFile.FileName);

                Products = new List<Product>();

                // clear content from TextBoxes
                ResetForm();

                
                // read in the list
                while (!streamReader.EndOfStream)
                {
                    var product = new Product();

                    string _productID = streamReader.ReadLine();
                    product.productID = Convert.ToInt16(_productID);              
                    product.condition = streamReader.ReadLine();
                    string _cost = streamReader.ReadLine();
                    product.cost = Convert.ToDecimal(_cost);
                    product.platform = streamReader.ReadLine();
                    product.OS = streamReader.ReadLine();
                    product.manufacturer = streamReader.ReadLine();
                    product.model = streamReader.ReadLine();
                    product.RAM_size = streamReader.ReadLine();
                    product.screensize = streamReader.ReadLine();
                    product.HDD_size = streamReader.ReadLine();
                    product.CPU_brand = streamReader.ReadLine();
                    product.CPU_number = streamReader.ReadLine();
                    product.GPU_Type = streamReader.ReadLine();
                    product.CPU_type = streamReader.ReadLine();
                    product.CPU_speed = streamReader.ReadLine();
                    product.webcam = streamReader.ReadLine();
                    check = streamReader.ReadLine();

                    Debug.WriteLine("check:" + check);

                    Products.Add(product); // add our new contact to the Contacts List
                }

                // clean up
                streamReader.Close();


            }

            int productNo = Convert.ToInt32(check) - 1;


            ProductIDTextBox.Text = Products[productNo].productID.ToString();
            ConditionTextBox.Text = (Products[productNo].condition).ToString();
            CostTextBox.Text = (Products[productNo].cost).ToString();            
            PlatformTextBox.Text = Products[productNo].platform;
            OSTextBox.Text = Products[productNo].OS;
            ManufacturerTextBox.Text = Products[productNo].manufacturer;
            ModelTextBox.Text = Products[productNo].model;
            MemoryTextBox.Text = Products[productNo].RAM_size;
            LCDSizeTextBox.Text = Products[productNo].screensize;
            HDDTextBox.Text = Products[productNo].HDD_size;
            CPUBrandTextBox.Text = Products[productNo].CPU_brand;
            CPUNumberTextBox.Text = Products[productNo].CPU_number;
            GPUTypeTextBox.Text = Products[productNo].GPU_Type;
            CPUTypeTextBox.Text = Products[productNo].CPU_type;
            CPUSpeedTextBox.Text = Products[productNo].CPU_speed;
            WebCamTextBox.Text = Products[productNo].webcam;
            


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the save file dialog
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            // display the savefiledialog and save the results in the saveFileDialogResult object
            var saveFileDialogResult = ProductInfoSaveFileDialog.ShowDialog();

            if(saveFileDialogResult != DialogResult.Cancel)
            {   // create new stream
                StreamWriter streamWriter = new StreamWriter(ProductInfoSaveFileDialog.FileName);

                using (var db = new ProductModel())// Entity Framework
                {


                    var products = (from product in db.Products
                                    select product).ToList();

                    foreach (var product in products)
                    {
                       

                        streamWriter.WriteLine(product.productID.ToString());
                        streamWriter.WriteLine(product.condition);
                        streamWriter.WriteLine(product.cost.ToString());
                        streamWriter.WriteLine(product.platform);
                        streamWriter.WriteLine(product.OS);
                        streamWriter.WriteLine(product.manufacturer);
                        streamWriter.WriteLine(product.model);
                        streamWriter.WriteLine(product.RAM_size);
                        streamWriter.WriteLine(product.screensize);
                        streamWriter.WriteLine(product.HDD_size);
                        streamWriter.WriteLine(product.CPU_brand);
                        streamWriter.WriteLine(product.CPU_number);
                        streamWriter.WriteLine(product.GPU_Type);
                        streamWriter.WriteLine(product.CPU_type);
                        streamWriter.WriteLine(product.CPU_speed);
                        streamWriter.WriteLine(product.webcam);
                        streamWriter.WriteLine(ProductIDTextBox.Text);

                    }

                    


                }
                        
                    
                

                        //clean up
                        streamWriter.Flush();
                        streamWriter.Close();

            }

        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            
            ProductIDTextBox.Text = Program.selectedProduct.productID.ToString();
            ConditionTextBox.Text = Program.selectedProduct.condition;
            CostTextBox.Text = Program.selectedProduct.cost.ToString();
            PlatformTextBox.Text = Program.selectedProduct.platform;
            OSTextBox.Text = Program.selectedProduct.OS;
            ManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
            ModelTextBox.Text = Program.selectedProduct.model;
            MemoryTextBox.Text = Program.selectedProduct.RAM_size;
            LCDSizeTextBox.Text = Program.selectedProduct.screensize;
            HDDTextBox.Text = Program.selectedProduct.HDD_size;
            CPUBrandTextBox.Text = Program.selectedProduct.CPU_brand;
            CPUNumberTextBox.Text = Program.selectedProduct.CPU_number;
            GPUTypeTextBox.Text = Program.selectedProduct.GPU_Type;
            CPUTypeTextBox.Text = Program.selectedProduct.CPU_type;
            CPUSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
            WebCamTextBox.Text = Program.selectedProduct.webcam;
            
            
        }

        private void ResetForm()
        {
            ProductIDTextBox.Clear(); 
            ConditionTextBox.Clear();
            CostTextBox.Clear();
            PlatformTextBox.Clear();
            OSTextBox.Clear();
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            MemoryTextBox.Clear();
            LCDSizeTextBox.Clear();
            HDDTextBox.Clear();
            CPUBrandTextBox.Clear();
            CPUNumberTextBox.Clear();
            GPUTypeTextBox.Clear();
            CPUTypeTextBox.Clear();
            CPUSpeedTextBox.Clear();
            WebCamTextBox.Clear();

        }
    }
}
