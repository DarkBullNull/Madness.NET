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
            if (textbox_module.Text != String.Empty)
            {
                
            }


            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
