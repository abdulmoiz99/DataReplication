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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BrowseVST = new System.Windows.Forms.Button();
            this.txt_VSTFolderPath = new System.Windows.Forms.TextBox();
            this.lab_VSTSpace = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo_32bit = new System.Windows.Forms.RadioButton();
            this.rdo_64bit = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_DesPath
            // 
            this.txt_DesPath.Location = new System.Drawing.Point(162, 26);
            this.txt_DesPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DesPath.Name = "txt_DesPath";
            this.txt_DesPath.Size = new System.Drawing.Size(598, 26);
            this.txt_DesPath.TabIndex = 2;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(766, 22);
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
            this.btn_Copy.Location = new System.Drawing.Point(778, 315);
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
            this.label1.Location = new System.Drawing.Point(108, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path: ";
            // 
            // lab_Space
            // 
            this.lab_Space.AutoSize = true;
            this.lab_Space.Location = new System.Drawing.Point(158, 58);
            this.lab_Space.Name = "lab_Space";
            this.lab_Space.Size = new System.Drawing.Size(138, 20);
            this.lab_Space.TabIndex = 7;
            this.lab_Space.Text = "Available Space: ";
            // 
            // btn_MD5
            // 
            this.btn_MD5.Location = new System.Drawing.Point(626, 59);
            this.btn_MD5.Name = "btn_MD5";
            this.btn_MD5.Size = new System.Drawing.Size(134, 29);
            this.btn_MD5.TabIndex = 8;
            this.btn_MD5.Text = "Generate MD5";
            this.btn_MD5.UseVisualStyleBackColor = true;
            this.btn_MD5.Click += new System.EventHandler(this.btn_MD5_Click);
            // 
            // btn_VerifyFiles
            // 
            this.btn_VerifyFiles.Location = new System.Drawing.Point(766, 58);
            this.btn_VerifyFiles.Name = "btn_VerifyFiles";
            this.btn_VerifyFiles.Size = new System.Drawing.Size(134, 29);
            this.btn_VerifyFiles.TabIndex = 9;
            this.btn_VerifyFiles.Text = "Verify Files";
            this.btn_VerifyFiles.UseVisualStyleBackColor = true;
            this.btn_VerifyFiles.Click += new System.EventHandler(this.btn_VerifyFiles_Click);
            // 
            // lab_Status
            // 
            this.lab_Status.AutoSize = true;
            this.lab_Status.Location = new System.Drawing.Point(3, 5);
            this.lab_Status.Name = "lab_Status";
            this.lab_Status.Size = new System.Drawing.Size(202, 20);
            this.lab_Status.TabIndex = 10;
            this.lab_Status.Text = "Status: Ready to Copy Files";
            // 
            // lab_installerName
            // 
            this.lab_installerName.AutoSize = true;
            this.lab_installerName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_installerName.Location = new System.Drawing.Point(14, 13);
            this.lab_installerName.Name = "lab_installerName";
            this.lab_installerName.Size = new System.Drawing.Size(122, 23);
            this.lab_installerName.TabIndex = 11;
            this.lab_installerName.Text = "The Installer ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_64bit);
            this.groupBox1.Controls.Add(this.rdo_32bit);
            this.groupBox1.Controls.Add(this.lab_VSTSpace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_BrowseVST);
            this.groupBox1.Controls.Add(this.txt_VSTFolderPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 156);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "VST Folder Path:";
            // 
            // btn_BrowseVST
            // 
            this.btn_BrowseVST.Location = new System.Drawing.Point(770, 55);
            this.btn_BrowseVST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BrowseVST.Name = "btn_BrowseVST";
            this.btn_BrowseVST.Size = new System.Drawing.Size(134, 27);
            this.btn_BrowseVST.TabIndex = 16;
            this.btn_BrowseVST.Text = "Browse";
            this.btn_BrowseVST.UseVisualStyleBackColor = true;
            this.btn_BrowseVST.Click += new System.EventHandler(this.btn_BrowseVST_Click);
            // 
            // txt_VSTFolderPath
            // 
            this.txt_VSTFolderPath.Location = new System.Drawing.Point(162, 56);
            this.txt_VSTFolderPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_VSTFolderPath.Name = "txt_VSTFolderPath";
            this.txt_VSTFolderPath.Size = new System.Drawing.Size(598, 26);
            this.txt_VSTFolderPath.TabIndex = 15;
            // 
            // lab_VSTSpace
            // 
            this.lab_VSTSpace.AutoSize = true;
            this.lab_VSTSpace.Location = new System.Drawing.Point(158, 91);
            this.lab_VSTSpace.Name = "lab_VSTSpace";
            this.lab_VSTSpace.Size = new System.Drawing.Size(138, 20);
            this.lab_VSTSpace.TabIndex = 18;
            this.lab_VSTSpace.Text = "Available Space: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_Space);
            this.groupBox2.Controls.Add(this.txt_DesPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_MD5);
            this.groupBox2.Controls.Add(this.btn_Browse);
            this.groupBox2.Controls.Add(this.btn_VerifyFiles);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 103);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_Status);
            this.panel1.Location = new System.Drawing.Point(12, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 34);
            this.panel1.TabIndex = 11;
            // 
            // rdo_32bit
            // 
            this.rdo_32bit.AutoSize = true;
            this.rdo_32bit.Location = new System.Drawing.Point(162, 26);
            this.rdo_32bit.Name = "rdo_32bit";
            this.rdo_32bit.Size = new System.Drawing.Size(66, 24);
            this.rdo_32bit.TabIndex = 19;
            this.rdo_32bit.TabStop = true;
            this.rdo_32bit.Text = "32-bit";
            this.rdo_32bit.UseVisualStyleBackColor = true;
            // 
            // rdo_64bit
            // 
            this.rdo_64bit.AutoSize = true;
            this.rdo_64bit.Location = new System.Drawing.Point(234, 26);
            this.rdo_64bit.Name = "rdo_64bit";
            this.rdo_64bit.Size = new System.Drawing.Size(66, 24);
            this.rdo_64bit.TabIndex = 20;
            this.rdo_64bit.TabStop = true;
            this.rdo_64bit.Text = "64-bit";
            this.rdo_64bit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_installerName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer";
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
        private System.Windows.Forms.Button btn_BrowseVST;
        private System.Windows.Forms.TextBox txt_VSTFolderPath;
        private System.Windows.Forms.Label lab_VSTSpace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdo_64bit;
        private System.Windows.Forms.RadioButton rdo_32bit;
    }
}

