namespace BCryptor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtEncryptedHash = new MetroFramework.Controls.MetroTextBox();
            this.mtPasswordEncrypt = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.mtEncryptedHash2 = new MetroFramework.Controls.MetroTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.mtPwdVerify = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.mbtnAbout = new MetroFramework.Controls.MetroButton();
            this.mbtnExit = new MetroFramework.Controls.MetroButton();
            this.btnCopyHash = new System.Windows.Forms.Button();
            this.btnCopyPwd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(864, 263);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BackColor = System.Drawing.Color.Silver;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.btnCopyHash);
            this.metroPanel2.Controls.Add(this.btnCopyPwd);
            this.metroPanel2.Controls.Add(this.button2);
            this.metroPanel2.Controls.Add(this.button1);
            this.metroPanel2.Controls.Add(this.mtEncryptedHash);
            this.metroPanel2.Controls.Add(this.mtPasswordEncrypt);
            this.metroPanel2.Controls.Add(this.label2);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 329);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(864, 241);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(412, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(412, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "ENCRYPT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtEncryptedHash
            // 
            this.mtEncryptedHash.BackColor = System.Drawing.Color.DimGray;
            // 
            // 
            // 
            this.mtEncryptedHash.CustomButton.Image = null;
            this.mtEncryptedHash.CustomButton.Location = new System.Drawing.Point(758, 1);
            this.mtEncryptedHash.CustomButton.Name = "";
            this.mtEncryptedHash.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtEncryptedHash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtEncryptedHash.CustomButton.TabIndex = 1;
            this.mtEncryptedHash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtEncryptedHash.CustomButton.UseSelectable = true;
            this.mtEncryptedHash.CustomButton.Visible = false;
            this.mtEncryptedHash.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtEncryptedHash.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtEncryptedHash.ForeColor = System.Drawing.Color.Yellow;
            this.mtEncryptedHash.Lines = new string[0];
            this.mtEncryptedHash.Location = new System.Drawing.Point(7, 110);
            this.mtEncryptedHash.MaxLength = 32767;
            this.mtEncryptedHash.Name = "mtEncryptedHash";
            this.mtEncryptedHash.PasswordChar = '\0';
            this.mtEncryptedHash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtEncryptedHash.SelectedText = "";
            this.mtEncryptedHash.SelectionLength = 0;
            this.mtEncryptedHash.SelectionStart = 0;
            this.mtEncryptedHash.ShortcutsEnabled = true;
            this.mtEncryptedHash.Size = new System.Drawing.Size(792, 35);
            this.mtEncryptedHash.TabIndex = 3;
            this.mtEncryptedHash.UseCustomBackColor = true;
            this.mtEncryptedHash.UseCustomForeColor = true;
            this.mtEncryptedHash.UseSelectable = true;
            this.mtEncryptedHash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtEncryptedHash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtPasswordEncrypt
            // 
            // 
            // 
            // 
            this.mtPasswordEncrypt.CustomButton.Image = null;
            this.mtPasswordEncrypt.CustomButton.Location = new System.Drawing.Point(758, 1);
            this.mtPasswordEncrypt.CustomButton.Name = "";
            this.mtPasswordEncrypt.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtPasswordEncrypt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPasswordEncrypt.CustomButton.TabIndex = 1;
            this.mtPasswordEncrypt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPasswordEncrypt.CustomButton.UseSelectable = true;
            this.mtPasswordEncrypt.CustomButton.Visible = false;
            this.mtPasswordEncrypt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtPasswordEncrypt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mtPasswordEncrypt.Lines = new string[] {
        "insert password to encrypt..."};
            this.mtPasswordEncrypt.Location = new System.Drawing.Point(7, 35);
            this.mtPasswordEncrypt.MaxLength = 32767;
            this.mtPasswordEncrypt.Name = "mtPasswordEncrypt";
            this.mtPasswordEncrypt.PasswordChar = '\0';
            this.mtPasswordEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPasswordEncrypt.SelectedText = "";
            this.mtPasswordEncrypt.SelectionLength = 0;
            this.mtPasswordEncrypt.SelectionStart = 0;
            this.mtPasswordEncrypt.ShortcutsEnabled = true;
            this.mtPasswordEncrypt.Size = new System.Drawing.Size(792, 35);
            this.mtPasswordEncrypt.TabIndex = 3;
            this.mtPasswordEncrypt.Text = "insert password to encrypt...";
            this.mtPasswordEncrypt.UseCustomForeColor = true;
            this.mtPasswordEncrypt.UseSelectable = true;
            this.mtPasswordEncrypt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPasswordEncrypt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtPasswordEncrypt.Enter += new System.EventHandler(this.mtPasswordEncrypt_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted Hash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password To Encrypt";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.BackColor = System.Drawing.Color.Silver;
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel3.Controls.Add(this.button4);
            this.metroPanel3.Controls.Add(this.mtEncryptedHash2);
            this.metroPanel3.Controls.Add(this.button3);
            this.metroPanel3.Controls.Add(this.mtPwdVerify);
            this.metroPanel3.Controls.Add(this.label4);
            this.metroPanel3.Controls.Add(this.label3);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 575);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(864, 238);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(412, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "RESET";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mtEncryptedHash2
            // 
            this.mtEncryptedHash2.BackColor = System.Drawing.Color.DimGray;
            // 
            // 
            // 
            this.mtEncryptedHash2.CustomButton.Image = null;
            this.mtEncryptedHash2.CustomButton.Location = new System.Drawing.Point(796, 1);
            this.mtEncryptedHash2.CustomButton.Name = "";
            this.mtEncryptedHash2.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtEncryptedHash2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtEncryptedHash2.CustomButton.TabIndex = 1;
            this.mtEncryptedHash2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtEncryptedHash2.CustomButton.UseSelectable = true;
            this.mtEncryptedHash2.CustomButton.Visible = false;
            this.mtEncryptedHash2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtEncryptedHash2.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtEncryptedHash2.ForeColor = System.Drawing.Color.Yellow;
            this.mtEncryptedHash2.Lines = new string[0];
            this.mtEncryptedHash2.Location = new System.Drawing.Point(7, 107);
            this.mtEncryptedHash2.MaxLength = 32767;
            this.mtEncryptedHash2.Name = "mtEncryptedHash2";
            this.mtEncryptedHash2.PasswordChar = '\0';
            this.mtEncryptedHash2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtEncryptedHash2.SelectedText = "";
            this.mtEncryptedHash2.SelectionLength = 0;
            this.mtEncryptedHash2.SelectionStart = 0;
            this.mtEncryptedHash2.ShortcutsEnabled = true;
            this.mtEncryptedHash2.Size = new System.Drawing.Size(836, 35);
            this.mtEncryptedHash2.TabIndex = 3;
            this.mtEncryptedHash2.UseCustomBackColor = true;
            this.mtEncryptedHash2.UseCustomForeColor = true;
            this.mtEncryptedHash2.UseSelectable = true;
            this.mtEncryptedHash2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtEncryptedHash2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(431, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(412, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "VERIFY";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mtPwdVerify
            // 
            // 
            // 
            // 
            this.mtPwdVerify.CustomButton.Image = null;
            this.mtPwdVerify.CustomButton.Location = new System.Drawing.Point(795, 1);
            this.mtPwdVerify.CustomButton.Name = "";
            this.mtPwdVerify.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtPwdVerify.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPwdVerify.CustomButton.TabIndex = 1;
            this.mtPwdVerify.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPwdVerify.CustomButton.UseSelectable = true;
            this.mtPwdVerify.CustomButton.Visible = false;
            this.mtPwdVerify.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtPwdVerify.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mtPwdVerify.Lines = new string[] {
        "insert password to verify..."};
            this.mtPwdVerify.Location = new System.Drawing.Point(7, 35);
            this.mtPwdVerify.MaxLength = 32767;
            this.mtPwdVerify.Name = "mtPwdVerify";
            this.mtPwdVerify.PasswordChar = '\0';
            this.mtPwdVerify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPwdVerify.SelectedText = "";
            this.mtPwdVerify.SelectionLength = 0;
            this.mtPwdVerify.SelectionStart = 0;
            this.mtPwdVerify.ShortcutsEnabled = true;
            this.mtPwdVerify.Size = new System.Drawing.Size(836, 35);
            this.mtPwdVerify.TabIndex = 3;
            this.mtPwdVerify.Text = "insert password to verify...";
            this.mtPwdVerify.UseCustomForeColor = true;
            this.mtPwdVerify.UseSelectable = true;
            this.mtPwdVerify.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPwdVerify.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Encrypted Hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password To Verify";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.Silver;
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel4.Controls.Add(this.mbtnAbout);
            this.metroPanel4.Controls.Add(this.mbtnExit);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(20, 820);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(864, 60);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // mbtnAbout
            // 
            this.mbtnAbout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mbtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnAbout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnAbout.Location = new System.Drawing.Point(468, 9);
            this.mbtnAbout.Name = "mbtnAbout";
            this.mbtnAbout.Size = new System.Drawing.Size(179, 38);
            this.mbtnAbout.Style = MetroFramework.MetroColorStyle.Black;
            this.mbtnAbout.TabIndex = 3;
            this.mbtnAbout.Text = "ABOUT";
            this.mbtnAbout.UseCustomBackColor = true;
            this.mbtnAbout.UseSelectable = true;
            this.mbtnAbout.UseStyleColors = true;
            this.mbtnAbout.Click += new System.EventHandler(this.mbtnAbout_Click);
            // 
            // mbtnExit
            // 
            this.mbtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnExit.Location = new System.Drawing.Point(664, 9);
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(179, 38);
            this.mbtnExit.Style = MetroFramework.MetroColorStyle.Black;
            this.mbtnExit.TabIndex = 2;
            this.mbtnExit.Text = "EXIT";
            this.mbtnExit.UseCustomBackColor = true;
            this.mbtnExit.UseSelectable = true;
            this.mbtnExit.UseStyleColors = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // btnCopyHash
            // 
            this.btnCopyHash.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCopyHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyHash.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyHash.Image")));
            this.btnCopyHash.Location = new System.Drawing.Point(803, 110);
            this.btnCopyHash.Name = "btnCopyHash";
            this.btnCopyHash.Size = new System.Drawing.Size(40, 35);
            this.btnCopyHash.TabIndex = 5;
            this.toolTip2.SetToolTip(this.btnCopyHash, "Copy Hash To Verify Password");
            this.btnCopyHash.UseVisualStyleBackColor = false;
            this.btnCopyHash.Click += new System.EventHandler(this.btnCopyHash_Click);
            // 
            // btnCopyPwd
            // 
            this.btnCopyPwd.AutoEllipsis = true;
            this.btnCopyPwd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCopyPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyPwd.Image")));
            this.btnCopyPwd.Location = new System.Drawing.Point(803, 35);
            this.btnCopyPwd.Name = "btnCopyPwd";
            this.btnCopyPwd.Size = new System.Drawing.Size(40, 35);
            this.btnCopyPwd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnCopyPwd, "Copy Password to Verify");
            this.btnCopyPwd.UseCompatibleTextRendering = true;
            this.btnCopyPwd.UseVisualStyleBackColor = false;
            this.btnCopyPwd.Click += new System.EventHandler(this.btnCopyPwd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BCryptor.Properties.Resources.encryption_lock;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 900);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "BCryptor - Hash Password Generator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton mbtnAbout;
        private MetroFramework.Controls.MetroButton mbtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox mtEncryptedHash;
        private MetroFramework.Controls.MetroTextBox mtPasswordEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroTextBox mtEncryptedHash2;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroTextBox mtPwdVerify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyHash;
        private System.Windows.Forms.Button btnCopyPwd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

