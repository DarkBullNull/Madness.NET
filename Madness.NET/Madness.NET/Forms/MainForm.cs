using dnlib.DotNet;
using MadnessNET.Assembly;
using MadnessNET.Forms;
using MetroSuite;
using MetroSuite.Extension.Styles.Themes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet.Writer;
using MadnessNET.Assembly.AntiDe4dot;
using MadnessNET.ConsoleWriting;
using MethodAttributes = System.Reflection.MethodAttributes;
using MethodBody = System.Reflection.MethodBody;
using OpCodeType = dnlib.DotNet.Emit.OpCodeType;
using TypeAttributes = System.Reflection.TypeAttributes;

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

        public static ModuleDef moduleDef;


        MethodsListForm methodsListForm = new MethodsListForm();
        RenamerForm renamerForm = new RenamerForm();
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
                    moduleDef = ModuleDefMD.Load(textBox_filePath.Text);
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
                    moduleDef = ModuleDefMD.Load(textBox_filePath.Text);

                }
                else
                {
                    textBox_filePath.Text = "Invalid file...";
                    label_DaD_info.Text = "Bad!";
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private async void MainForm_Paint(object sender, PaintEventArgs e)
        {
            
            await Task.Delay(100);
            Graphics graphics_DaD = panel_DaD.CreateGraphics();
            Graphics graphics_total = panel_total.CreateGraphics();
            Graphics graphics_panel_other = panel_other.CreateGraphics();
            Pen pen_DnD = new Pen(Color.Red, 2f);
            Pen pen_panel_total = new Pen(Color.Red, 2f);
            Pen pen_panel_other = new Pen(Color.Red, 2f);
            pen_DnD.DashPattern = new float[] { 5, 1 };
            graphics_DaD.DrawRectangle(pen_DnD, 0, 0, panel_DaD.Width, panel_DaD.Height);
            graphics_total.DrawRectangle(pen_panel_total, 0, 0, panel_total.Width, panel_total.Height);
            graphics_panel_other.DrawRectangle(pen_panel_other, 0, 0, panel_other.Width, panel_other.Height);
        }

        private void button_protect_Click(object sender, EventArgs e)
        {
            try
            {

                Console.Clear();
                Greeting greeting = new Greeting();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                ModuleWriterOptions Options = null;
                if (checkBox_stringEncrypt.Checked)
                {
                    Console.Write("String obfuscating... ");
                    StringEncrypt stringEncrypt = new StringEncrypt(ref moduleDef);
                    Console.Write("OK!\n");
                }

                if (checkBox_Renamer.Checked && renamerForm.AssemblyName != String.Empty)
                {
                    Console.Write("Renaming assembly...");
                    Renamer renamer = new Renamer(ref moduleDef, renamerForm.AssemblyName, renamerForm.ModuleName);
                    Console.Write("OK!\n");
                }

                if (checkBox_AntiDe4dot.Checked)
                {
                    Console.Write("AntiDe4dot init...");
                    Anti_De4dot antiDe4dot = new Anti_De4dot();
                    Options = antiDe4dot.AntiDe4dotInit(ref moduleDef);
                    Console.Write("OK!\n");
                }

                if (checkbox_antiILSpy.Checked)
                {
                    MethodDef[] userMethods = methodsListForm.listBox_selectedMethods.Items.Cast<MethodDef>().ToArray();
                    AntiILSpy antiIlSpy = new AntiILSpy(ref moduleDef, userMethods);
                    
                }
                var writerOptions = new dnlib.DotNet.Writer.ModuleWriterOptions(moduleDef);
                writerOptions.Logger = DummyLogger.NoThrowInstance;
                Console.Write("Saving assembly...");
                moduleDef.Write(Path.GetDirectoryName(textBox_filePath.Text) + "\\" +
                                Path.GetFileNameWithoutExtension(textBox_filePath.Text) + "_MADNESS" +
                                Path.GetExtension(textBox_filePath.Text), writerOptions);
                Console.Write("OK!\n");
                methodsListForm.Close();
            }
            catch (System.IO.IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label_renamer_Click(object sender, EventArgs e)
        {
            renamerForm.Show();
        }

        private void label_antiILSpy_Click(object sender, EventArgs e)
        {
            if (moduleDef != null && textBox_filePath.Text != "Invalid file...")
            {
                methodsListForm.Show();
            }
            else
            {
                MessageBox.Show("Select file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
