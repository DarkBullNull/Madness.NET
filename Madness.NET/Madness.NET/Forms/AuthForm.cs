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

namespace MadnessNET
{
    public partial class AuthForm : MetroSuite.MetroForm
    {
        public AuthForm()
        {
            InitializeComponent();
            MetroSteamTheme metroSteamTheme = new MetroSteamTheme();
            metroSteamTheme.ApplyTheme(this);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            byte abc = Convert.ToByte(0x0A);
            // Logics authorization...
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
            // Logics authorization...
        }
    }
}
