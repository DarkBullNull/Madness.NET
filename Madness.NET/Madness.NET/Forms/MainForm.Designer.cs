using MetroSuite;
using MetroSuite.Extension.Styles.Themes;

namespace MadnessNET
{
    partial class MainForm : MetroSuite.MetroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Exit = new MetroSuite.MetroButton();
            this.textBox_filePath = new MetroSuite.MetroTextbox();
            this.panel_DaD = new System.Windows.Forms.Panel();
            this.label_DaD_info = new MetroSuite.MetroLabel();
            this.button_loadFile = new MetroSuite.MetroButton();
            this.textbox_outputPath = new MetroSuite.MetroTextbox();
            this.panel_total = new System.Windows.Forms.Panel();
            this.label_strEncrypt = new MetroSuite.MetroLabel();
            this.checkBox_stringEncrypt = new MetroSuite.MetroSwitch();
            this.label_renamer = new MetroSuite.MetroLabel();
            this.button_protect = new MetroSuite.MetroButton();
            this.metroSwitch1 = new MetroSuite.MetroSwitch();
            this.panel_other = new System.Windows.Forms.Panel();
            this.panel_DaD.SuspendLayout();
            this.panel_total.SuspendLayout();
            this.panel_other.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btn_Exit.DefaultColor = System.Drawing.Color.White;
            this.btn_Exit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.HoverColor = System.Drawing.Color.White;
            this.btn_Exit.IsRound = true;
            this.btn_Exit.Location = new System.Drawing.Point(394, 380);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Exit.RoundingArc = 22;
            this.btn_Exit.Size = new System.Drawing.Size(78, 22);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox_filePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.textBox_filePath.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox_filePath.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_filePath.Enabled = false;
            this.textBox_filePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_filePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.textBox_filePath.HideSelection = false;
            this.textBox_filePath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textBox_filePath.Location = new System.Drawing.Point(12, 129);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.PasswordChar = '\0';
            this.textBox_filePath.Size = new System.Drawing.Size(376, 23);
            this.textBox_filePath.Style = MetroSuite.Design.Style.Dark;
            this.textBox_filePath.TabIndex = 2;
            this.textBox_filePath.Text = "Select file------------------------------------------------------------->";
            this.textBox_filePath.Watermark = "Input file path";
            // 
            // panel_DaD
            // 
            this.panel_DaD.AllowDrop = true;
            this.panel_DaD.Controls.Add(this.label_DaD_info);
            this.panel_DaD.Location = new System.Drawing.Point(12, 37);
            this.panel_DaD.Name = "panel_DaD";
            this.panel_DaD.Size = new System.Drawing.Size(460, 86);
            this.panel_DaD.TabIndex = 1;
            this.panel_DaD.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DaD_DragDrop);
            this.panel_DaD.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DaD_DragEnter);
            this.panel_DaD.DragLeave += new System.EventHandler(this.panel_DaD_DragLeave);
            // 
            // label_DaD_info
            // 
            this.label_DaD_info.BackColor = System.Drawing.Color.Transparent;
            this.label_DaD_info.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_DaD_info.Location = new System.Drawing.Point(3, 34);
            this.label_DaD_info.Name = "label_DaD_info";
            this.label_DaD_info.Size = new System.Drawing.Size(454, 16);
            this.label_DaD_info.TabIndex = 0;
            this.label_DaD_info.Text = "Push Me";
            this.label_DaD_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_loadFile
            // 
            this.button_loadFile.BackColor = System.Drawing.Color.Transparent;
            this.button_loadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_loadFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.button_loadFile.DefaultColor = System.Drawing.Color.White;
            this.button_loadFile.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.button_loadFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_loadFile.HoverColor = System.Drawing.Color.White;
            this.button_loadFile.IsRound = true;
            this.button_loadFile.Location = new System.Drawing.Point(394, 129);
            this.button_loadFile.Name = "button_loadFile";
            this.button_loadFile.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_loadFile.RoundingArc = 23;
            this.button_loadFile.Size = new System.Drawing.Size(78, 23);
            this.button_loadFile.TabIndex = 3;
            this.button_loadFile.Text = "Load";
            this.button_loadFile.Click += new System.EventHandler(this.button_loadFile_Click);
            // 
            // textbox_outputPath
            // 
            this.textbox_outputPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox_outputPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.textbox_outputPath.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textbox_outputPath.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textbox_outputPath.Enabled = false;
            this.textbox_outputPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_outputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.textbox_outputPath.HideSelection = false;
            this.textbox_outputPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textbox_outputPath.Location = new System.Drawing.Point(12, 158);
            this.textbox_outputPath.Name = "textbox_outputPath";
            this.textbox_outputPath.PasswordChar = '\0';
            this.textbox_outputPath.Size = new System.Drawing.Size(460, 23);
            this.textbox_outputPath.Style = MetroSuite.Design.Style.Dark;
            this.textbox_outputPath.TabIndex = 4;
            this.textbox_outputPath.Watermark = "Output file path";
            // 
            // panel_total
            // 
            this.panel_total.Controls.Add(this.label_strEncrypt);
            this.panel_total.Controls.Add(this.checkBox_stringEncrypt);
            this.panel_total.Location = new System.Drawing.Point(12, 187);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(335, 187);
            this.panel_total.TabIndex = 5;
            // 
            // label_strEncrypt
            // 
            this.label_strEncrypt.AutoSize = true;
            this.label_strEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.label_strEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_strEncrypt.Location = new System.Drawing.Point(10, 4);
            this.label_strEncrypt.Name = "label_strEncrypt";
            this.label_strEncrypt.Size = new System.Drawing.Size(81, 15);
            this.label_strEncrypt.TabIndex = 1;
            this.label_strEncrypt.Text = "String encrypt";
            this.label_strEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_stringEncrypt
            // 
            this.checkBox_stringEncrypt.AutoStyle = false;
            this.checkBox_stringEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_stringEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox_stringEncrypt.BorderColor = System.Drawing.Color.Red;
            this.checkBox_stringEncrypt.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_stringEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_stringEncrypt.DefaultColor = System.Drawing.Color.Red;
            this.checkBox_stringEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox_stringEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.checkBox_stringEncrypt.HoverColor = System.Drawing.Color.Red;
            this.checkBox_stringEncrypt.Location = new System.Drawing.Point(101, 3);
            this.checkBox_stringEncrypt.Name = "checkBox_stringEncrypt";
            this.checkBox_stringEncrypt.Size = new System.Drawing.Size(37, 22);
            this.checkBox_stringEncrypt.Style = MetroSuite.Design.Style.Custom;
            this.checkBox_stringEncrypt.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkBox_stringEncrypt.TabIndex = 0;
            this.checkBox_stringEncrypt.Text = "checkBox1";
            // 
            // label_renamer
            // 
            this.label_renamer.AutoSize = true;
            this.label_renamer.BackColor = System.Drawing.Color.Transparent;
            this.label_renamer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_renamer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_renamer.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_renamer.Location = new System.Drawing.Point(15, 6);
            this.label_renamer.Name = "label_renamer";
            this.label_renamer.Size = new System.Drawing.Size(54, 15);
            this.label_renamer.TabIndex = 3;
            this.label_renamer.Text = "Renamer";
            this.label_renamer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_renamer.Click += new System.EventHandler(this.label_renamer_Click);
            // 
            // button_protect
            // 
            this.button_protect.BackColor = System.Drawing.Color.Transparent;
            this.button_protect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_protect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.button_protect.DefaultColor = System.Drawing.Color.White;
            this.button_protect.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.button_protect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_protect.HoverColor = System.Drawing.Color.White;
            this.button_protect.IsRound = true;
            this.button_protect.Location = new System.Drawing.Point(12, 380);
            this.button_protect.Name = "button_protect";
            this.button_protect.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_protect.RoundingArc = 22;
            this.button_protect.Size = new System.Drawing.Size(78, 22);
            this.button_protect.TabIndex = 6;
            this.button_protect.Text = "Protect";
            this.button_protect.Click += new System.EventHandler(this.button_protect_Click);
            // 
            // metroSwitch1
            // 
            this.metroSwitch1.AutoStyle = false;
            this.metroSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.metroSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroSwitch1.BorderColor = System.Drawing.Color.Red;
            this.metroSwitch1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSwitch1.DefaultColor = System.Drawing.Color.Red;
            this.metroSwitch1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroSwitch1.HoverColor = System.Drawing.Color.Red;
            this.metroSwitch1.Location = new System.Drawing.Point(79, 4);
            this.metroSwitch1.Name = "metroSwitch1";
            this.metroSwitch1.Size = new System.Drawing.Size(37, 22);
            this.metroSwitch1.Style = MetroSuite.Design.Style.Custom;
            this.metroSwitch1.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSwitch1.TabIndex = 2;
            this.metroSwitch1.Text = "checkBox1";
            // 
            // panel_other
            // 
            this.panel_other.Controls.Add(this.label_renamer);
            this.panel_other.Controls.Add(this.metroSwitch1);
            this.panel_other.Location = new System.Drawing.Point(353, 187);
            this.panel_other.Name = "panel_other";
            this.panel_other.Size = new System.Drawing.Size(119, 187);
            this.panel_other.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AccentColor = System.Drawing.Color.Red;
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.button_protect);
            this.Controls.Add(this.textbox_outputPath);
            this.Controls.Add(this.button_loadFile);
            this.Controls.Add(this.textBox_filePath);
            this.Controls.Add(this.panel_DaD);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel_total);
            this.Controls.Add(this.panel_other);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "Madness.NET";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel_DaD.ResumeLayout(false);
            this.panel_total.ResumeLayout(false);
            this.panel_total.PerformLayout();
            this.panel_other.ResumeLayout(false);
            this.panel_other.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroButton btn_Exit;
        private System.Windows.Forms.Panel panel_DaD;
        private MetroLabel label_DaD_info;
        private MetroTextbox textBox_filePath;
        private MetroButton button_loadFile;
        private MetroTextbox textbox_outputPath;
        private System.Windows.Forms.Panel panel_total;
        private MetroButton button_protect;
        private MetroSwitch checkBox_stringEncrypt;
        private MetroLabel label_strEncrypt;
        private MetroLabel label_renamer;
        private MetroSwitch metroSwitch1;
        private System.Windows.Forms.Panel panel_other;
    }
}

