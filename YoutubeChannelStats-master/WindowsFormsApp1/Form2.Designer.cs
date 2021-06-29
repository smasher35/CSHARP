namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChannelId = new System.Windows.Forms.TextBox();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.btnPasteChannel = new System.Windows.Forms.Button();
            this.btnPastAPI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioChangeChannelID = new System.Windows.Forms.RadioButton();
            this.radioChangeAPIKey = new System.Windows.Forms.RadioButton();
            this.radioChangeBoth = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wicked Mouse", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "YOUTUBE CHANNEL SETTINGS";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(508, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(655, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Channel ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "API Key";
            // 
            // txtChannelId
            // 
            this.txtChannelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChannelId.Location = new System.Drawing.Point(36, 196);
            this.txtChannelId.Name = "txtChannelId";
            this.txtChannelId.Size = new System.Drawing.Size(711, 29);
            this.txtChannelId.TabIndex = 3;
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPIKey.ForeColor = System.Drawing.Color.Black;
            this.txtAPIKey.Location = new System.Drawing.Point(33, 304);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(714, 29);
            this.txtAPIKey.TabIndex = 4;
            // 
            // btnPasteChannel
            // 
            this.btnPasteChannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasteChannel.Image = ((System.Drawing.Image)(resources.GetObject("btnPasteChannel.Image")));
            this.btnPasteChannel.Location = new System.Drawing.Point(753, 194);
            this.btnPasteChannel.Name = "btnPasteChannel";
            this.btnPasteChannel.Size = new System.Drawing.Size(34, 34);
            this.btnPasteChannel.TabIndex = 5;
            this.btnPasteChannel.UseVisualStyleBackColor = true;
            this.btnPasteChannel.Click += new System.EventHandler(this.btnPasteChannel_Click);
            // 
            // btnPastAPI
            // 
            this.btnPastAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPastAPI.Image = ((System.Drawing.Image)(resources.GetObject("btnPastAPI.Image")));
            this.btnPastAPI.Location = new System.Drawing.Point(753, 301);
            this.btnPastAPI.Name = "btnPastAPI";
            this.btnPastAPI.Size = new System.Drawing.Size(34, 34);
            this.btnPastAPI.TabIndex = 6;
            this.btnPastAPI.Text = "button2";
            this.btnPastAPI.UseVisualStyleBackColor = true;
            this.btnPastAPI.Click += new System.EventHandler(this.btnPastAPI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioChangeBoth);
            this.groupBox1.Controls.Add(this.radioChangeAPIKey);
            this.groupBox1.Controls.Add(this.radioChangeChannelID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioChangeChannelID
            // 
            this.radioChangeChannelID.AutoSize = true;
            this.radioChangeChannelID.Location = new System.Drawing.Point(24, 25);
            this.radioChangeChannelID.Name = "radioChangeChannelID";
            this.radioChangeChannelID.Size = new System.Drawing.Size(184, 24);
            this.radioChangeChannelID.TabIndex = 0;
            this.radioChangeChannelID.TabStop = true;
            this.radioChangeChannelID.Text = "Change Channel ID";
            this.radioChangeChannelID.UseVisualStyleBackColor = true;
            this.radioChangeChannelID.CheckedChanged += new System.EventHandler(this.radioChangeChannelID_CheckedChanged);
            // 
            // radioChangeAPIKey
            // 
            this.radioChangeAPIKey.AutoSize = true;
            this.radioChangeAPIKey.Location = new System.Drawing.Point(337, 25);
            this.radioChangeAPIKey.Name = "radioChangeAPIKey";
            this.radioChangeAPIKey.Size = new System.Drawing.Size(157, 24);
            this.radioChangeAPIKey.TabIndex = 1;
            this.radioChangeAPIKey.TabStop = true;
            this.radioChangeAPIKey.Text = "Change API Key";
            this.radioChangeAPIKey.UseVisualStyleBackColor = true;
            this.radioChangeAPIKey.CheckedChanged += new System.EventHandler(this.radioChangeAPIKey_CheckedChanged);
            // 
            // radioChangeBoth
            // 
            this.radioChangeBoth.AutoSize = true;
            this.radioChangeBoth.Location = new System.Drawing.Point(623, 25);
            this.radioChangeBoth.Name = "radioChangeBoth";
            this.radioChangeBoth.Size = new System.Drawing.Size(132, 24);
            this.radioChangeBoth.TabIndex = 2;
            this.radioChangeBoth.TabStop = true;
            this.radioChangeBoth.Text = "Change Both";
            this.radioChangeBoth.UseVisualStyleBackColor = true;
            this.radioChangeBoth.CheckedChanged += new System.EventHandler(this.radioChangeBoth_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPastAPI);
            this.Controls.Add(this.btnPasteChannel);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.txtChannelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChannelId;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Button btnPasteChannel;
        private System.Windows.Forms.Button btnPastAPI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioChangeBoth;
        private System.Windows.Forms.RadioButton radioChangeAPIKey;
        private System.Windows.Forms.RadioButton radioChangeChannelID;
    }
}