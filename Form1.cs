using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll",CharSet=CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        string targetDir= @"D:\Spotlight_Wallpapers";
        int imageNumber = 1;
 
        public Form1()
        {
            InitializeComponent();
            textBox_loc.Enabled = false;
            textBox_loc.Text = "Default location";
            browse_button.Enabled = false;
            logHandler.Text = "============LOGS============\n";
            logHandler.Text += ">Default Location = D://Spotlight_Wallpapers\n\n";
            logHandler.Text += ">WARNING-All Files will be removed from the selected directory\n\n";

            button_wpsetter.Enabled = false;
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

        }

        private void LoadNextImage(string currentDir)
        {

            DirectoryInfo d = new DirectoryInfo(currentDir);
            FileInfo[] files = d.GetFiles();
            int len = files.Length;
            if (imageNumber > (len))
            {
                imageNumber = 1;
            }
            imgPicture.ImageLocation = string.Format(currentDir+@"\{0}.jpg", imageNumber);
            imageNumber++;
            
        }
        private void SetWallpaper(string WallpaperLocation, int WallpaperStyle, int TileWallpaper)
        {
            SystemParametersInfo(20, 0, WallpaperLocation, 0x01 | 0x02);
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            rkWallPaper.SetValue("WallpaperStyle", WallpaperStyle);
            rkWallPaper.SetValue("TileWallpaper", TileWallpaper);
            rkWallPaper.Close();
            logHandler.Text += ">Wallpaper Set\n";
        }
        private void ChangeExtension(string currentDir)
        {

            DirectoryInfo d = new DirectoryInfo(currentDir);
            FileInfo[] files = d.GetFiles();
            foreach (FileInfo file in files)
            {
               
                if (File.Exists(file.FullName + ".jpg"))
                {
                    File.Delete(file.FullName);
                }
                else
                    File.Move(file.FullName, Path.ChangeExtension(file.FullName, ".jpg"));
            }
            logHandler.Text += ">Files Changed to .Jpg\n";
        }

        private void CopyFiles(string sourceDir, string targetDir)
        {
                DirectoryInfo d = new DirectoryInfo(targetDir);
                FileInfo[] files = d.GetFiles();
                foreach (FileInfo file in files)
                {
                    File.Delete(file.FullName);
                }
                logHandler.Text += ">Old Files Removed\n";
                foreach (var file in Directory.GetFiles(sourceDir))
                    File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);
                logHandler.Text += ">New Files Copied\n";
        }
        private void RenameFiles(string currentDir)
        {
            DirectoryInfo d = new DirectoryInfo(currentDir);

            FileInfo[] files = d.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Length < 409600)
                {
                    file.Delete();
                }
            }

            files = d.GetFiles();
            int count = 0;
            string newname = "";
            foreach (FileInfo file in files)
            {
                count++;
                newname = count.ToString();
                File.Move(file.FullName, currentDir + @"\" + newname + ".jpg");
            }
            count = 0;
            logHandler.Text += ">Files Renamed\n";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_loc.Checked == false)
            {
                textBox_loc.Text = "Default Location";
                browse_button.Enabled = false;
            }
            else
            {
                textBox_loc.Text = "Choose Your Download Location";
                browse_button.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            choosefolder();
        }

        private void choosefolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_loc.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void download_button_Click(object sender, EventArgs e)
        {
            try
            {
                string localappdata = Environment.GetEnvironmentVariable("LocalAppData");
                string sourceTemp = @"\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
                string sourceDir = localappdata + sourceTemp;

                if(checkBox_loc.Checked==true)
                    targetDir = folderBrowserDialog1.SelectedPath;
                else
                    targetDir = @"D:\Spotlight_Wallpapers";
                CopyFiles(sourceDir, targetDir);    //Files retrieved from localappdata
                ChangeExtension(targetDir); //changing extension to jpg
                RenameFiles(targetDir); //renaming files
            }
            catch (Exception exe)
            {
                logHandler.Text += exe.Message;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_wpsetter.Enabled = true;
            LoadNextImage(targetDir);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spoty Wallpapers 0.1 \nBy-Amit Phulera & Manthan Jamdagni");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetWallpaper(@"D:\Spotlight_Wallpapers\"+(imageNumber-1)+".jpg",2,0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
