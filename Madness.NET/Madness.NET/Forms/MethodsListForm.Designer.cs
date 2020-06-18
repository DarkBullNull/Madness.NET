using MetroSuite;

namespace MadnessNET.Forms
{
    partial class MethodsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodsListForm));
            this.label_AntiDe4dot = new MetroSuite.MetroLabel();
            this.listBox_selectMethods = new MetroSuite.MetroListbox();
            this.btn_MoveRight = new MetroSuite.MetroButton();
            this.listBox_selectedMethods = new MetroSuite.MetroListbox();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.btn_Exit = new MetroSuite.MetroButton();
            this.btn_MoveLeft = new MetroSuite.MetroButton();
            this.SuspendLayout();
            // 
            // label_AntiDe4dot
            // 
            this.label_AntiDe4dot.AutoSize = true;
            this.label_AntiDe4dot.BackColor = System.Drawing.Color.Transparent;
            this.label_AntiDe4dot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_AntiDe4dot.Location = new System.Drawing.Point(5, 5);
            this.label_AntiDe4dot.Name = "label_AntiDe4dot";
            this.label_AntiDe4dot.Size = new System.Drawing.Size(203, 15);
            this.label_AntiDe4dot.TabIndex = 3;
            this.label_AntiDe4dot.Text = "Select methots, which will be hidden:";
            this.label_AntiDe4dot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox_selectMethods
            // 
            this.listBox_selectMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBox_selectMethods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.listBox_selectMethods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_selectMethods.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listBox_selectMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.listBox_selectMethods.FormattingEnabled = true;
            this.listBox_selectMethods.Location = new System.Drawing.Point(6, 23);
            this.listBox_selectMethods.Name = "listBox_selectMethods";
            this.listBox_selectMethods.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.listBox_selectMethods.Size = new System.Drawing.Size(410, 78);
            this.listBox_selectMethods.Style = MetroSuite.Design.Style.Dark;
            this.listBox_selectMethods.TabIndex = 4;
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.BackColor = System.Drawing.Color.Transparent;
            this.btn_MoveRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_MoveRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btn_MoveRight.DefaultColor = System.Drawing.Color.White;
            this.btn_MoveRight.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_MoveRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MoveRight.HoverColor = System.Drawing.Color.White;
            this.btn_MoveRight.IsRound = true;
            this.btn_MoveRight.Location = new System.Drawing.Point(422, 36);
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_MoveRight.RoundingArc = 25;
            this.btn_MoveRight.Size = new System.Drawing.Size(23, 25);
            this.btn_MoveRight.TabIndex = 5;
            this.btn_MoveRight.Text = ">";
            this.btn_MoveRight.Click += new System.EventHandler(this.btn_MoveRight_Click);
            // 
            // listBox_selectedMethods
            // 
            this.listBox_selectedMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBox_selectedMethods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.listBox_selectedMethods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_selectedMethods.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listBox_selectedMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.listBox_selectedMethods.FormattingEnabled = true;
            this.listBox_selectedMethods.Location = new System.Drawing.Point(451, 23);
            this.listBox_selectedMethods.Name = "listBox_selectedMethods";
            this.listBox_selectedMethods.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.listBox_selectedMethods.Size = new System.Drawing.Size(207, 78);
            this.listBox_selectedMethods.Style = MetroSuite.Design.Style.Dark;
            this.listBox_selectedMethods.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel1.Location = new System.Drawing.Point(448, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 15);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "WILL BE HIDDEN:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Exit.Location = new System.Drawing.Point(394, 107);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Exit.RoundingArc = 22;
            this.btn_Exit.Size = new System.Drawing.Size(78, 22);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.BackColor = System.Drawing.Color.Transparent;
            this.btn_MoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_MoveLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btn_MoveLeft.DefaultColor = System.Drawing.Color.White;
            this.btn_MoveLeft.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_MoveLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MoveLeft.HoverColor = System.Drawing.Color.White;
            this.btn_MoveLeft.IsRound = true;
            this.btn_MoveLeft.Location = new System.Drawing.Point(422, 67);
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_MoveLeft.RoundingArc = 25;
            this.btn_MoveLeft.Size = new System.Drawing.Size(23, 25);
            this.btn_MoveLeft.TabIndex = 9;
            this.btn_MoveLeft.Text = "<";
            this.btn_MoveLeft.Click += new System.EventHandler(this.btn_MoveLeft_Click);
            // 
            // MethodsListForm
            // 
            this.AccentColor = System.Drawing.Color.Red;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 136);
            this.Controls.Add(this.btn_MoveLeft);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox_selectedMethods);
            this.Controls.Add(this.btn_MoveRight);
            this.Controls.Add(this.listBox_selectMethods);
            this.Controls.Add(this.label_AntiDe4dot);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MethodsListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Shown += new System.EventHandler(this.MethodsListForm_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MethodsListForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroLabel label_AntiDe4dot;
        private MetroListbox listBox_selectMethods;
        private MetroButton btn_MoveRight;
        private MetroLabel metroLabel1;
        private MetroButton btn_Exit;
        private MetroButton btn_MoveLeft;
        public MetroListbox listBox_selectedMethods;
    }
}