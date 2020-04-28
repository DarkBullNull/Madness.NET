using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSuite.Extension.Styles.Themes;

namespace MadnessNET.Forms
{
    public partial class RenamerForm : MetroSuite.MetroForm
    {
        public RenamerForm()
        {
            InitializeComponent();
            MetroSteamTheme metroSteamTheme = new MetroSteamTheme();
            metroSteamTheme.ApplyTheme(this);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
        }

        public string ModuleName
        {
            get { return textbox_module.Text; }
            set { textbox_module.Text = value; }
        }

        public string AssemblyName
        {
            get { return textbox_assembly.Text; }
            set { textbox_assembly.Text = value; }
        }
    }
}
