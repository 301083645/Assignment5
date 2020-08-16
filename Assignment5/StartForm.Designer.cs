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
            this.ToSelectFormButton = new System.Windows.Forms.Button();
            this.ToProductInfoFormButton = new System.Windows.Forms.Button();
            this.StartFormExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToSelectFormButton
            // 
            this.ToSelectFormButton.Location = new System.Drawing.Point(50, 230);
            this.ToSelectFormButton.Name = "ToSelectFormButton";
            this.ToSelectFormButton.Size = new System.Drawing.Size(300, 50);
            this.ToSelectFormButton.TabIndex = 0;
            this.ToSelectFormButton.Text = "Start a new order";
            this.ToSelectFormButton.UseVisualStyleBackColor = true;
            // 
            // ToProductInfoFormButton
            // 
            this.ToProductInfoFormButton.Location = new System.Drawing.Point(50, 302);
            this.ToProductInfoFormButton.Name = "ToProductInfoFormButton";
            this.ToProductInfoFormButton.Size = new System.Drawing.Size(300, 50);
            this.ToProductInfoFormButton.TabIndex = 1;
            this.ToProductInfoFormButton.Text = "Load a saved order";
            this.ToProductInfoFormButton.UseVisualStyleBackColor = true;
            // 
            // StartFormExitButton
            // 
            this.StartFormExitButton.Location = new System.Drawing.Point(50, 374);
            this.StartFormExitButton.Name = "StartFormExitButton";
            this.StartFormExitButton.Size = new System.Drawing.Size(300, 50);
            this.StartFormExitButton.TabIndex = 2;
            this.StartFormExitButton.Text = "Exit the program";
            this.StartFormExitButton.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormExitButton);
            this.Controls.Add(this.ToProductInfoFormButton);
            this.Controls.Add(this.ToSelectFormButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Dollar Computers";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToSelectFormButton;
        private System.Windows.Forms.Button ToProductInfoFormButton;
        private System.Windows.Forms.Button StartFormExitButton;
    }
}

