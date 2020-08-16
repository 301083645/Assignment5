namespace Assignment5
{
    partial class ProductInfoForm
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
            this.PINextButton = new System.Windows.Forms.Button();
            this.PICancelButton = new System.Windows.Forms.Button();
            this.PIBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PINextButton
            // 
            this.PINextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINextButton.Location = new System.Drawing.Point(638, 388);
            this.PINextButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PINextButton.Name = "PINextButton";
            this.PINextButton.Size = new System.Drawing.Size(120, 40);
            this.PINextButton.TabIndex = 1;
            this.PINextButton.Text = "Next";
            this.PINextButton.UseVisualStyleBackColor = true;
            // 
            // PICancelButton
            // 
            this.PICancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PICancelButton.Location = new System.Drawing.Point(502, 388);
            this.PICancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PICancelButton.Name = "PICancelButton";
            this.PICancelButton.Size = new System.Drawing.Size(120, 40);
            this.PICancelButton.TabIndex = 2;
            this.PICancelButton.Text = "Cancel";
            this.PICancelButton.UseVisualStyleBackColor = true;
            this.PICancelButton.Click += new System.EventHandler(this.PICancelButton_Click);
            // 
            // PIBackButton
            // 
            this.PIBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIBackButton.Location = new System.Drawing.Point(262, 388);
            this.PIBackButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PIBackButton.Name = "PIBackButton";
            this.PIBackButton.Size = new System.Drawing.Size(224, 40);
            this.PIBackButton.TabIndex = 3;
            this.PIBackButton.Text = "Select another product";
            this.PIBackButton.UseVisualStyleBackColor = true;
            this.PIBackButton.Click += new System.EventHandler(this.PIBackButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.PIBackButton);
            this.Controls.Add(this.PICancelButton);
            this.Controls.Add(this.PINextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PINextButton;
        private System.Windows.Forms.Button PICancelButton;
        private System.Windows.Forms.Button PIBackButton;
    }
}