namespace MadnessNET.Forms
{
    partial class RenamerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenamerForm));
            this.label_strEncrypt = new MetroSuite.MetroLabel();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.textbox_module = new MetroSuite.MetroTextbox();
            this.textbox_assembly = new MetroSuite.MetroTextbox();
            this.btn_Exit = new MetroSuite.MetroButton();
            this.SuspendLayout();
            // 
            // label_strEncrypt
            // 
            this.label_strEncrypt.AutoSize = true;
            this.label_strEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.label_strEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_strEncrypt.Location = new System.Drawing.Point(9, 84);
            this.label_strEncrypt.Name = "label_strEncrypt";
            this.label_strEncrypt.Size = new System.Drawing.Size(114, 15);
            this.label_strEncrypt.TabIndex = 2;
            this.label_strEncrypt.Text = "Module(can be null)";
            this.label_strEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel1.Location = new System.Drawing.Point(9, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Assembly (!=null)";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_module
            // 
            this.textbox_module.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox_module.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.textbox_module.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textbox_module.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textbox_module.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_module.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.textbox_module.HideSelection = false;
            this.textbox_module.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textbox_module.Location = new System.Drawing.Point(11, 102);
            this.textbox_module.Name = "textbox_module";
            this.textbox_module.PasswordChar = '\0';
            this.textbox_module.Size = new System.Drawing.Size(133, 23);
            this.textbox_module.Style = MetroSuite.Design.Style.Dark;
            this.textbox_module.TabIndex = 6;
            this.textbox_module.Watermark = "Enter your module";
            // 
            // textbox_assembly
            // 
            this.textbox_assembly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox_assembly.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.textbox_assembly.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textbox_assembly.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textbox_assembly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_assembly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.textbox_assembly.HideSelection = false;
            this.textbox_assembly.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textbox_assembly.Location = new System.Drawing.Point(12, 53);
            this.textbox_assembly.Name = "textbox_assembly";
            this.textbox_assembly.PasswordChar = '\0';
            this.textbox_assembly.Size = new System.Drawing.Size(133, 23);
            this.textbox_assembly.Style = MetroSuite.Design.Style.Dark;
            this.textbox_assembly.TabIndex = 7;
            this.textbox_assembly.Watermark = "Enter your assembly";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoStyle = false;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btn_Exit.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Exit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btn_Exit.IsRound = true;
            this.btn_Exit.Location = new System.Drawing.Point(38, 132);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Exit.RoundingArc = 22;
            this.btn_Exit.Size = new System.Drawing.Size(78, 22);
            this.btn_Exit.Style = MetroSuite.Design.Style.Custom;
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Ok";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // RenamerForm
            // 
            this.AccentColor = System.Drawing.Color.Red;
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 163);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.textbox_assembly);
            this.Controls.Add(this.textbox_module);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label_strEncrypt);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenamerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "Manually_Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSuite.MetroLabel label_strEncrypt;
        private MetroSuite.MetroLabel metroLabel1;
        private MetroSuite.MetroTextbox textbox_module;
        private MetroSuite.MetroTextbox textbox_assembly;
        private MetroSuite.MetroButton btn_Exit;
    }
}