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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_Space = new System.Windows.Forms.Label();
            this.btn_MD5 = new System.Windows.Forms.Button();
            this.btn_VerifyFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DesPath
            // 
            this.txt_DesPath.Location = new System.Drawing.Point(68, 21);
            this.txt_DesPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DesPath.Name = "txt_DesPath";
            this.txt_DesPath.Size = new System.Drawing.Size(642, 26);
            this.txt_DesPath.TabIndex = 2;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(716, 21);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(97, 27);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(819, 21);
            this.btn_Copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(97, 27);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 298);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // lab_Space
            // 
            this.lab_Space.AutoSize = true;
            this.lab_Space.Location = new System.Drawing.Point(70, 51);
            this.lab_Space.Name = "lab_Space";
            this.lab_Space.Size = new System.Drawing.Size(138, 20);
            this.lab_Space.TabIndex = 7;
            this.lab_Space.Text = "Available Space: ";
            // 
            // btn_MD5
            // 
            this.btn_MD5.Location = new System.Drawing.Point(716, 90);
            this.btn_MD5.Name = "btn_MD5";
            this.btn_MD5.Size = new System.Drawing.Size(200, 29);
            this.btn_MD5.TabIndex = 8;
            this.btn_MD5.Text = "Generate MD5";
            this.btn_MD5.UseVisualStyleBackColor = true;
            this.btn_MD5.Click += new System.EventHandler(this.btn_MD5_Click);
            // 
            // btn_VerifyFiles
            // 
            this.btn_VerifyFiles.Location = new System.Drawing.Point(716, 55);
            this.btn_VerifyFiles.Name = "btn_VerifyFiles";
            this.btn_VerifyFiles.Size = new System.Drawing.Size(200, 29);
            this.btn_VerifyFiles.TabIndex = 9;
            this.btn_VerifyFiles.Text = "Verify Files";
            this.btn_VerifyFiles.UseVisualStyleBackColor = true;
            this.btn_VerifyFiles.Click += new System.EventHandler(this.btn_VerifyFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 435);
            this.Controls.Add(this.btn_VerifyFiles);
            this.Controls.Add(this.btn_MD5);
            this.Controls.Add(this.lab_Space);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txt_DesPath);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_DesPath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lab_Space;
        private System.Windows.Forms.Button btn_MD5;
        private System.Windows.Forms.Button btn_VerifyFiles;
    }
}

