/*
 * App name         : Dollar Computers
 * Author's name    : Eunbee Lee
 * Student ID       : 301083645
 * App Creation Date: Aug 15, 2020
 * App description  : A program that generate list of computers for sale and store the data 
 *                    that you chose and load the data you saved it. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public static class Program
    {
        // public static 
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static Product selectedProduct;
        public static OrderForm orderForm;
        public static AboutBoxForm aboutBoxForm;
        public static PrintMessageBox printMessageBox;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // create 
            splashForm = new SplashForm();
            selectedProduct = new Product();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutBoxForm = new AboutBoxForm();
            printMessageBox = new PrintMessageBox();
            
            
            Application.Run(splashForm);
        }
    }
}
