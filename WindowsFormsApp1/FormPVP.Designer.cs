namespace WindowsFormsApp1
{
    partial class FormPVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPVP));
            this.BanCo_pnl = new System.Windows.Forms.Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer_Player1 = new System.Windows.Forms.Timer(this.components);
            this.timer_Game = new System.Windows.Forms.Timer(this.components);
            this.label_GameTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_timePlayer1 = new System.Windows.Forms.Label();
            this.KetNoiLAN_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.NewGame_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.PlayerMark_pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_PlayerName1 = new System.Windows.Forms.TextBox();
            this.textBox_PlayerIP1 = new System.Windows.Forms.TextBox();
            this.BanCo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BanCo_pnl
            // 
            this.BanCo_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.BanCo_pnl.Controls.Add(this.guna2PictureBox4);
            this.BanCo_pnl.Location = new System.Drawing.Point(327, 52);
            this.BanCo_pnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BanCo_pnl.Name = "BanCo_pnl";
            this.BanCo_pnl.Size = new System.Drawing.Size(760, 679);
            this.BanCo_pnl.TabIndex = 0;
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
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1235, 9);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Crimson;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 498);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 35);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Time:";
            // 
            // timer_Player1
            // 
            this.timer_Player1.Interval = 1000;
            this.timer_Player1.Tick += new System.EventHandler(this.timer_Player1_Tick);
            // 
            // timer_Game
            // 
            this.timer_Game.Interval = 1000;
            this.timer_Game.Tick += new System.EventHandler(this.timer_Game_Tick);
            // 
            // label_GameTime
            // 
            this.label_GameTime.BackColor = System.Drawing.Color.Transparent;
            this.label_GameTime.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GameTime.Location = new System.Drawing.Point(651, 12);
            this.label_GameTime.Name = "label_GameTime";
            this.label_GameTime.Size = new System.Drawing.Size(48, 33);
            this.label_GameTime.TabIndex = 15;
            this.label_GameTime.Text = "0:00";
            // 
            // label_timePlayer1
            // 
            this.label_timePlayer1.BackColor = System.Drawing.Color.Transparent;
            this.label_timePlayer1.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timePlayer1.ForeColor = System.Drawing.Color.Crimson;
            this.label_timePlayer1.Location = new System.Drawing.Point(792, 18);
            this.label_timePlayer1.Name = "label_timePlayer1";
            this.label_timePlayer1.Size = new System.Drawing.Size(47, 27);
            this.label_timePlayer1.TabIndex = 16;
            this.label_timePlayer1.Text = "10";
            // 
            // KetNoiLAN_Btn
            // 
            this.KetNoiLAN_Btn.CheckedState.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.CustomImages.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KetNoiLAN_Btn.ForeColor = System.Drawing.Color.White;
            this.KetNoiLAN_Btn.HoverState.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.Location = new System.Drawing.Point(519, 738);
            this.KetNoiLAN_Btn.Name = "KetNoiLAN_Btn";
            this.KetNoiLAN_Btn.ShadowDecoration.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.Size = new System.Drawing.Size(180, 45);
            this.KetNoiLAN_Btn.TabIndex = 18;
            this.KetNoiLAN_Btn.Text = "LAN";
            this.KetNoiLAN_Btn.Click += new System.EventHandler(this.KetNoiLAN_Btn_Click);
            // 
            // NewGame_Btn
            // 
            this.NewGame_Btn.CheckedState.Parent = this.NewGame_Btn;
            this.NewGame_Btn.CustomImages.Parent = this.NewGame_Btn;
            this.NewGame_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewGame_Btn.ForeColor = System.Drawing.Color.White;
            this.NewGame_Btn.HoverState.Parent = this.NewGame_Btn;
            this.NewGame_Btn.Location = new System.Drawing.Point(705, 738);
            this.NewGame_Btn.Name = "NewGame_Btn";
            this.NewGame_Btn.ShadowDecoration.Parent = this.NewGame_Btn;
            this.NewGame_Btn.Size = new System.Drawing.Size(180, 45);
            this.NewGame_Btn.TabIndex = 19;
            this.NewGame_Btn.Text = "New Game";
            this.NewGame_Btn.Click += new System.EventHandler(this.NewGame_Btn_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Location = new System.Drawing.Point(1140, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(39, 33);
            this.Exit_Button.TabIndex = 20;
            this.Exit_Button.Text = "X";
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // PlayerMark_pictureBox
            // 
            this.PlayerMark_pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerMark_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayerMark_pictureBox.Location = new System.Drawing.Point(12, 52);
            this.PlayerMark_pictureBox.Name = "PlayerMark_pictureBox";
            this.PlayerMark_pictureBox.Size = new System.Drawing.Size(309, 294);
            this.PlayerMark_pictureBox.TabIndex = 21;
            this.PlayerMark_pictureBox.TabStop = false;
            // 
            // textBox_PlayerName1
            // 
            this.textBox_PlayerName1.Location = new System.Drawing.Point(12, 352);
            this.textBox_PlayerName1.Multiline = true;
            this.textBox_PlayerName1.Name = "textBox_PlayerName1";
            this.textBox_PlayerName1.Size = new System.Drawing.Size(308, 61);
            this.textBox_PlayerName1.TabIndex = 22;
            // 
            // textBox_PlayerIP1
            // 
            this.textBox_PlayerIP1.Location = new System.Drawing.Point(11, 419);
            this.textBox_PlayerIP1.Multiline = true;
            this.textBox_PlayerIP1.Name = "textBox_PlayerIP1";
            this.textBox_PlayerIP1.Size = new System.Drawing.Size(309, 58);
            this.textBox_PlayerIP1.TabIndex = 23;
            // 
            // FormPVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 829);
            this.Controls.Add(this.textBox_PlayerIP1);
            this.Controls.Add(this.textBox_PlayerName1);
            this.Controls.Add(this.PlayerMark_pictureBox);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.NewGame_Btn);
            this.Controls.Add(this.KetNoiLAN_Btn);
            this.Controls.Add(this.label_timePlayer1);
            this.Controls.Add(this.label_GameTime);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.BanCo_pnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPVP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.Shown += new System.EventHandler(this.FormPVP_Shown);
            this.BanCo_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BanCo_pnl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        public System.Windows.Forms.Timer timer_Player1;
        private System.Windows.Forms.Timer timer_Game;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_GameTime;
        public System.Windows.Forms.Label label_timePlayer1;
        private Guna.UI2.WinForms.Guna2Button KetNoiLAN_Btn;
        private Guna.UI2.WinForms.Guna2Button NewGame_Btn;
        private Guna.UI2.WinForms.Guna2Button Exit_Button;
        private System.Windows.Forms.TextBox textBox_PlayerIP1;
        private System.Windows.Forms.TextBox textBox_PlayerName1;
        private System.Windows.Forms.PictureBox PlayerMark_pictureBox;
    }
}

