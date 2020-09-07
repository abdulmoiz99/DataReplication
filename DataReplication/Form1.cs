using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace DataReplication
{
    public partial class Form1 : Form
    {
        string FolderPath = "";
        string FolderPathVST = "";

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
                if (rdo_32bit.Checked==true)
                {
                   // DirectoryModel.EmptyDir(txt_VSTFolderPath.Text);
                    Copy32bitPlugin();
                }
                else if (rdo_64bit.Checked==true)
                {
                   // DirectoryModel.EmptyDir(txt_VSTFolderPath.Text);
                    Copy64bitPlugin();
                }
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
            panel1.Refresh();
            DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Shared", txt_DesPath.Text, true);
            this.Cursor = Cursors.Default;
            lab_Status.Text = "Status: Ready to Copy Files";
            MessageBox.Show("Files copied successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Copy32bitPlugin()
        {
            this.Cursor = Cursors.WaitCursor;
            lab_Status.Text = "Status: Copying 32 bit plugin...";
            panel1.Refresh();
            DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\32 bit", txt_VSTFolderPath.Text, true);
            this.Cursor = Cursors.Default;
            lab_Status.Text = "Status: Ready to Copy Files";
        }
        private void Copy64bitPlugin()
        {
            this.Cursor = Cursors.WaitCursor;
            lab_Status.Text = "Status: Copying 64 bit plugin...";
            panel1.Refresh();
            DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\64 bit", txt_VSTFolderPath.Text, true);
            this.Cursor = Cursors.Default;
            lab_Status.Text = "Status: Ready to Copy Files";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureProperties();
                txt_DesPath.Text = DirectoryModel.CheckDirectory(@"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets");
                txt_VSTFolderPath.Text = DirectoryModel.CheckDirectory(@"C:\Program Files\Steinberg\VSTPlugins");
                lab_Space.Text = DirectoryModel.displayAvailableSpace(txt_DesPath.Text);
                lab_VSTSpace.Text = DirectoryModel.displayAvailableSpace(txt_VSTFolderPath.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigureProperties()
        {
            string[] configuration = File.ReadAllLines(Application.StartupPath + "\\DataReplication.config");
            string InstallerName = configuration[0];
            lab_installerName.Text = InstallerName;
        }

        private void btn_MD5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Cursor = Cursors.WaitCursor;
            lab_Status.Text = "Status: Generating Md5...";
            panel1.Refresh();
            Md5.GenerateMd5(@"" + Application.StartupPath + " \\Shared");
            this.Cursor = Cursors.Default;
            lab_Status.Text = "Status: Ready to Copy Files";

        }

        private void btn_VerifyFiles_Click(object sender, EventArgs e)
        {
            string path = txt_DesPath.Text;
            this.Cursor = Cursors.WaitCursor;
            lab_Status.Text = "Status: Verifying Files...";
            panel1.Refresh();
            if (Md5.ComapreMd5(path))
            {
                this.Cursor = Cursors.Default;
                
                MessageBox.Show("Verification Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Files are encrypted or missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
            lab_Status.Text = "Status: Ready to Copy Files";

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CopyFiles();
        }
        private void btn_BrowseVST_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        FolderPathVST = fbd.SelectedPath;
                    }
                }
                txt_VSTFolderPath.Text = FolderPathVST;
                lab_VSTSpace.Text = DirectoryModel.displayAvailableSpace(txt_VSTFolderPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
