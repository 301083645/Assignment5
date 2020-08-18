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
            this.PIMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PIGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypelabel = new System.Windows.Forms.Label();
            this.HDDlabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedlabel = new System.Windows.Forms.Label();
            this.CPUNumberlabel = new System.Windows.Forms.Label();
            this.LCDSizelabel = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypelabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ProductInfoOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PIMenuStrip.SuspendLayout();
            this.PIGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
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
            this.PINextButton.Click += new System.EventHandler(this.PINextButton_Click);
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
            // PIMenuStrip
            // 
            this.PIMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.PIMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PIMenuStrip.Name = "PIMenuStrip";
            this.PIMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.PIMenuStrip.TabIndex = 4;
            this.PIMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductToolStripMenuItem_Click);
            // 
            // PIGroupBox
            // 
            this.PIGroupBox.Controls.Add(this.ModelTextBox);
            this.PIGroupBox.Controls.Add(this.OSTextBox);
            this.PIGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.PIGroupBox.Controls.Add(this.ModelLabel);
            this.PIGroupBox.Controls.Add(this.OSLabel);
            this.PIGroupBox.Controls.Add(this.PlatformTextBox);
            this.PIGroupBox.Controls.Add(this.ManufacturerLabel);
            this.PIGroupBox.Controls.Add(this.PlatformLabel);
            this.PIGroupBox.Location = new System.Drawing.Point(12, 91);
            this.PIGroupBox.Name = "PIGroupBox";
            this.PIGroupBox.Size = new System.Drawing.Size(760, 112);
            this.PIGroupBox.TabIndex = 5;
            this.PIGroupBox.TabStop = false;
            this.PIGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.White;
            this.ModelTextBox.ForeColor = System.Drawing.Color.Black;
            this.ModelTextBox.Location = new System.Drawing.Point(325, 74);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(421, 20);
            this.ModelTextBox.TabIndex = 14;
            // 
            // OSTextBox
            // 
            this.OSTextBox.BackColor = System.Drawing.Color.White;
            this.OSTextBox.ForeColor = System.Drawing.Color.Black;
            this.OSTextBox.Location = new System.Drawing.Point(325, 33);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(421, 20);
            this.OSTextBox.TabIndex = 13;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.Color.White;
            this.ManufacturerTextBox.ForeColor = System.Drawing.Color.Black;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(109, 74);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(131, 20);
            this.ManufacturerTextBox.TabIndex = 10;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.Color.Black;
            this.ModelLabel.Location = new System.Drawing.Point(278, 77);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(41, 13);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.ForeColor = System.Drawing.Color.Black;
            this.OSLabel.Location = new System.Drawing.Point(295, 36);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(24, 13);
            this.OSLabel.TabIndex = 7;
            this.OSLabel.Text = "OS";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.Color.White;
            this.PlatformTextBox.ForeColor = System.Drawing.Color.Black;
            this.PlatformTextBox.Location = new System.Drawing.Point(109, 33);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(131, 20);
            this.PlatformTextBox.TabIndex = 9;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.ForeColor = System.Drawing.Color.Black;
            this.ManufacturerLabel.Location = new System.Drawing.Point(8, 77);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(82, 13);
            this.ManufacturerLabel.TabIndex = 7;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.ForeColor = System.Drawing.Color.Black;
            this.PlatformLabel.Location = new System.Drawing.Point(37, 36);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(53, 13);
            this.PlatformLabel.TabIndex = 7;
            this.PlatformLabel.Text = "Platform";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypelabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDlabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedlabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberlabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizelabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypelabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 209);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(760, 169);
            this.TechSpecsGroupBox.TabIndex = 6;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.BackColor = System.Drawing.Color.White;
            this.WebCamTextBox.ForeColor = System.Drawing.Color.Black;
            this.WebCamTextBox.Location = new System.Drawing.Point(558, 127);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(188, 20);
            this.WebCamTextBox.TabIndex = 19;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.BackColor = System.Drawing.Color.White;
            this.GPUTypeTextBox.ForeColor = System.Drawing.Color.Black;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(558, 81);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(188, 20);
            this.GPUTypeTextBox.TabIndex = 18;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.BackColor = System.Drawing.Color.White;
            this.HDDTextBox.ForeColor = System.Drawing.Color.Black;
            this.HDDTextBox.Location = new System.Drawing.Point(558, 33);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(188, 20);
            this.HDDTextBox.TabIndex = 17;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.BackColor = System.Drawing.Color.White;
            this.CPUSpeedTextBox.ForeColor = System.Drawing.Color.Black;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(343, 127);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(131, 20);
            this.CPUSpeedTextBox.TabIndex = 16;
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.BackColor = System.Drawing.Color.White;
            this.CPUNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(344, 81);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.ReadOnly = true;
            this.CPUNumberTextBox.Size = new System.Drawing.Size(131, 20);
            this.CPUNumberTextBox.TabIndex = 15;
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.BackColor = System.Drawing.Color.White;
            this.LCDSizeTextBox.ForeColor = System.Drawing.Color.Black;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(343, 33);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(131, 20);
            this.LCDSizeTextBox.TabIndex = 14;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.ForeColor = System.Drawing.Color.Black;
            this.WebCamLabel.Location = new System.Drawing.Point(495, 130);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(57, 13);
            this.WebCamLabel.TabIndex = 11;
            this.WebCamLabel.Text = "WebCam";
            // 
            // GPUTypelabel
            // 
            this.GPUTypelabel.AutoSize = true;
            this.GPUTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypelabel.ForeColor = System.Drawing.Color.Black;
            this.GPUTypelabel.Location = new System.Drawing.Point(487, 84);
            this.GPUTypelabel.Name = "GPUTypelabel";
            this.GPUTypelabel.Size = new System.Drawing.Size(65, 13);
            this.GPUTypelabel.TabIndex = 12;
            this.GPUTypelabel.Text = "GPU Type";
            // 
            // HDDlabel
            // 
            this.HDDlabel.AutoSize = true;
            this.HDDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDlabel.ForeColor = System.Drawing.Color.Black;
            this.HDDlabel.Location = new System.Drawing.Point(490, 36);
            this.HDDlabel.Name = "HDDlabel";
            this.HDDlabel.Size = new System.Drawing.Size(62, 13);
            this.HDDlabel.TabIndex = 13;
            this.HDDlabel.Text = "HDD Size";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.BackColor = System.Drawing.Color.White;
            this.CPUTypeTextBox.ForeColor = System.Drawing.Color.Black;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(109, 127);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(131, 20);
            this.CPUTypeTextBox.TabIndex = 10;
            // 
            // CPUSpeedlabel
            // 
            this.CPUSpeedlabel.AutoSize = true;
            this.CPUSpeedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedlabel.ForeColor = System.Drawing.Color.Black;
            this.CPUSpeedlabel.Location = new System.Drawing.Point(266, 130);
            this.CPUSpeedlabel.Name = "CPUSpeedlabel";
            this.CPUSpeedlabel.Size = new System.Drawing.Size(72, 13);
            this.CPUSpeedlabel.TabIndex = 7;
            this.CPUSpeedlabel.Text = "CPU Speed";
            // 
            // CPUNumberlabel
            // 
            this.CPUNumberlabel.AutoSize = true;
            this.CPUNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberlabel.ForeColor = System.Drawing.Color.Black;
            this.CPUNumberlabel.Location = new System.Drawing.Point(259, 84);
            this.CPUNumberlabel.Name = "CPUNumberlabel";
            this.CPUNumberlabel.Size = new System.Drawing.Size(79, 13);
            this.CPUNumberlabel.TabIndex = 7;
            this.CPUNumberlabel.Text = "CPU Number";
            // 
            // LCDSizelabel
            // 
            this.LCDSizelabel.AutoSize = true;
            this.LCDSizelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizelabel.ForeColor = System.Drawing.Color.Black;
            this.LCDSizelabel.Location = new System.Drawing.Point(279, 36);
            this.LCDSizelabel.Name = "LCDSizelabel";
            this.LCDSizelabel.Size = new System.Drawing.Size(59, 13);
            this.LCDSizelabel.TabIndex = 7;
            this.LCDSizelabel.Text = "LCD Size";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.BackColor = System.Drawing.Color.White;
            this.CPUBrandTextBox.ForeColor = System.Drawing.Color.Black;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(109, 81);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(131, 20);
            this.CPUBrandTextBox.TabIndex = 10;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BackColor = System.Drawing.Color.White;
            this.MemoryTextBox.ForeColor = System.Drawing.Color.Black;
            this.MemoryTextBox.Location = new System.Drawing.Point(109, 33);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(131, 20);
            this.MemoryTextBox.TabIndex = 10;
            // 
            // CPUTypelabel
            // 
            this.CPUTypelabel.AutoSize = true;
            this.CPUTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypelabel.ForeColor = System.Drawing.Color.Black;
            this.CPUTypelabel.Location = new System.Drawing.Point(26, 130);
            this.CPUTypelabel.Name = "CPUTypelabel";
            this.CPUTypelabel.Size = new System.Drawing.Size(64, 13);
            this.CPUTypelabel.TabIndex = 7;
            this.CPUTypelabel.Text = "CPU Type";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.ForeColor = System.Drawing.Color.Black;
            this.CPUBrandLabel.Location = new System.Drawing.Point(21, 84);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(69, 13);
            this.CPUBrandLabel.TabIndex = 7;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.ForeColor = System.Drawing.Color.Black;
            this.MemoryLabel.Location = new System.Drawing.Point(40, 36);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(50, 13);
            this.MemoryLabel.TabIndex = 7;
            this.MemoryLabel.Text = "Memory";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductIDLabel.Location = new System.Drawing.Point(34, 55);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(68, 13);
            this.ProductIDLabel.TabIndex = 7;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.BackColor = System.Drawing.Color.White;
            this.ProductIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.ProductIDTextBox.Location = new System.Drawing.Point(121, 52);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.ReadOnly = true;
            this.ProductIDTextBox.Size = new System.Drawing.Size(131, 20);
            this.ProductIDTextBox.TabIndex = 8;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.ForeColor = System.Drawing.Color.Black;
            this.ConditionLabel.Location = new System.Drawing.Point(271, 55);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(60, 13);
            this.ConditionLabel.TabIndex = 7;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.ForeColor = System.Drawing.Color.Black;
            this.CostLabel.Location = new System.Drawing.Point(501, 55);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(32, 13);
            this.CostLabel.TabIndex = 11;
            this.CostLabel.Text = "Cost";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.Color.White;
            this.ConditionTextBox.ForeColor = System.Drawing.Color.Black;
            this.ConditionTextBox.Location = new System.Drawing.Point(337, 52);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(131, 20);
            this.ConditionTextBox.TabIndex = 12;
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.ForeColor = System.Drawing.Color.Black;
            this.CostTextBox.Location = new System.Drawing.Point(548, 52);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(131, 20);
            this.CostTextBox.TabIndex = 13;
            // 
            // ProductInfoOpenFile
            // 
            this.ProductInfoOpenFile.DefaultExt = "txt";
            this.ProductInfoOpenFile.FileName = "Product";
            this.ProductInfoOpenFile.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // ProductInfoSaveFileDialog
            // 
            this.ProductInfoSaveFileDialog.DefaultExt = "txt";
            this.ProductInfoSaveFileDialog.FileName = "Product";
            this.ProductInfoSaveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.PIGroupBox);
            this.Controls.Add(this.PIBackButton);
            this.Controls.Add(this.PICancelButton);
            this.Controls.Add(this.PINextButton);
            this.Controls.Add(this.PIMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.PIMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.PIMenuStrip.ResumeLayout(false);
            this.PIMenuStrip.PerformLayout();
            this.PIGroupBox.ResumeLayout(false);
            this.PIGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PINextButton;
        private System.Windows.Forms.Button PICancelButton;
        private System.Windows.Forms.Button PIBackButton;
        private System.Windows.Forms.MenuStrip PIMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.GroupBox PIGroupBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Label LCDSizelabel;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label CPUTypelabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CPUSpeedlabel;
        private System.Windows.Forms.Label CPUNumberlabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypelabel;
        private System.Windows.Forms.Label HDDlabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.OpenFileDialog ProductInfoOpenFile;
        private System.Windows.Forms.SaveFileDialog ProductInfoSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}