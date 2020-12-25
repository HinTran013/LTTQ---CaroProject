namespace WindowsFormsApp1
{
    partial class FormChooseCharactorLAN
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
            this.BanChon_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Name_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Name_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.OK_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BanChon_Panel
            // 
            this.BanChon_Panel.Location = new System.Drawing.Point(12, 12);
            this.BanChon_Panel.Name = "BanChon_Panel";
            this.BanChon_Panel.ShadowDecoration.Parent = this.BanChon_Panel;
            this.BanChon_Panel.Size = new System.Drawing.Size(519, 402);
            this.BanChon_Panel.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Name_Label.Location = new System.Drawing.Point(12, 429);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(74, 18);
            this.Name_Label.TabIndex = 3;
            this.Name_Label.Text = "Your Name:";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_TextBox.DefaultText = "";
            this.Name_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Name_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_TextBox.DisabledState.Parent = this.Name_TextBox;
            this.Name_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_TextBox.FocusedState.Parent = this.Name_TextBox;
            this.Name_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_TextBox.HoverState.Parent = this.Name_TextBox;
            this.Name_TextBox.Location = new System.Drawing.Point(92, 420);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.PasswordChar = '\0';
            this.Name_TextBox.PlaceholderText = "";
            this.Name_TextBox.SelectedText = "";
            this.Name_TextBox.ShadowDecoration.Parent = this.Name_TextBox;
            this.Name_TextBox.Size = new System.Drawing.Size(200, 36);
            this.Name_TextBox.TabIndex = 4;
            // 
            // OK_Button
            // 
            this.OK_Button.CheckedState.Parent = this.OK_Button;
            this.OK_Button.CustomImages.Parent = this.OK_Button;
            this.OK_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OK_Button.ForeColor = System.Drawing.Color.White;
            this.OK_Button.HoverState.Parent = this.OK_Button;
            this.OK_Button.Location = new System.Drawing.Point(389, 420);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.ShadowDecoration.Parent = this.OK_Button;
            this.OK_Button.Size = new System.Drawing.Size(142, 45);
            this.OK_Button.TabIndex = 5;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // FormChooseCharactorLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 474);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.BanChon_Panel);
            this.Name = "FormChooseCharactorLAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChooseCharactorLAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BanChon_Panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel Name_Label;
        private Guna.UI2.WinForms.Guna2TextBox Name_TextBox;
        private Guna.UI2.WinForms.Guna2Button OK_Button;
    }
}