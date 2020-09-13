using System;
using System.IO;
using System.Windows.Forms;

namespace DataReplication
{
    public partial class Form1 : Form
    {
        string FolderPath = "";
        string FolderPathVST32bit = "";
        string FolderPathVST64bit = "";

        string InstrumentsPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Instruments";
        string BanksPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Banks";
        string PresetsPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets";
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
                if (cb_32bit.Checked == true)
                {
                    //DirectoryModel.EmptyDir(txt_VSTFolderPath.Text);
                    Copy32bitPlugin();
                }
                if (cb_64bit.Checked == true)
                {
                    //DirectoryModel.EmptyDir(txt_VSTFolderPath.Text);
                    Copy64bitPlugin();
                }
                //if (DirectoryModel.CheckFilesInDir(path))
                //{
                //    DialogResult YorN = MessageBox.Show("Files already exist, do you want to replace all the files?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //    if (YorN == DialogResult.Yes)
                //    {
                //        if (DirectoryModel.EmptyDir(path))
                //        {
                //            CopyFiles();
                //            CopyNspFiles();
                //            CopyNsbFiles();
                //        }
                //    }
                //}
                //else
                //{

                CopyFiles();
                CopyNspFiles();
                CopyNsbFiles();
                CopyInstruments();
                CopyBanks();
                CopyPresets();
                lab_Status.Text = "Status: Ready to Copy Files";

                //                }
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
            RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\SampleSets", txt_DesPath.Text);

            DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\SampleSets", txt_DesPath.Text, true);
            this.Cursor = Cursors.Default;
            lab_Status.Text = "Status: Ready to Copy Files";
            MessageBox.Show("Files copied successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Copy32bitPlugin()
        {
            this.Cursor = Cursors.WaitCursor;
            lab_Status.Text = "Status: Copying 32 bit plugin...";
            panel1.Refresh();
            RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\32 bit", txt_32FolderPath.Text);
            DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\32 bit", txt_32FolderPath.Text, true);
            this.Cursor = Cursors.Default;
            lab_Status.Text = "Status: Ready to Copy Files";
        }
        private void Copy64bitPlugin()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lab_Status.Text = "Status: Copying 64 bit plugin...";
                panel1.Refresh();
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\64 bit", txt_64FolderPath.Text);
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\64 bit", txt_64FolderPath.Text, true);
                this.Cursor = Cursors.Default;
                lab_Status.Text = "Status: Ready to Copy Files";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CopyInstruments()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lab_Status.Text = "Status: Copying Instruments...";
                panel1.Refresh();
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\Instruments", InstrumentsPath);
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\Instruments", InstrumentsPath, true);
                this.Cursor = Cursors.Default;
                lab_Status.Text = "Status: Ready to Copy Files";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CopyBanks()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lab_Status.Text = "Status: Copying Banks...";
                panel1.Refresh();
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\Banks", BanksPath);
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\Banks", BanksPath, true);
                this.Cursor = Cursors.Default;
                lab_Status.Text = "Status: Ready to Copy Files";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CopyPresets()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lab_Status.Text = "Status: Copying Presets...";
                panel1.Refresh();
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\Presets", PresetsPath);
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\Presets", PresetsPath, true);
                this.Cursor = Cursors.Default;
                lab_Status.Text = "Status: Ready to Copy Files";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemoveAlreadyExistFiles(string sourcePath, string desPath)
        {
            // get files names of source folder
            DirectoryInfo dir = new DirectoryInfo(sourcePath);
            FileInfo[] files = dir.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                string Path = files[i].ToString();
                Path = Path.Substring(Path.LastIndexOf('\\') + 1);
                if (File.Exists(desPath + "\\" + Path))
                {
                    File.Delete(desPath + "\\" + Path);
                }
            }
        }

        private void CopyNspFiles()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lab_Status.Text = "Status: Copying .nsp files...";
                panel1.Refresh();
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\nspFiles", @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets");
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\nspFiles", @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets", true);
                this.Cursor = Cursors.Default;
                lab_Status.Text = "Status: Ready to Copy Files";

            }
            catch (Exception)
            {
                lab_Status.Text = "Status: .nsp Files Already Exists";
                this.Cursor = Cursors.Default;
            }
        }
        private void CopyNsbFiles()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lab_Status.Text = "Status: Copying .nsp files...";
                panel1.Refresh();
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\nsbFiles", @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Banks");
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\nsbFiles", @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Banks", true);
                this.Cursor = Cursors.Default;
                lab_Status.Text = "Status: Ready to Copy Files";

            }
            catch (Exception)
            {
                lab_Status.Text = "Status: .nsb Files Already Exists";
                this.Cursor = Cursors.Default;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureProperties();
                txt_DesPath.Text = DirectoryModel.CheckDirectory(@"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Instruments");
                if (txt_DesPath.Text == @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Instruments") cb_DefaultFolder.Checked = true;

                txt_32FolderPath.Text = DirectoryModel.CheckDirectory(@"C:\Program Files\Steinberg\VSTPlugins");
                txt_64FolderPath.Text = DirectoryModel.CheckDirectory(@"C:\Program Files\Steinberg\VSTPlugins");

                lab_Space.Text = DirectoryModel.displayAvailableSpace(txt_DesPath.Text);
                lab_Space32bit.Text = DirectoryModel.displayAvailableSpace(txt_32FolderPath.Text);
                lab_Space64bit.Text = DirectoryModel.displayAvailableSpace(txt_64FolderPath.Text);

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
                        FolderPathVST32bit = fbd.SelectedPath;
                    }
                }
                txt_32FolderPath.Text = FolderPathVST32bit;
                lab_Space32bit.Text = DirectoryModel.displayAvailableSpace(txt_32FolderPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_DefaultFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_DefaultFolder.Checked)
            {
                txt_DesPath.ReadOnly = true;
                btn_Browse.Enabled = false;
            }
            else
            {
                txt_DesPath.ReadOnly = false;
                btn_Browse.Enabled = true;
            }
        }
        private void CheckVSTFolder()
        {
            if (cb_32bit.Checked == true)
            {
                txt_32FolderPath.Enabled = true;
                btn_BrowseVST32bit.Enabled = true;
            }
            else
            {
                txt_32FolderPath.Enabled = false;
                btn_BrowseVST32bit.Enabled = false;
            }
            if (cb_64bit.Checked == true)
            {
                txt_64FolderPath.Enabled = true;
                btn_BrowseVST64bit.Enabled = true;
            }
            else
            {
                txt_64FolderPath.Enabled = false;
                btn_BrowseVST64bit.Enabled = false;
            }
        }
        private void cb_32bit_CheckedChanged(object sender, EventArgs e)
        {
            CheckVSTFolder();
        }

        private void cb_64bit_CheckedChanged(object sender, EventArgs e)
        {
            CheckVSTFolder();
        }

        private void btn_BrowseVST64bit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        FolderPathVST64bit = fbd.SelectedPath;
                    }
                }
                txt_64FolderPath.Text = FolderPathVST64bit;
                lab_Space64bit.Text = DirectoryModel.displayAvailableSpace(txt_64FolderPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
    }
}
