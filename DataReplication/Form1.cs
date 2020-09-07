using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace DataReplication
{
    public partial class Form1 : Form
    {
        string FolderPath = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        FolderPath = fbd.SelectedPath;
                    }
                }
                txt_DesPath.Text = FolderPath;
                lab_Space.Text = DirectoryModel.displayAvailableSpace(txt_DesPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Copy_Click(object sender, EventArgs e)
        {

            try
            {
                string path = txt_DesPath.Text;

                if (DirectoryModel.CheckFilesInDir(path))
                {
                    DialogResult YorN = MessageBox.Show("Files already exist, do you want to replace all the files?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (YorN == DialogResult.Yes)
                    {
                        if (DirectoryModel.EmptyDir(path))
                        {
                            CopyFiles();
                        }
                    }
                }
                else
                {
                     CopyFiles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CopyFiles()
        {
            this.Cursor = Cursors.WaitCursor;
            lab_Status.Text = "Status: Copying Files...";
            System.Threading.Thread.Sleep(500);
            DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Shared", txt_DesPath.Text, true);
            lab_Status.Text = "Status: Ready to Copy Files";
            this.Cursor = Cursors.Default;
            MessageBox.Show("Files copied successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureProperties();
                txt_DesPath.Text = DirectoryModel.CheckDirectory(@"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets");
                lab_Space.Text = DirectoryModel.displayAvailableSpace(txt_DesPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigureProperties()
        {
            string[] configuration = File.ReadAllLines(Application.StartupPath + "\\DataReplication.config");
            string productName = configuration[0].Substring(configuration[0].IndexOf('=') + 1);
            lab_installerName.Text = "The Installer for " + productName;
        }

        private void btn_MD5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Md5.GenerateMd5(@"" + Application.StartupPath + " \\Shared");
            this.Cursor = Cursors.Default;
        }

        private void btn_VerifyFiles_Click(object sender, EventArgs e)
        {
            string path = txt_DesPath.Text;
            this.Cursor = Cursors.WaitCursor;

            if (Md5.ComapreMd5(path))
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Verification Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Files are encrypted or missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CopyFiles();
        }
    }
}
