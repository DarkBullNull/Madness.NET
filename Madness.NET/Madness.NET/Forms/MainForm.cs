using MetroSuite;
using MetroSuite.Extension.Styles.Themes;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MadnessNET.Assembly;

namespace MadnessNET
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            MetroSteamTheme metroSteamTheme = new MetroSteamTheme();
            metroSteamTheme.ApplyTheme(this);
            
        }

        private string extension;
        private string outputFile;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel_DaD_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                label_DaD_info.Text = "Pooooooff!";
                e.Effect = DragDropEffects.Copy;
                Graphics graphics_DaD = panel_DaD.CreateGraphics();
                Pen pen = new Pen(Color.DarkGoldenrod, 2f);
                pen.DashPattern = new float[] { 5, 1 };
                graphics_DaD.DrawRectangle(pen, 0, 0, panel_DaD.Width, panel_DaD.Height);
            }
        }

        private void panel_DaD_DragLeave(object sender, EventArgs e)
        {
            label_DaD_info.Text = "Push Me";
            Graphics graphics_DaD = panel_DaD.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2f);
            pen.DashPattern = new float[] { 5, 1 };
            graphics_DaD.DrawRectangle(pen, 0, 0, panel_DaD.Width, panel_DaD.Height);
        }

        private void panel_DaD_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileDirectory = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileDirectory.Length > 1)
            {
                MessageBox.Show("Only 1 file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label_DaD_info.Text = "Bad!";
            }
                
            else
            {
                textBox_filePath.Text = fileDirectory[0];
                if (CheckAssembly.IsValidAssembly(textBox_filePath.Text))
                {
                    label_DaD_info.Text = "Good!";
                    extension = Path.GetExtension(fileDirectory[0]);
                    textbox_outputPath.Text = Path.GetDirectoryName(fileDirectory[0])
                                              + "\\"
                                              + Path.GetFileNameWithoutExtension(fileDirectory[0])
                                              + "_MADNESS"
                                              + extension;
                }
                else
                {
                    label_DaD_info.Text = "Bad!";
                    textBox_filePath.Text = "Invalid file...";
                }
            }
        }

        private void button_loadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Exe files (*.exe)|*.exe|Dll files (*.dll)|*.dll";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK && CheckAssembly.IsValidAssembly(openFileDialog.FileName))
                {
                    extension = 
                        openFileDialog
                        .SafeFileName
                        .Substring(openFileDialog.SafeFileName.Length - 4, 4);
                    outputFile = 
                        openFileDialog
                        .FileName
                        .Substring(0, openFileDialog.FileName.Length - 4)
                        + "_MADNESS"
                        + extension;
                    label_DaD_info.Text = "Good";
                    textBox_filePath.Text = openFileDialog.FileName;
                    textbox_outputPath.Text = outputFile;
                }
                else
                {
                    textBox_filePath.Text = "Invalid file...";
                    label_DaD_info.Text = "Bad!";
                }
            }
        }

        private async void Form1_Paint(object sender, PaintEventArgs e)
        {

            await Task.Delay(100);
            Graphics graphics_DaD = panel_DaD.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2f);
            Pen pen_total = new Pen(Color.Red, 2f);
            pen.DashPattern = new float[] { 5, 1 };
            graphics_DaD.DrawRectangle(pen, 0, 0, panel_DaD.Width, panel_DaD.Height);
            Graphics graphics_total = panel_total.CreateGraphics();
            graphics_total.DrawRectangle(pen_total, 0, 0, panel_total.Width, panel_total.Height);

        }

        private void button_protect_Click(object sender, EventArgs e)
        {
            
            if (checkBox_stringEncrypt.Checked)
            {
                StringEncrypt stringEncrypt = new StringEncrypt(textBox_filePath.Text);
            }
        }
    }

    
}
