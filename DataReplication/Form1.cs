using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DataReplication
{
    /// <summary>
    /// App.config
    /// Line[0] = installer name 
    /// Line[0] = for paino and Orchestra (1 = Orchesta else Paino)
    /// Line[0] = to change the visiblity of "generate MD5" button (1 = visible else hide)
    /// </summary>
    public partial class Form1 : Form
    {
        string FolderPath = "";
        string FolderPathVST32bit = "";
        string FolderPathVST64bit = "";

        int type = 1;


        string InstrumentsPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Instruments";
        string BanksPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Banks";
        string PresetsPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets";
        string sampleSetPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Instruments";
        string nspPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets";
        string nsbPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Banks";

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

                CopyFiles();
                CopyNspFiles();
                CopyNsbFiles();
                CopyInstruments();
                CopyBanks();
                CopyPresets();
                lab_Status.Text = "Status: Ready to Copy Files";
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
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\nspFiles", nspPath);
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\nspFiles", nspPath, true);
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
                RemoveAlreadyExistFiles(@"" + Application.StartupPath + " \\Plugins\\nsbFiles", nsbPath);
                DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Plugins\\nsbFiles", nsbPath, true);
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
                // for neo orchestra and neo piano 
                string[] lines = File.ReadAllLines(@"" + Application.StartupPath + " \\App.config");
                if (lines[1] == "1") type = 1;
                // for Generate MD5 code button 
                if (lines[2] == "1") btn_MD5.Visible = true;
                else btn_MD5.Visible = false;
              
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to read config file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            try
            {
                Image myimage = new Bitmap(Application.StartupPath + @"\\BackgroundImage.jpg");
                this.BackgroundImage = myimage;
            }
            catch (Exception)
            {

            }
            if (type == 1)
            {
                InstrumentsPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Instruments";
                BanksPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Banks";
                PresetsPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets";
                sampleSetPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Instruments";
                nspPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets";
                nsbPath = @"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Banks";
                this.Text = "Neo Orchestra Installer";
            }
            else
            {
                InstrumentsPath = @"C:\Users\Public\Documents\SoundMagic\Neo_Piano\Instruments";
                BanksPath = @"C:\Users\Public\Documents\SoundMagic\Neo_Piano\Banks";
                PresetsPath = @"C:\Users\Public\Documents\SoundMagic\Neo_Piano\Presets";
                sampleSetPath = @"C:\Users\Public\Documents\SoundMagic\Neo_Piano\Instruments";
                nspPath = @"C:\Users\Public\Documents\SoundMagic\Neo_Piano\Presets";
                nsbPath = @"C:\Users\Public\Documents\SoundMagic\Neo_Piano\Banks";
                this.Text = "Neo Piano Installer";
            }
            try
            {
                ConfigureProperties();
                txt_DesPath.Text = DirectoryModel.CheckDirectory(sampleSetPath);
                if (txt_DesPath.Text == sampleSetPath) cb_DefaultFolder.Checked = true;

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
            string[] configuration = File.ReadAllLines(Application.StartupPath + "\\App.config");
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
    }
}
