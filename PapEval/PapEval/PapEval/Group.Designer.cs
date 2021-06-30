
namespace PapEval
{
    partial class frmGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmCancel = new System.Windows.Forms.Button();
            this.frmSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblPresentation = new System.Windows.Forms.Label();
            this.trckFinalGrade = new System.Windows.Forms.TrackBar();
            this.trckproject = new System.Windows.Forms.TrackBar();
            this.trckReport = new System.Windows.Forms.TrackBar();
            this.trckPresentation = new System.Windows.Forms.TrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAlunos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpGroupName = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckFinalGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckproject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckPresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAlunos.SuspendLayout();
            this.grpGroupName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.frmCancel);
            this.panel1.Controls.Add(this.frmSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 806);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 73);
            this.panel1.TabIndex = 0;
            // 
            // frmCancel
            // 
            this.frmCancel.BackColor = System.Drawing.Color.DarkRed;
            this.frmCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmCancel.Location = new System.Drawing.Point(358, 15);
            this.frmCancel.Name = "frmCancel";
            this.frmCancel.Size = new System.Drawing.Size(132, 45);
            this.frmCancel.TabIndex = 0;
            this.frmCancel.Text = "CANCEL";
            this.frmCancel.UseVisualStyleBackColor = false;
            this.frmCancel.Click += new System.EventHandler(this.frmCancel_Click);
            // 
            // frmSave
            // 
            this.frmSave.BackColor = System.Drawing.Color.Green;
            this.frmSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.frmSave.Location = new System.Drawing.Point(496, 15);
            this.frmSave.Name = "frmSave";
            this.frmSave.Size = new System.Drawing.Size(132, 45);
            this.frmSave.TabIndex = 0;
            this.frmSave.Text = "SAVE";
            this.frmSave.UseVisualStyleBackColor = false;
            this.frmSave.Click += new System.EventHandler(this.frmSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.grpAlunos);
            this.panel2.Controls.Add(this.grpGroupName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 806);
            this.panel2.TabIndex = 1;
            this.panel2.Enter += new System.EventHandler(this.panel2_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 610);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 190);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OBSERVATIONS";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(7, 22);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(599, 162);
            this.textBox5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFinalGrade);
            this.groupBox1.Controls.Add(this.lblProject);
            this.groupBox1.Controls.Add(this.lblReport);
            this.groupBox1.Controls.Add(this.lblPresentation);
            this.groupBox1.Controls.Add(this.trckFinalGrade);
            this.groupBox1.Controls.Add(this.trckproject);
            this.groupBox1.Controls.Add(this.trckReport);
            this.groupBox1.Controls.Add(this.trckPresentation);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRADES";
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFinalGrade.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalGrade.ForeColor = System.Drawing.Color.Gold;
            this.lblFinalGrade.Location = new System.Drawing.Point(524, 213);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(60, 54);
            this.lblFinalGrade.TabIndex = 3;
            this.lblFinalGrade.Text = "0";
            this.lblFinalGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProject
            // 
            this.lblProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProject.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProject.ForeColor = System.Drawing.Color.Gold;
            this.lblProject.Location = new System.Drawing.Point(524, 153);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(60, 54);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "0";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReport
            // 
            this.lblReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReport.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReport.ForeColor = System.Drawing.Color.Gold;
            this.lblReport.Location = new System.Drawing.Point(524, 92);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(60, 54);
            this.lblReport.TabIndex = 3;
            this.lblReport.Text = "0";
            this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresentation
            // 
            this.lblPresentation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPresentation.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPresentation.ForeColor = System.Drawing.Color.Gold;
            this.lblPresentation.Location = new System.Drawing.Point(524, 31);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(60, 54);
            this.lblPresentation.TabIndex = 3;
            this.lblPresentation.Text = "0";
            this.lblPresentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trckFinalGrade
            // 
            this.trckFinalGrade.LargeChange = 1;
            this.trckFinalGrade.Location = new System.Drawing.Point(217, 225);
            this.trckFinalGrade.Maximum = 20;
            this.trckFinalGrade.Minimum = 1;
            this.trckFinalGrade.Name = "trckFinalGrade";
            this.trckFinalGrade.Size = new System.Drawing.Size(247, 45);
            this.trckFinalGrade.TabIndex = 2;
            this.trckFinalGrade.Value = 1;
            this.trckFinalGrade.ValueChanged += new System.EventHandler(this.trckFinalGrade_ValueChanged);
            // 
            // trckproject
            // 
            this.trckproject.LargeChange = 1;
            this.trckproject.Location = new System.Drawing.Point(217, 165);
            this.trckproject.Maximum = 20;
            this.trckproject.Minimum = 1;
            this.trckproject.Name = "trckproject";
            this.trckproject.Size = new System.Drawing.Size(247, 45);
            this.trckproject.TabIndex = 2;
            this.trckproject.Value = 1;
            this.trckproject.ValueChanged += new System.EventHandler(this.trckproject_ValueChanged);
            // 
            // trckReport
            // 
            this.trckReport.LargeChange = 1;
            this.trckReport.Location = new System.Drawing.Point(217, 106);
            this.trckReport.Maximum = 20;
            this.trckReport.Minimum = 1;
            this.trckReport.Name = "trckReport";
            this.trckReport.Size = new System.Drawing.Size(247, 45);
            this.trckReport.TabIndex = 2;
            this.trckReport.Value = 1;
            this.trckReport.ValueChanged += new System.EventHandler(this.trckReport_ValueChanged);
            // 
            // trckPresentation
            // 
            this.trckPresentation.LargeChange = 1;
            this.trckPresentation.Location = new System.Drawing.Point(217, 46);
            this.trckPresentation.Maximum = 20;
            this.trckPresentation.Minimum = 1;
            this.trckPresentation.Name = "trckPresentation";
            this.trckPresentation.Size = new System.Drawing.Size(247, 45);
            this.trckPresentation.TabIndex = 2;
            this.trckPresentation.Value = 1;
            this.trckPresentation.Scroll += new System.EventHandler(this.trckPresentation_Scroll);
            this.trckPresentation.ValueChanged += new System.EventHandler(this.trckPresentation_ValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 221);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "PROJECT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "FINAL GRADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "REPORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "PRESENTATION";
            // 
            // grpAlunos
            // 
            this.grpAlunos.Controls.Add(this.label3);
            this.grpAlunos.Controls.Add(this.label2);
            this.grpAlunos.Controls.Add(this.label1);
            this.grpAlunos.Controls.Add(this.textBox4);
            this.grpAlunos.Controls.Add(this.textBox3);
            this.grpAlunos.Controls.Add(this.textBox2);
            this.grpAlunos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAlunos.Location = new System.Drawing.Point(12, 81);
            this.grpAlunos.Name = "grpAlunos";
            this.grpAlunos.Size = new System.Drawing.Size(616, 235);
            this.grpAlunos.TabIndex = 3;
            this.grpAlunos.TabStop = false;
            this.grpAlunos.Text = "STUDENTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student 3";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student 2";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(6, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(600, 27);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(6, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(600, 27);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(7, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(600, 27);
            this.textBox2.TabIndex = 0;
            // 
            // grpGroupName
            // 
            this.grpGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGroupName.Controls.Add(this.textBox1);
            this.grpGroupName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpGroupName.Location = new System.Drawing.Point(12, 13);
            this.grpGroupName.Name = "grpGroupName";
            this.grpGroupName.Size = new System.Drawing.Size(616, 65);
            this.grpGroupName.TabIndex = 2;
            this.grpGroupName.TabStop = false;
            this.grpGroupName.Text = "GROUP NAME";
            this.grpGroupName.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(6, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 23);
            this.textBox1.TabIndex = 1;
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(640, 879);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Group";
            this.Shown += new System.EventHandler(this.frmGroup_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckFinalGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckproject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckPresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAlunos.ResumeLayout(false);
            this.grpAlunos.PerformLayout();
            this.grpGroupName.ResumeLayout(false);
            this.grpGroupName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button frmCancel;
        private System.Windows.Forms.Button frmSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpGroupName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFinalGrade;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblPresentation;
        private System.Windows.Forms.TrackBar trckFinalGrade;
        private System.Windows.Forms.TrackBar trckproject;
        private System.Windows.Forms.TrackBar trckReport;
        private System.Windows.Forms.TrackBar trckPresentation;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}