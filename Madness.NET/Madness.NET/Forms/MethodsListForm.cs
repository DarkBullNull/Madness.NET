using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet;
using MetroSuite;
using MetroSuite.Extension.Styles.Themes;

namespace MadnessNET.Forms
{
    public partial class MethodsListForm : MetroForm
    {

        public static MethodDef[] methodsArray;

        public MethodsListForm()
        {
            InitializeComponent();
            MetroSteamTheme metroSteamTheme = new MetroSteamTheme();
            metroSteamTheme.ApplyTheme(this);
        }
        public ModuleDef moduleDef;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_MoveRight_Click(object sender, EventArgs e)
        {
            if (listBox_selectMethods.SelectedItem != null)
            {
                listBox_selectedMethods.Items.Add(listBox_selectMethods.SelectedItem);
                listBox_selectMethods.Items.Remove(listBox_selectMethods.SelectedItem);
            }
        }

        private void btn_MoveLeft_Click(object sender, EventArgs e)
        {
            if (listBox_selectedMethods.SelectedItem != null)
            {
                listBox_selectMethods.Items.Add(listBox_selectedMethods.SelectedItem);
                listBox_selectedMethods.Items.Remove(listBox_selectedMethods.SelectedItem);
            }
        }

        private void MethodsListForm_Shown(object sender, EventArgs e)
        {
            moduleDef = MainForm.moduleDef;
            foreach (var type in moduleDef.Types)
            {
                foreach (var method in type.Methods)
                {
                    listBox_selectMethods.Items.Add(method);
                }
            }
        }

        private async void MethodsListForm_Paint(object sender, PaintEventArgs e)
        {
            await Task.Delay(100);
            Graphics graphics_listBoxselect = listBox_selectMethods.CreateGraphics();
            Graphics graphics_listBoxselected = listBox_selectedMethods.CreateGraphics();
            Pen pen_listBoxselect = new Pen(Color.Red, 2f);
            Pen pen_listBoxselected = new Pen(Color.Red, 2f);
            graphics_listBoxselect.DrawRectangle(pen_listBoxselect, 0, 0, listBox_selectMethods.Width, listBox_selectMethods.Height);
            graphics_listBoxselected.DrawRectangle(pen_listBoxselected, 0, 0, listBox_selectedMethods.Width, listBox_selectedMethods.Height);
        }
    }
}
