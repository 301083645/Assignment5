﻿using System;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // move to the startform and turn off the timer
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;

        }

        
        private void SplashForm_Load(object sender, EventArgs e)
        {
         SplashFormTimer.Enabled = true;
        }

        
    }
}
