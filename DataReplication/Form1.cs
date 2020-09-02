using System;
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
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    FolderPath = fbd.SelectedPath;
                }
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            txt_DesPath.SelectionLength = 0;


            DirectoryModel.DirectoryCopy(@"" + Application.StartupPath + " \\Shared", txt_DesPath.Text, true);
            MessageBox.Show("Files copied successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            txt_DesPath.Text = DirectoryModel.CheckDirectory(@"C:\Users\Public\Documents\SoundMagic\NeoOrchestra\Presets");
            lab_Space.Text = DirectoryModel.displayAvailableSpace(txt_DesPath.Text);

        }
    }
    static class DirectoryModel
    {
        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                if (File.Exists(temppath))
                {

                }
                else
                {
                    file.CopyTo(temppath, false);

                }


            }
            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
        public static string displayAvailableSpace(string path)
        {
            if (Directory.Exists(path))
            {
                string driveName = path.Substring(0, 3);
                return "Available Space: " + FormatBytes(GetTotalFreeSpace(driveName));
            }
            else return "Available Space:";
        }
        public static string CheckDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                return path;
            }
            else return string.Empty;
        }
        private static long GetTotalFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.TotalFreeSpace;
                }
            }
            return -1;
        }
    }
}
