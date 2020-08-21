namespace Assignment5
{
    partial class FinishMessageBox
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
            this.Messagelabel = new System.Windows.Forms.Label();
            this.FinishOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Messagelabel
            // 
            this.Messagelabel.Location = new System.Drawing.Point(25, 13);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(250, 80);
            this.Messagelabel.TabIndex = 0;
            this.Messagelabel.Text = "Thank you. Your order will be processed in 7~10 business days.";
            // 
            // FinishOKButton
            // 
            this.FinishOKButton.Location = new System.Drawing.Point(95, 109);
            this.FinishOKButton.Name = "FinishOKButton";
            this.FinishOKButton.Size = new System.Drawing.Size(75, 30);
            this.FinishOKButton.TabIndex = 1;
            this.FinishOKButton.Text = "OK";
            this.FinishOKButton.UseVisualStyleBackColor = true;
            this.FinishOKButton.Click += new System.EventHandler(this.FinishOKButton_Click);
            // 
            // FinishMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.ControlBox = false;
            this.Controls.Add(this.FinishOKButton);
            this.Controls.Add(this.Messagelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinishMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.Button FinishOKButton;
    }
}