namespace WindowsFormsApp1
{
    partial class FormPVC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPVC));
            this.BanCo_pnl = new System.Windows.Forms.Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.newGame_Button = new Guna.UI2.WinForms.Guna2Button();
            this.quit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.timerPlayer_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer_Player = new System.Windows.Forms.Timer(this.components);
            this.timer_Game = new System.Windows.Forms.Timer(this.components);
            this.timerGame_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.playerName_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BanCo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BanCo_pnl
            // 
            this.BanCo_pnl.BackColor = System.Drawing.Color.White;
            this.BanCo_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BanCo_pnl.Controls.Add(this.guna2PictureBox4);
            this.BanCo_pnl.Location = new System.Drawing.Point(352, 90);
            this.BanCo_pnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BanCo_pnl.Name = "BanCo_pnl";
            this.BanCo_pnl.Size = new System.Drawing.Size(760, 679);
            this.BanCo_pnl.TabIndex = 1;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Location = new System.Drawing.Point(1044, 182);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(307, 267);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 20;
            this.guna2PictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 148);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 284);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(32, 484);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(94, 38);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Time:";
            // 
            // newGame_Button
            // 
            this.newGame_Button.CheckedState.Parent = this.newGame_Button;
            this.newGame_Button.CustomImages.Parent = this.newGame_Button;
            this.newGame_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newGame_Button.ForeColor = System.Drawing.Color.White;
            this.newGame_Button.HoverState.Parent = this.newGame_Button;
            this.newGame_Button.Location = new System.Drawing.Point(32, 546);
            this.newGame_Button.Name = "newGame_Button";
            this.newGame_Button.ShadowDecoration.Parent = this.newGame_Button;
            this.newGame_Button.Size = new System.Drawing.Size(180, 45);
            this.newGame_Button.TabIndex = 23;
            this.newGame_Button.Text = "New Game";
            this.newGame_Button.Click += new System.EventHandler(this.newGame_Button_Click);
            // 
            // quit_Button
            // 
            this.quit_Button.CheckedState.Parent = this.quit_Button;
            this.quit_Button.CustomImages.Parent = this.quit_Button;
            this.quit_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quit_Button.ForeColor = System.Drawing.Color.White;
            this.quit_Button.HoverState.Parent = this.quit_Button;
            this.quit_Button.Location = new System.Drawing.Point(32, 603);
            this.quit_Button.Name = "quit_Button";
            this.quit_Button.ShadowDecoration.Parent = this.quit_Button;
            this.quit_Button.Size = new System.Drawing.Size(180, 45);
            this.quit_Button.TabIndex = 24;
            this.quit_Button.Text = "Quit";
            this.quit_Button.Click += new System.EventHandler(this.quit_Button_Click);
            // 
            // timerPlayer_Label
            // 
            this.timerPlayer_Label.BackColor = System.Drawing.Color.Transparent;
            this.timerPlayer_Label.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerPlayer_Label.ForeColor = System.Drawing.Color.LightSlateGray;
            this.timerPlayer_Label.Location = new System.Drawing.Point(133, 484);
            this.timerPlayer_Label.Name = "timerPlayer_Label";
            this.timerPlayer_Label.Size = new System.Drawing.Size(37, 44);
            this.timerPlayer_Label.TabIndex = 26;
            this.timerPlayer_Label.Text = "10";
            // 
            // timer_Player
            // 
            this.timer_Player.Interval = 1000;
            this.timer_Player.Tick += new System.EventHandler(this.timer_Player_Tick);
            // 
            // timer_Game
            // 
            this.timer_Game.Interval = 1000;
            this.timer_Game.Tick += new System.EventHandler(this.timer_Game_Tick);
            // 
            // timerGame_Label
            // 
            this.timerGame_Label.BackColor = System.Drawing.Color.Transparent;
            this.timerGame_Label.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerGame_Label.ForeColor = System.Drawing.Color.Blue;
            this.timerGame_Label.Location = new System.Drawing.Point(639, 30);
            this.timerGame_Label.Name = "timerGame_Label";
            this.timerGame_Label.Size = new System.Drawing.Size(64, 44);
            this.timerGame_Label.TabIndex = 27;
            this.timerGame_Label.Text = "0:00";
            // 
            // playerName_TextBox
            // 
            this.playerName_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.playerName_TextBox.DefaultText = "";
            this.playerName_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.playerName_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.playerName_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.playerName_TextBox.DisabledState.Parent = this.playerName_TextBox;
            this.playerName_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.playerName_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.playerName_TextBox.FocusedState.Parent = this.playerName_TextBox;
            this.playerName_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playerName_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.playerName_TextBox.HoverState.Parent = this.playerName_TextBox;
            this.playerName_TextBox.Location = new System.Drawing.Point(32, 439);
            this.playerName_TextBox.Name = "playerName_TextBox";
            this.playerName_TextBox.PasswordChar = '\0';
            this.playerName_TextBox.PlaceholderText = "";
            this.playerName_TextBox.SelectedText = "";
            this.playerName_TextBox.ShadowDecoration.Parent = this.playerName_TextBox;
            this.playerName_TextBox.Size = new System.Drawing.Size(200, 36);
            this.playerName_TextBox.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1170, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 83);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormPVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 835);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerName_TextBox);
            this.Controls.Add(this.timerGame_Label);
            this.Controls.Add(this.timerPlayer_Label);
            this.Controls.Add(this.quit_Button);
            this.Controls.Add(this.newGame_Button);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BanCo_pnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPVC";
            this.Text = "FormPVC";
            this.BanCo_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BanCo_pnl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button newGame_Button;
        private Guna.UI2.WinForms.Guna2Button quit_Button;
        private Guna.UI2.WinForms.Guna2HtmlLabel timerPlayer_Label;
        private System.Windows.Forms.Timer timer_Player;
        private Guna.UI2.WinForms.Guna2HtmlLabel timerGame_Label;
        private Guna.UI2.WinForms.Guna2TextBox playerName_TextBox;
        public System.Windows.Forms.Timer timer_Game;
        private System.Windows.Forms.Button button1;
    }
}