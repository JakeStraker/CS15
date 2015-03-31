namespace Group_Stegonography_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pBoxMain = new System.Windows.Forms.PictureBox();
            this.stripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embedHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractionHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSecretText = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnEmbed = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblImgSize = new System.Windows.Forms.Label();
            this.lblFileMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).BeginInit();
            this.stripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoxMain
            // 
            this.pBoxMain.Location = new System.Drawing.Point(12, 70);
            this.pBoxMain.Name = "pBoxMain";
            this.pBoxMain.Size = new System.Drawing.Size(350, 250);
            this.pBoxMain.TabIndex = 0;
            this.pBoxMain.TabStop = false;
            // 
            // stripFile
            // 
            this.stripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.stripFile.Location = new System.Drawing.Point(0, 0);
            this.stripFile.Name = "stripFile";
            this.stripFile.Size = new System.Drawing.Size(373, 24);
            this.stripFile.TabIndex = 1;
            this.stripFile.Text = "menuStrip1";
            this.stripFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stripFile_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.embedHelpToolStripMenuItem,
            this.extractionHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // embedHelpToolStripMenuItem
            // 
            this.embedHelpToolStripMenuItem.Name = "embedHelpToolStripMenuItem";
            this.embedHelpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.embedHelpToolStripMenuItem.Text = "Embedding Help";
            // 
            // extractionHelpToolStripMenuItem
            // 
            this.extractionHelpToolStripMenuItem.Name = "extractionHelpToolStripMenuItem";
            this.extractionHelpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.extractionHelpToolStripMenuItem.Text = "Extraction Help";
            // 
            // txtSecretText
            // 
            this.txtSecretText.Location = new System.Drawing.Point(12, 392);
            this.txtSecretText.Multiline = true;
            this.txtSecretText.Name = "txtSecretText";
            this.txtSecretText.Size = new System.Drawing.Size(350, 100);
            this.txtSecretText.TabIndex = 2;
            this.txtSecretText.Text = "Text to be embedded in the image";
            // 
            // btnExtract
            // 
            this.btnExtract.Image = ((System.Drawing.Image)(resources.GetObject("btnExtract.Image")));
            this.btnExtract.Location = new System.Drawing.Point(12, 326);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(154, 36);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Extract Data";
            this.btnExtract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnEmbed
            // 
            this.btnEmbed.Image = ((System.Drawing.Image)(resources.GetObject("btnEmbed.Image")));
            this.btnEmbed.Location = new System.Drawing.Point(208, 326);
            this.btnEmbed.Name = "btnEmbed";
            this.btnEmbed.Size = new System.Drawing.Size(154, 36);
            this.btnEmbed.TabIndex = 4;
            this.btnEmbed.Text = "Embed Data";
            this.btnEmbed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmbed.UseVisualStyleBackColor = true;
            this.btnEmbed.Click += new System.EventHandler(this.btnEmbed_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(12, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(350, 37);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select an Image";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 498);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblImgSize
            // 
            this.lblImgSize.AutoSize = true;
            this.lblImgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgSize.Location = new System.Drawing.Point(12, 365);
            this.lblImgSize.Name = "lblImgSize";
            this.lblImgSize.Size = new System.Drawing.Size(102, 20);
            this.lblImgSize.TabIndex = 7;
            this.lblImgSize.Text = "Size = 00000";
            // 
            // lblFileMax
            // 
            this.lblFileMax.AutoSize = true;
            this.lblFileMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileMax.Location = new System.Drawing.Point(177, 365);
            this.lblFileMax.Name = "lblFileMax";
            this.lblFileMax.Size = new System.Drawing.Size(149, 20);
            this.lblFileMax.TabIndex = 8;
            this.lblFileMax.Text = "Max Data = 0 Chars";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(373, 576);
            this.Controls.Add(this.lblFileMax);
            this.Controls.Add(this.lblImgSize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnEmbed);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.txtSecretText);
            this.Controls.Add(this.pBoxMain);
            this.Controls.Add(this.stripFile);
            this.MainMenuStrip = this.stripFile;
            this.Name = "frmMain";
            this.Text = "CS15 Steganography Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).EndInit();
            this.stripFile.ResumeLayout(false);
            this.stripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxMain;
        private System.Windows.Forms.MenuStrip stripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embedHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractionHelpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSecretText;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnEmbed;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblImgSize;
        private System.Windows.Forms.Label lblFileMax;
    }
}

