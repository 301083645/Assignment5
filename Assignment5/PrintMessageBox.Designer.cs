namespace Assignment5
{
    partial class PrintMessageBox
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
            this.PrintLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.IsPrintingLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintLabel
            // 
            this.PrintLabel.AutoSize = true;
            this.PrintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintLabel.Location = new System.Drawing.Point(12, 24);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(110, 20);
            this.PrintLabel.TabIndex = 0;
            this.PrintLabel.Text = "Your selection";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(128, 20);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(197, 25);
            this.SelectedItemLabel.TabIndex = 1;
            this.SelectedItemLabel.Text = "selected item hahaha";
            // 
            // IsPrintingLabel
            // 
            this.IsPrintingLabel.AutoSize = true;
            this.IsPrintingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsPrintingLabel.Location = new System.Drawing.Point(120, 45);
            this.IsPrintingLabel.Name = "IsPrintingLabel";
            this.IsPrintingLabel.Size = new System.Drawing.Size(88, 20);
            this.IsPrintingLabel.TabIndex = 2;
            this.IsPrintingLabel.Text = "is printing...";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(108, 90);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 40);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PrintMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.ControlBox = false;
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.IsPrintingLabel);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.PrintLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.PrintMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrintLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label IsPrintingLabel;
        private System.Windows.Forms.Button OKButton;
    }
}