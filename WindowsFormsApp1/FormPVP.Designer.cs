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
            this.textBox_PlayerIP1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_PlayerName1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.PlayerMark_pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ChatTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendButton = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Mute_Button = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.Sound_Button = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.quitbtn = new Guna.UI2.WinForms.Guna2Button();
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1812, 9);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 444);
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
            this.label_GameTime.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GameTime.ForeColor = System.Drawing.Color.RosyBrown;
            this.label_GameTime.Location = new System.Drawing.Point(684, 2);
            this.label_GameTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_GameTime.Name = "label_GameTime";
            this.label_GameTime.Size = new System.Drawing.Size(75, 44);
            this.label_GameTime.TabIndex = 15;
            this.label_GameTime.Text = "0:00";
            // 
            // label_timePlayer1
            // 
            this.label_timePlayer1.BackColor = System.Drawing.Color.Transparent;
            this.label_timePlayer1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timePlayer1.ForeColor = System.Drawing.Color.Crimson;
            this.label_timePlayer1.Location = new System.Drawing.Point(189, 446);
            this.label_timePlayer1.Name = "label_timePlayer1";
            this.label_timePlayer1.Size = new System.Drawing.Size(47, 34);
            this.label_timePlayer1.TabIndex = 16;
            this.label_timePlayer1.Text = "10";
            // 
            // KetNoiLAN_Btn
            // 
            this.KetNoiLAN_Btn.BackColor = System.Drawing.Color.Transparent;
            this.KetNoiLAN_Btn.BorderRadius = 20;
            this.KetNoiLAN_Btn.CheckedState.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.CustomImages.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KetNoiLAN_Btn.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.KetNoiLAN_Btn.ForeColor = System.Drawing.Color.White;
            this.KetNoiLAN_Btn.HoverState.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.Location = new System.Drawing.Point(70, 520);
            this.KetNoiLAN_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KetNoiLAN_Btn.Name = "KetNoiLAN_Btn";
            this.KetNoiLAN_Btn.ShadowDecoration.Parent = this.KetNoiLAN_Btn;
            this.KetNoiLAN_Btn.Size = new System.Drawing.Size(180, 46);
            this.KetNoiLAN_Btn.TabIndex = 18;
            this.KetNoiLAN_Btn.Text = "LAN";
            this.KetNoiLAN_Btn.UseTransparentBackground = true;
            this.KetNoiLAN_Btn.Click += new System.EventHandler(this.KetNoiLAN_Btn_Click);
            // 
            // NewGame_Btn
            // 
            this.NewGame_Btn.BackColor = System.Drawing.Color.Transparent;
            this.NewGame_Btn.BorderRadius = 20;
            this.NewGame_Btn.CheckedState.Parent = this.NewGame_Btn;
            this.NewGame_Btn.CustomImages.Parent = this.NewGame_Btn;
            this.NewGame_Btn.FillColor = System.Drawing.Color.Teal;
            this.NewGame_Btn.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame_Btn.ForeColor = System.Drawing.Color.White;
            this.NewGame_Btn.HoverState.Parent = this.NewGame_Btn;
            this.NewGame_Btn.Location = new System.Drawing.Point(44, 586);
            this.NewGame_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewGame_Btn.Name = "NewGame_Btn";
            this.NewGame_Btn.ShadowDecoration.Parent = this.NewGame_Btn;
            this.NewGame_Btn.Size = new System.Drawing.Size(235, 46);
            this.NewGame_Btn.TabIndex = 19;
            this.NewGame_Btn.Text = "New Game";
            this.NewGame_Btn.UseTransparentBackground = true;
            this.NewGame_Btn.Click += new System.EventHandler(this.NewGame_Btn_Click);
            // 
            // textBox_PlayerIP1
            // 
            this.textBox_PlayerIP1.BackColor = System.Drawing.Color.Transparent;
            this.textBox_PlayerIP1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PlayerIP1.DefaultText = "";
            this.textBox_PlayerIP1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_PlayerIP1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_PlayerIP1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PlayerIP1.DisabledState.Parent = this.textBox_PlayerIP1;
            this.textBox_PlayerIP1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PlayerIP1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PlayerIP1.FocusedState.Parent = this.textBox_PlayerIP1;
            this.textBox_PlayerIP1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_PlayerIP1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PlayerIP1.HoverState.Parent = this.textBox_PlayerIP1;
            this.textBox_PlayerIP1.Location = new System.Drawing.Point(44, 379);
            this.textBox_PlayerIP1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PlayerIP1.Name = "textBox_PlayerIP1";
            this.textBox_PlayerIP1.PasswordChar = '\0';
            this.textBox_PlayerIP1.PlaceholderText = "";
            this.textBox_PlayerIP1.SelectedText = "";
            this.textBox_PlayerIP1.ShadowDecoration.Parent = this.textBox_PlayerIP1;
            this.textBox_PlayerIP1.Size = new System.Drawing.Size(253, 44);
            this.textBox_PlayerIP1.TabIndex = 11;
            // 
            // textBox_PlayerName1
            // 
            this.textBox_PlayerName1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBox_PlayerName1.BackColor = System.Drawing.Color.Transparent;
            this.textBox_PlayerName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PlayerName1.DefaultText = "";
            this.textBox_PlayerName1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_PlayerName1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_PlayerName1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PlayerName1.DisabledState.Parent = this.textBox_PlayerName1;
            this.textBox_PlayerName1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PlayerName1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PlayerName1.FocusedState.Parent = this.textBox_PlayerName1;
            this.textBox_PlayerName1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_PlayerName1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PlayerName1.HoverState.Parent = this.textBox_PlayerName1;
            this.textBox_PlayerName1.Location = new System.Drawing.Point(44, 327);
            this.textBox_PlayerName1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PlayerName1.Name = "textBox_PlayerName1";
            this.textBox_PlayerName1.PasswordChar = '\0';
            this.textBox_PlayerName1.PlaceholderText = "";
            this.textBox_PlayerName1.ReadOnly = true;
            this.textBox_PlayerName1.SelectedText = "";
            this.textBox_PlayerName1.ShadowDecoration.Parent = this.textBox_PlayerName1;
            this.textBox_PlayerName1.Size = new System.Drawing.Size(253, 44);
            this.textBox_PlayerName1.TabIndex = 6;
            // 
            // PlayerMark_pictureBox
            // 
            this.PlayerMark_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerMark_pictureBox.FillColor = System.Drawing.Color.Transparent;
            this.PlayerMark_pictureBox.Location = new System.Drawing.Point(44, 84);
            this.PlayerMark_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerMark_pictureBox.Name = "PlayerMark_pictureBox";
            this.PlayerMark_pictureBox.ShadowDecoration.Parent = this.PlayerMark_pictureBox;
            this.PlayerMark_pictureBox.Size = new System.Drawing.Size(253, 236);
            this.PlayerMark_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerMark_pictureBox.TabIndex = 5;
            this.PlayerMark_pictureBox.TabStop = false;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChatTextBox.DefaultText = "";
            this.ChatTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ChatTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ChatTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChatTextBox.DisabledState.Parent = this.ChatTextBox;
            this.ChatTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChatTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChatTextBox.FocusedState.Parent = this.ChatTextBox;
            this.ChatTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatTextBox.ForeColor = System.Drawing.Color.Black;
            this.ChatTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChatTextBox.HoverState.Parent = this.ChatTextBox;
            this.ChatTextBox.Location = new System.Drawing.Point(1093, 52);
            this.ChatTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.PasswordChar = '\0';
            this.ChatTextBox.PlaceholderText = "";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.SelectedText = "";
            this.ChatTextBox.ShadowDecoration.Parent = this.ChatTextBox;
            this.ChatTextBox.Size = new System.Drawing.Size(471, 679);
            this.ChatTextBox.TabIndex = 21;
            // 
            // SendTextBox
            // 
            this.SendTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SendTextBox.DefaultText = "";
            this.SendTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SendTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SendTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SendTextBox.DisabledState.Parent = this.SendTextBox;
            this.SendTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SendTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SendTextBox.FocusedState.Parent = this.SendTextBox;
            this.SendTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTextBox.ForeColor = System.Drawing.Color.Black;
            this.SendTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SendTextBox.HoverState.Parent = this.SendTextBox;
            this.SendTextBox.Location = new System.Drawing.Point(1093, 737);
            this.SendTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.PasswordChar = '\0';
            this.SendTextBox.PlaceholderText = "";
            this.SendTextBox.SelectedText = "";
            this.SendTextBox.ShadowDecoration.Parent = this.SendTextBox;
            this.SendTextBox.Size = new System.Drawing.Size(385, 36);
            this.SendTextBox.TabIndex = 22;
            // 
            // sendButton
            // 
            this.sendButton.CheckedState.Parent = this.sendButton;
            this.sendButton.CustomImages.Parent = this.sendButton;
            this.sendButton.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.sendButton.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.HoverState.Parent = this.sendButton;
            this.sendButton.Location = new System.Drawing.Point(1484, 735);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.ShadowDecoration.Parent = this.sendButton;
            this.sendButton.Size = new System.Drawing.Size(80, 36);
            this.sendButton.TabIndex = 23;
            this.sendButton.Text = "Send";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Mute_Button
            // 
            this.Mute_Button.BackColor = System.Drawing.Color.Transparent;
            this.Mute_Button.CheckedState.Parent = this.Mute_Button;
            this.Mute_Button.CustomImages.Parent = this.Mute_Button;
            this.Mute_Button.FillColor = System.Drawing.Color.Honeydew;
            this.Mute_Button.FillColor2 = System.Drawing.Color.DarkSeaGreen;
            this.Mute_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Mute_Button.ForeColor = System.Drawing.Color.White;
            this.Mute_Button.HoverState.Parent = this.Mute_Button;
            this.Mute_Button.Image = global::WindowsFormsApp1.Properties.Resources.mute;
            this.Mute_Button.Location = new System.Drawing.Point(12, 739);
            this.Mute_Button.Name = "Mute_Button";
            this.Mute_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Mute_Button.ShadowDecoration.Parent = this.Mute_Button;
            this.Mute_Button.Size = new System.Drawing.Size(39, 38);
            this.Mute_Button.TabIndex = 24;
            this.Mute_Button.Click += new System.EventHandler(this.Mute_Button_Click);
            // 
            // Sound_Button
            // 
            this.Sound_Button.BackColor = System.Drawing.Color.Transparent;
            this.Sound_Button.CheckedState.Parent = this.Sound_Button;
            this.Sound_Button.CustomImages.Parent = this.Sound_Button;
            this.Sound_Button.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.Sound_Button.FillColor2 = System.Drawing.Color.Honeydew;
            this.Sound_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sound_Button.ForeColor = System.Drawing.Color.White;
            this.Sound_Button.HoverState.Parent = this.Sound_Button;
            this.Sound_Button.Image = global::WindowsFormsApp1.Properties.Resources.volume;
            this.Sound_Button.Location = new System.Drawing.Point(12, 739);
            this.Sound_Button.Name = "Sound_Button";
            this.Sound_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Sound_Button.ShadowDecoration.Parent = this.Sound_Button;
            this.Sound_Button.Size = new System.Drawing.Size(39, 38);
            this.Sound_Button.TabIndex = 25;
            this.Sound_Button.Click += new System.EventHandler(this.Sound_Button_Click);
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.Transparent;
            this.quitbtn.BorderRadius = 20;
            this.quitbtn.CheckedState.Parent = this.quitbtn;
            this.quitbtn.CustomImages.Parent = this.quitbtn;
            this.quitbtn.FillColor = System.Drawing.Color.MediumAquamarine;
            this.quitbtn.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold);
            this.quitbtn.ForeColor = System.Drawing.Color.White;
            this.quitbtn.HoverState.Parent = this.quitbtn;
            this.quitbtn.Location = new System.Drawing.Point(44, 654);
            this.quitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.ShadowDecoration.Parent = this.quitbtn;
            this.quitbtn.Size = new System.Drawing.Size(235, 46);
            this.quitbtn.TabIndex = 26;
            this.quitbtn.Text = "Quit";
            this.quitbtn.UseTransparentBackground = true;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // FormPVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1576, 789);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.Sound_Button);
            this.Controls.Add(this.Mute_Button);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.NewGame_Btn);
            this.Controls.Add(this.KetNoiLAN_Btn);
            this.Controls.Add(this.label_timePlayer1);
            this.Controls.Add(this.label_GameTime);
            this.Controls.Add(this.textBox_PlayerIP1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.textBox_PlayerName1);
            this.Controls.Add(this.PlayerMark_pictureBox);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.BanCo_pnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPVP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.FormPVP_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox textBox_PlayerIP1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_PlayerName1;
        private Guna.UI2.WinForms.Guna2PictureBox PlayerMark_pictureBox;
        private Guna.UI2.WinForms.Guna2TextBox ChatTextBox;
        private Guna.UI2.WinForms.Guna2Button sendButton;
        private Guna.UI2.WinForms.Guna2TextBox SendTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public Guna.UI2.WinForms.Guna2GradientCircleButton Mute_Button;
        public Guna.UI2.WinForms.Guna2GradientCircleButton Sound_Button;
        private Guna.UI2.WinForms.Guna2Button quitbtn;
    }
}

