using Ionic.Zip;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Installer
{
    public partial class Form1 : Form
    {
        private static string installName = "Installer";
        private static string installTitle = "Game Lan Edition Installer";
        private static string gameFolder = @"\GameName";
        private static string installPath = @"D:\temp" + gameFolder;

        private static string configFile = "installer.ini";
        private static string splashImage = "splash.png";
        private string dataZipFilePath = "data.zip";


        private System.Threading.Thread extractThread = null;
        private int entriesExtracted = 0;

        public Form1()
        {
            InitializeComponent();
            readConfig();
            installPath = installPath + gameFolder;
            Text = installName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            buttonFinish.Visible = false;
            labelTitle.Text = installTitle;
            labelTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            if (FileExists(splashImage))
                pictureBoxSplash.Image = Image.FromFile(splashImage);
            textBoxFolder.Text = installPath;
        }

        private void readConfig()
        {
            if (File.Exists(configFile))
            {
                try
                {
                    string[] lines = File.ReadAllLines(configFile);
                    foreach (var line in lines)
                    {
                        var keyValue = line.Split('=');
                        if (keyValue.Length == 2)
                        {
                            string key = keyValue[0].Trim();
                            string value = keyValue[1].Trim();

                            if (key.Equals("installTitle", StringComparison.OrdinalIgnoreCase))
                            {
                                installTitle = value;
                            }
                            else if (key.Equals("gameFolder", StringComparison.OrdinalIgnoreCase))
                            {
                                gameFolder = value;
                            }
                            else if (key.Equals("installPath", StringComparison.OrdinalIgnoreCase))
                            {
                                installPath = value;
                            }
                            else if (key.Equals("installName", StringComparison.OrdinalIgnoreCase))
                            {
                                installName = value;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Config file not found.");
            }
        }

        private bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public void extractZip(string zipFilePath, string extractPath)
        {
            buttonInstall.Invoke(new Action(() =>
            {
                buttonInstall.Visible = false;
                buttonFolder.Visible = false;
            }));
            DialogResult? result = null;
            if (Directory.Exists(extractPath))
            {
                result = MessageBox.Show("The folder already exists." +
                                         "\nOverride folder and its contents?",
                                         installTitle,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Warning);
            }
            if (FileExists(zipFilePath) && (result == null || result == DialogResult.OK))
            {
                this.Invoke(new Action(() =>
                {
                    progressBar1.Visible = true;
                    textBoxFolder.Visible = false;
                    label1.Text = "Extracting ...";
                }));
                using (ZipFile zip = ZipFile.Read(zipFilePath))
                {
                    // Initialize progress bar
                    this.Invoke(new Action(() =>
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = zip.Entries.Count;
                        progressBar1.Value = 0;
                    }));
                    // Attach the progress event handler
                    zip.ExtractProgress += Zip_ExtractProgressHandler;
                    // Extract all files
                    zip.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);
                }

            }
            else
            {
                this.Invoke(new Action(() =>
                {
                    progressBar1.Visible = false;
                    textBoxFolder.Visible = true;
                    label1.Text = "Install folder:";
                    buttonInstall.Visible = true;
                    buttonFolder.Visible = true;
                }));
            }
        }

        private void Zip_ExtractProgressHandler(object sender, ExtractProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Extracting_AfterExtractEntry)
            {
                // Increment the count of extracted entries
                entriesExtracted++;

                // Update the progress bar value for each completed entry
                progressBar1.Invoke(new Action(() =>
                {
                    if (progressBar1.Value < progressBar1.Maximum)
                    {
                        progressBar1.Value = entriesExtracted;
                    }
                }));

                // Update the progress bar value for each completed entry
                this.Invoke(new Action(() =>
                {
                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        progressBar1.Visible = false;
                        textBoxFolder.Visible = false;
                        label1.Text = "Completed";
                        buttonFinish.Visible = true;
                        buttonFinish.Focus();
                        buttonInstall.Visible = false;
                        buttonFolder.Visible = false;
                    }
                }));
            }
        }

        private void refresh()
        {
            installPath = textBoxFolder.Text;
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    installPath = folderDialog.SelectedPath + @"\" + gameFolder;
                    refresh();
                }
            }
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            refresh();
            extractThread = new System.Threading.Thread(() => extractZip(dataZipFilePath, installPath));
            extractThread.Start();
        }

        private void textBoxFolder_KeyDown(object sender, KeyEventArgs e)
        {
            //on enter key run the install
            if (e.KeyCode == Keys.Enter)
            {
                buttonInstall_Click(sender, e);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (extractThread != null)
                extractThread.Abort();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
