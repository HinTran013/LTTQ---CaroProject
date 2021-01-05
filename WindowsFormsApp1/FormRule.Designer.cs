namespace WindowsFormsApp1
{
    partial class FormRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRule));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Mute_Button = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.Sound_Button = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(223, 32);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(750, 99);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "The Rules of Caro";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(-2129, 267);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = null;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(328, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 364);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.BackgroundImage")));
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CircleButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(16, 2);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(97, 95);
            this.guna2CircleButton1.TabIndex = 3;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Mute_Button
            // 
            this.Mute_Button.BackColor = System.Drawing.Color.Transparent;
            this.Mute_Button.CheckedState.Parent = this.Mute_Button;
            this.Mute_Button.CustomImages.Parent = this.Mute_Button;
            this.Mute_Button.FillColor = System.Drawing.Color.LightBlue;
            this.Mute_Button.FillColor2 = System.Drawing.Color.Bisque;
            this.Mute_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Mute_Button.ForeColor = System.Drawing.Color.White;
            this.Mute_Button.HoverState.Parent = this.Mute_Button;
            this.Mute_Button.Image = global::WindowsFormsApp1.Properties.Resources.mute;
            this.Mute_Button.Location = new System.Drawing.Point(12, 545);
            this.Mute_Button.Name = "Mute_Button";
            this.Mute_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Mute_Button.ShadowDecoration.Parent = this.Mute_Button;
            this.Mute_Button.Size = new System.Drawing.Size(39, 38);
            this.Mute_Button.TabIndex = 19;
            this.Mute_Button.Click += new System.EventHandler(this.Mute_Button_Click);
            // 
            // Sound_Button
            // 
            this.Sound_Button.BackColor = System.Drawing.Color.Transparent;
            this.Sound_Button.CheckedState.Parent = this.Sound_Button;
            this.Sound_Button.CustomImages.Parent = this.Sound_Button;
            this.Sound_Button.FillColor = System.Drawing.Color.Bisque;
            this.Sound_Button.FillColor2 = System.Drawing.Color.LightBlue;
            this.Sound_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sound_Button.ForeColor = System.Drawing.Color.White;
            this.Sound_Button.HoverState.Parent = this.Sound_Button;
            this.Sound_Button.Image = global::WindowsFormsApp1.Properties.Resources.volume;
            this.Sound_Button.Location = new System.Drawing.Point(12, 545);
            this.Sound_Button.Name = "Sound_Button";
            this.Sound_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Sound_Button.ShadowDecoration.Parent = this.Sound_Button;
            this.Sound_Button.Size = new System.Drawing.Size(39, 38);
            this.Sound_Button.TabIndex = 20;
            this.Sound_Button.Click += new System.EventHandler(this.Sound_Button_Click);
            // 
            // FormRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 595);
            this.ControlBox = false;
            this.Controls.Add(this.Sound_Button);
            this.Controls.Add(this.Mute_Button);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormRule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        public Guna.UI2.WinForms.Guna2GradientCircleButton Mute_Button;
        public Guna.UI2.WinForms.Guna2GradientCircleButton Sound_Button;
    }
}