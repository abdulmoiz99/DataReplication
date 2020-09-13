namespace DataReplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_DesPath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_Space = new System.Windows.Forms.Label();
            this.btn_MD5 = new System.Windows.Forms.Button();
            this.btn_VerifyFiles = new System.Windows.Forms.Button();
            this.lab_Status = new System.Windows.Forms.Label();
            this.lab_installerName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_Space32bit = new System.Windows.Forms.Label();
            this.btn_BrowseVST64bit = new System.Windows.Forms.Button();
            this.txt_64FolderPath = new System.Windows.Forms.TextBox();
            this.cb_64bit = new System.Windows.Forms.CheckBox();
            this.cb_32bit = new System.Windows.Forms.CheckBox();
            this.lab_Space64bit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BrowseVST32bit = new System.Windows.Forms.Button();
            this.txt_32FolderPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_DefaultFolder = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_DesPath
            // 
            this.txt_DesPath.Location = new System.Drawing.Point(135, 51);
            this.txt_DesPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DesPath.Name = "txt_DesPath";
            this.txt_DesPath.Size = new System.Drawing.Size(482, 26);
            this.txt_DesPath.TabIndex = 2;
            // 
            // btn_Browse
            // 
            this.btn_Browse.ForeColor = System.Drawing.Color.Black;
            this.btn_Browse.Location = new System.Drawing.Point(620, 51);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(134, 27);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(632, 521);
            this.btn_Copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(134, 27);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.Text = "Install";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path: ";
            // 
            // lab_Space
            // 
            this.lab_Space.AutoSize = true;
            this.lab_Space.ForeColor = System.Drawing.Color.White;
            this.lab_Space.Location = new System.Drawing.Point(131, 83);
            this.lab_Space.Name = "lab_Space";
            this.lab_Space.Size = new System.Drawing.Size(138, 20);
            this.lab_Space.TabIndex = 7;
            this.lab_Space.Text = "Available Space: ";
            // 
            // btn_MD5
            // 
            this.btn_MD5.ForeColor = System.Drawing.Color.Black;
            this.btn_MD5.Location = new System.Drawing.Point(483, 80);
            this.btn_MD5.Name = "btn_MD5";
            this.btn_MD5.Size = new System.Drawing.Size(134, 27);
            this.btn_MD5.TabIndex = 8;
            this.btn_MD5.Text = "Generate MD5";
            this.btn_MD5.UseVisualStyleBackColor = true;
            this.btn_MD5.Click += new System.EventHandler(this.btn_MD5_Click);
            // 
            // btn_VerifyFiles
            // 
            this.btn_VerifyFiles.ForeColor = System.Drawing.Color.Black;
            this.btn_VerifyFiles.Location = new System.Drawing.Point(620, 80);
            this.btn_VerifyFiles.Name = "btn_VerifyFiles";
            this.btn_VerifyFiles.Size = new System.Drawing.Size(134, 27);
            this.btn_VerifyFiles.TabIndex = 9;
            this.btn_VerifyFiles.Text = "Verify Files";
            this.btn_VerifyFiles.UseVisualStyleBackColor = true;
            this.btn_VerifyFiles.Click += new System.EventHandler(this.btn_VerifyFiles_Click);
            // 
            // lab_Status
            // 
            this.lab_Status.AutoSize = true;
            this.lab_Status.BackColor = System.Drawing.Color.Transparent;
            this.lab_Status.ForeColor = System.Drawing.Color.White;
            this.lab_Status.Location = new System.Drawing.Point(3, 5);
            this.lab_Status.Name = "lab_Status";
            this.lab_Status.Size = new System.Drawing.Size(202, 20);
            this.lab_Status.TabIndex = 10;
            this.lab_Status.Text = "Status: Ready to Copy Files";
            // 
            // lab_installerName
            // 
            this.lab_installerName.AutoSize = true;
            this.lab_installerName.BackColor = System.Drawing.Color.Transparent;
            this.lab_installerName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_installerName.ForeColor = System.Drawing.Color.White;
            this.lab_installerName.Location = new System.Drawing.Point(14, 13);
            this.lab_installerName.Name = "lab_installerName";
            this.lab_installerName.Size = new System.Drawing.Size(122, 23);
            this.lab_installerName.TabIndex = 11;
            this.lab_installerName.Text = "The Installer ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lab_Space32bit);
            this.groupBox1.Controls.Add(this.btn_BrowseVST64bit);
            this.groupBox1.Controls.Add(this.txt_64FolderPath);
            this.groupBox1.Controls.Add(this.cb_64bit);
            this.groupBox1.Controls.Add(this.cb_32bit);
            this.groupBox1.Controls.Add(this.lab_Space64bit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_BrowseVST32bit);
            this.groupBox1.Controls.Add(this.txt_32FolderPath);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 214);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "64-bit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "32-bit";
            // 
            // lab_Space32bit
            // 
            this.lab_Space32bit.AutoSize = true;
            this.lab_Space32bit.ForeColor = System.Drawing.Color.White;
            this.lab_Space32bit.Location = new System.Drawing.Point(133, 107);
            this.lab_Space32bit.Name = "lab_Space32bit";
            this.lab_Space32bit.Size = new System.Drawing.Size(138, 20);
            this.lab_Space32bit.TabIndex = 25;
            this.lab_Space32bit.Text = "Available Space: ";
            // 
            // btn_BrowseVST64bit
            // 
            this.btn_BrowseVST64bit.Enabled = false;
            this.btn_BrowseVST64bit.ForeColor = System.Drawing.Color.Black;
            this.btn_BrowseVST64bit.Location = new System.Drawing.Point(623, 133);
            this.btn_BrowseVST64bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BrowseVST64bit.Name = "btn_BrowseVST64bit";
            this.btn_BrowseVST64bit.Size = new System.Drawing.Size(131, 27);
            this.btn_BrowseVST64bit.TabIndex = 24;
            this.btn_BrowseVST64bit.Text = "Browse";
            this.btn_BrowseVST64bit.UseVisualStyleBackColor = true;
            this.btn_BrowseVST64bit.Click += new System.EventHandler(this.btn_BrowseVST64bit_Click);
            // 
            // txt_64FolderPath
            // 
            this.txt_64FolderPath.Enabled = false;
            this.txt_64FolderPath.Location = new System.Drawing.Point(135, 134);
            this.txt_64FolderPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_64FolderPath.Name = "txt_64FolderPath";
            this.txt_64FolderPath.Size = new System.Drawing.Size(480, 26);
            this.txt_64FolderPath.TabIndex = 23;
            // 
            // cb_64bit
            // 
            this.cb_64bit.AutoSize = true;
            this.cb_64bit.ForeColor = System.Drawing.Color.White;
            this.cb_64bit.Location = new System.Drawing.Point(210, 26);
            this.cb_64bit.Name = "cb_64bit";
            this.cb_64bit.Size = new System.Drawing.Size(67, 24);
            this.cb_64bit.TabIndex = 22;
            this.cb_64bit.Text = "64-bit";
            this.cb_64bit.UseVisualStyleBackColor = true;
            this.cb_64bit.CheckedChanged += new System.EventHandler(this.cb_64bit_CheckedChanged);
            // 
            // cb_32bit
            // 
            this.cb_32bit.AutoSize = true;
            this.cb_32bit.ForeColor = System.Drawing.Color.White;
            this.cb_32bit.Location = new System.Drawing.Point(137, 26);
            this.cb_32bit.Name = "cb_32bit";
            this.cb_32bit.Size = new System.Drawing.Size(67, 24);
            this.cb_32bit.TabIndex = 21;
            this.cb_32bit.Text = "32-bit";
            this.cb_32bit.UseVisualStyleBackColor = true;
            this.cb_32bit.CheckedChanged += new System.EventHandler(this.cb_32bit_CheckedChanged);
            // 
            // lab_Space64bit
            // 
            this.lab_Space64bit.AutoSize = true;
            this.lab_Space64bit.ForeColor = System.Drawing.Color.White;
            this.lab_Space64bit.Location = new System.Drawing.Point(133, 164);
            this.lab_Space64bit.Name = "lab_Space64bit";
            this.lab_Space64bit.Size = new System.Drawing.Size(138, 20);
            this.lab_Space64bit.TabIndex = 18;
            this.lab_Space64bit.Text = "Available Space: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "VST Folder Path:";
            // 
            // btn_BrowseVST32bit
            // 
            this.btn_BrowseVST32bit.Enabled = false;
            this.btn_BrowseVST32bit.ForeColor = System.Drawing.Color.Black;
            this.btn_BrowseVST32bit.Location = new System.Drawing.Point(623, 77);
            this.btn_BrowseVST32bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BrowseVST32bit.Name = "btn_BrowseVST32bit";
            this.btn_BrowseVST32bit.Size = new System.Drawing.Size(131, 27);
            this.btn_BrowseVST32bit.TabIndex = 16;
            this.btn_BrowseVST32bit.Text = "Browse";
            this.btn_BrowseVST32bit.UseVisualStyleBackColor = true;
            this.btn_BrowseVST32bit.Click += new System.EventHandler(this.btn_BrowseVST_Click);
            // 
            // txt_32FolderPath
            // 
            this.txt_32FolderPath.Enabled = false;
            this.txt_32FolderPath.Location = new System.Drawing.Point(135, 77);
            this.txt_32FolderPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_32FolderPath.Name = "txt_32FolderPath";
            this.txt_32FolderPath.Size = new System.Drawing.Size(480, 26);
            this.txt_32FolderPath.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cb_DefaultFolder);
            this.groupBox2.Controls.Add(this.lab_Space);
            this.groupBox2.Controls.Add(this.txt_DesPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_MD5);
            this.groupBox2.Controls.Add(this.btn_Browse);
            this.groupBox2.Controls.Add(this.btn_VerifyFiles);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 128);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // cb_DefaultFolder
            // 
            this.cb_DefaultFolder.AutoSize = true;
            this.cb_DefaultFolder.ForeColor = System.Drawing.Color.White;
            this.cb_DefaultFolder.Location = new System.Drawing.Point(135, 20);
            this.cb_DefaultFolder.Name = "cb_DefaultFolder";
            this.cb_DefaultFolder.Size = new System.Drawing.Size(130, 24);
            this.cb_DefaultFolder.TabIndex = 10;
            this.cb_DefaultFolder.Text = "Default Folder";
            this.cb_DefaultFolder.UseVisualStyleBackColor = true;
            this.cb_DefaultFolder.CheckedChanged += new System.EventHandler(this.cb_DefaultFolder_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lab_Status);
            this.panel1.Location = new System.Drawing.Point(12, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 34);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_installerName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_DesPath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_Space;
        private System.Windows.Forms.Button btn_MD5;
        private System.Windows.Forms.Button btn_VerifyFiles;
        private System.Windows.Forms.Label lab_Status;
        private System.Windows.Forms.Label lab_installerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BrowseVST32bit;
        private System.Windows.Forms.TextBox txt_32FolderPath;
        private System.Windows.Forms.Label lab_Space64bit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_64bit;
        private System.Windows.Forms.CheckBox cb_32bit;
        private System.Windows.Forms.CheckBox cb_DefaultFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_Space32bit;
        private System.Windows.Forms.Button btn_BrowseVST64bit;
        private System.Windows.Forms.TextBox txt_64FolderPath;
    }
}

