namespace Assignment5
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.ToSelectFormButton = new System.Windows.Forms.Button();
            this.ToProductInfoFormButton = new System.Windows.Forms.Button();
            this.StartFormExitButton = new System.Windows.Forms.Button();
            this.CoinPictureBox = new System.Windows.Forms.PictureBox();
            this.AdvertisingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToSelectFormButton
            // 
            this.ToSelectFormButton.Location = new System.Drawing.Point(50, 262);
            this.ToSelectFormButton.Name = "ToSelectFormButton";
            this.ToSelectFormButton.Size = new System.Drawing.Size(300, 50);
            this.ToSelectFormButton.TabIndex = 0;
            this.ToSelectFormButton.Text = "Start a new order";
            this.ToSelectFormButton.UseVisualStyleBackColor = true;
            this.ToSelectFormButton.Click += new System.EventHandler(this.ToSelectFormButton_Click);
            // 
            // ToProductInfoFormButton
            // 
            this.ToProductInfoFormButton.Location = new System.Drawing.Point(50, 318);
            this.ToProductInfoFormButton.Name = "ToProductInfoFormButton";
            this.ToProductInfoFormButton.Size = new System.Drawing.Size(300, 50);
            this.ToProductInfoFormButton.TabIndex = 1;
            this.ToProductInfoFormButton.Text = "Load a saved order";
            this.ToProductInfoFormButton.UseVisualStyleBackColor = true;
            this.ToProductInfoFormButton.Click += new System.EventHandler(this.ToProductInfoFormButton_Click);
            // 
            // StartFormExitButton
            // 
            this.StartFormExitButton.Location = new System.Drawing.Point(50, 374);
            this.StartFormExitButton.Name = "StartFormExitButton";
            this.StartFormExitButton.Size = new System.Drawing.Size(300, 50);
            this.StartFormExitButton.TabIndex = 2;
            this.StartFormExitButton.Text = "Exit the program";
            this.StartFormExitButton.UseVisualStyleBackColor = true;
            this.StartFormExitButton.Click += new System.EventHandler(this.StartFormExitButton_Click);
            // 
            // CoinPictureBox
            // 
            this.CoinPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CoinPictureBox.Image")));
            this.CoinPictureBox.Location = new System.Drawing.Point(100, 56);
            this.CoinPictureBox.Name = "CoinPictureBox";
            this.CoinPictureBox.Size = new System.Drawing.Size(200, 200);
            this.CoinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinPictureBox.TabIndex = 3;
            this.CoinPictureBox.TabStop = false;
            // 
            // AdvertisingLabel
            // 
            this.AdvertisingLabel.AutoSize = true;
            this.AdvertisingLabel.Location = new System.Drawing.Point(19, 9);
            this.AdvertisingLabel.Name = "AdvertisingLabel";
            this.AdvertisingLabel.Size = new System.Drawing.Size(345, 31);
            this.AdvertisingLabel.TabIndex = 4;
            this.AdvertisingLabel.Text = "Order your computer today!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.AdvertisingLabel);
            this.Controls.Add(this.CoinPictureBox);
            this.Controls.Add(this.StartFormExitButton);
            this.Controls.Add(this.ToProductInfoFormButton);
            this.Controls.Add(this.ToSelectFormButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Dollar Computers";
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToSelectFormButton;
        private System.Windows.Forms.Button ToProductInfoFormButton;
        private System.Windows.Forms.Button StartFormExitButton;
        private System.Windows.Forms.PictureBox CoinPictureBox;
        private System.Windows.Forms.Label AdvertisingLabel;
    }
}

