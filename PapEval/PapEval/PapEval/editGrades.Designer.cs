
namespace PapEval
{
    partial class editGrades
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmCancel = new System.Windows.Forms.Button();
            this.frmSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trckPresentation = new System.Windows.Forms.TrackBar();
            this.trckFinal = new System.Windows.Forms.TrackBar();
            this.trckProject = new System.Windows.Forms.TrackBar();
            this.trckReport = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.txtProjectGrade = new System.Windows.Forms.TextBox();
            this.txtReportGrade = new System.Windows.Forms.TextBox();
            this.txtPresentationGrade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAluno3 = new System.Windows.Forms.TextBox();
            this.txtAluno2 = new System.Windows.Forms.TextBox();
            this.txtAluno1 = new System.Windows.Forms.TextBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckPresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.frmCancel);
            this.panel1.Controls.Add(this.frmSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 752);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 59);
            this.panel1.TabIndex = 0;
            // 
            // frmCancel
            // 
            this.frmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmCancel.BackColor = System.Drawing.Color.DarkRed;
            this.frmCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmCancel.Location = new System.Drawing.Point(903, 7);
            this.frmCancel.Name = "frmCancel";
            this.frmCancel.Size = new System.Drawing.Size(132, 45);
            this.frmCancel.TabIndex = 1;
            this.frmCancel.Text = "CANCEL";
            this.frmCancel.UseVisualStyleBackColor = false;
            this.frmCancel.Click += new System.EventHandler(this.frmCancel_Click);
            // 
            // frmSave
            // 
            this.frmSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmSave.BackColor = System.Drawing.Color.Green;
            this.frmSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmSave.Enabled = false;
            this.frmSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.frmSave.Location = new System.Drawing.Point(1041, 7);
            this.frmSave.Name = "frmSave";
            this.frmSave.Size = new System.Drawing.Size(132, 45);
            this.frmSave.TabIndex = 2;
            this.frmSave.Text = "SAVE";
            this.frmSave.UseVisualStyleBackColor = false;
            this.frmSave.Click += new System.EventHandler(this.frmSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 752);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 587);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 159);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OBSERVATIONS";
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtObs.ForeColor = System.Drawing.Color.Gold;
            this.txtObs.Location = new System.Drawing.Point(6, 35);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(1148, 118);
            this.txtObs.TabIndex = 0;
            this.txtObs.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trckPresentation);
            this.groupBox2.Controls.Add(this.trckFinal);
            this.groupBox2.Controls.Add(this.trckProject);
            this.groupBox2.Controls.Add(this.trckReport);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFinalGrade);
            this.groupBox2.Controls.Add(this.txtProjectGrade);
            this.groupBox2.Controls.Add(this.txtReportGrade);
            this.groupBox2.Controls.Add(this.txtPresentationGrade);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 296);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GRADES";
            // 
            // trckPresentation
            // 
            this.trckPresentation.Location = new System.Drawing.Point(98, 243);
            this.trckPresentation.Maximum = 20;
            this.trckPresentation.Minimum = 1;
            this.trckPresentation.Name = "trckPresentation";
            this.trckPresentation.Size = new System.Drawing.Size(202, 45);
            this.trckPresentation.TabIndex = 2;
            this.trckPresentation.Value = 1;
            this.trckPresentation.ValueChanged += new System.EventHandler(this.trckPresentation_ValueChanged);
            // 
            // trckFinal
            // 
            this.trckFinal.Location = new System.Drawing.Point(854, 243);
            this.trckFinal.Maximum = 20;
            this.trckFinal.Minimum = 1;
            this.trckFinal.Name = "trckFinal";
            this.trckFinal.Size = new System.Drawing.Size(202, 45);
            this.trckFinal.TabIndex = 2;
            this.trckFinal.Value = 1;
            this.trckFinal.ValueChanged += new System.EventHandler(this.trckPresentation_ValueChanged);
            // 
            // trckProject
            // 
            this.trckProject.Location = new System.Drawing.Point(602, 243);
            this.trckProject.Maximum = 20;
            this.trckProject.Minimum = 1;
            this.trckProject.Name = "trckProject";
            this.trckProject.Size = new System.Drawing.Size(202, 45);
            this.trckProject.TabIndex = 2;
            this.trckProject.Value = 1;
            this.trckProject.ValueChanged += new System.EventHandler(this.trckPresentation_ValueChanged);
            // 
            // trckReport
            // 
            this.trckReport.Location = new System.Drawing.Point(350, 243);
            this.trckReport.Maximum = 20;
            this.trckReport.Minimum = 1;
            this.trckReport.Name = "trckReport";
            this.trckReport.Size = new System.Drawing.Size(202, 45);
            this.trckReport.TabIndex = 2;
            this.trckReport.Value = 1;
            this.trckReport.ValueChanged += new System.EventHandler(this.trckPresentation_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(126, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "PRESENTATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(887, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "FINAL GRADE";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(653, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "PROJECT";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(407, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "REPORT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.BackColor = System.Drawing.Color.IndianRed;
            this.txtFinalGrade.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFinalGrade.Location = new System.Drawing.Point(854, 48);
            this.txtFinalGrade.Multiline = true;
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.ReadOnly = true;
            this.txtFinalGrade.Size = new System.Drawing.Size(202, 184);
            this.txtFinalGrade.TabIndex = 0;
            this.txtFinalGrade.Text = "17";
            this.txtFinalGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProjectGrade
            // 
            this.txtProjectGrade.BackColor = System.Drawing.Color.LimeGreen;
            this.txtProjectGrade.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProjectGrade.Location = new System.Drawing.Point(602, 48);
            this.txtProjectGrade.Multiline = true;
            this.txtProjectGrade.Name = "txtProjectGrade";
            this.txtProjectGrade.ReadOnly = true;
            this.txtProjectGrade.Size = new System.Drawing.Size(202, 184);
            this.txtProjectGrade.TabIndex = 0;
            this.txtProjectGrade.Text = "15";
            this.txtProjectGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReportGrade
            // 
            this.txtReportGrade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtReportGrade.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReportGrade.Location = new System.Drawing.Point(350, 48);
            this.txtReportGrade.Multiline = true;
            this.txtReportGrade.Name = "txtReportGrade";
            this.txtReportGrade.ReadOnly = true;
            this.txtReportGrade.Size = new System.Drawing.Size(202, 184);
            this.txtReportGrade.TabIndex = 0;
            this.txtReportGrade.Text = "18";
            this.txtReportGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPresentationGrade
            // 
            this.txtPresentationGrade.BackColor = System.Drawing.Color.Gold;
            this.txtPresentationGrade.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPresentationGrade.Location = new System.Drawing.Point(98, 48);
            this.txtPresentationGrade.Multiline = true;
            this.txtPresentationGrade.Name = "txtPresentationGrade";
            this.txtPresentationGrade.ReadOnly = true;
            this.txtPresentationGrade.Size = new System.Drawing.Size(202, 184);
            this.txtPresentationGrade.TabIndex = 0;
            this.txtPresentationGrade.Text = "20";
            this.txtPresentationGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAluno3);
            this.groupBox1.Controls.Add(this.txtAluno2);
            this.groupBox1.Controls.Add(this.txtAluno1);
            this.groupBox1.Controls.Add(this.txtGroupName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERAL DATA";
            // 
            // txtAluno3
            // 
            this.txtAluno3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAluno3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAluno3.ForeColor = System.Drawing.Color.Gold;
            this.txtAluno3.Location = new System.Drawing.Point(488, 208);
            this.txtAluno3.Name = "txtAluno3";
            this.txtAluno3.Size = new System.Drawing.Size(651, 39);
            this.txtAluno3.TabIndex = 2;
            this.txtAluno3.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // txtAluno2
            // 
            this.txtAluno2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAluno2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAluno2.ForeColor = System.Drawing.Color.Gold;
            this.txtAluno2.Location = new System.Drawing.Point(488, 133);
            this.txtAluno2.Name = "txtAluno2";
            this.txtAluno2.Size = new System.Drawing.Size(651, 39);
            this.txtAluno2.TabIndex = 2;
            this.txtAluno2.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // txtAluno1
            // 
            this.txtAluno1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAluno1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAluno1.ForeColor = System.Drawing.Color.Gold;
            this.txtAluno1.Location = new System.Drawing.Point(488, 58);
            this.txtAluno1.Name = "txtAluno1";
            this.txtAluno1.Size = new System.Drawing.Size(651, 39);
            this.txtAluno1.TabIndex = 2;
            this.txtAluno1.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGroupName.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGroupName.ForeColor = System.Drawing.Color.Gold;
            this.txtGroupName.Location = new System.Drawing.Point(6, 58);
            this.txtGroupName.Multiline = true;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(474, 189);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(488, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Student #2";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(488, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student #3";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(488, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student #1";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // editGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "editGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse / Edit - Groups";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckPresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button frmCancel;
        private System.Windows.Forms.Button frmSave;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPresentationGrade;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private System.Windows.Forms.TextBox txtProjectGrade;
        private System.Windows.Forms.TextBox txtReportGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAluno3;
        private System.Windows.Forms.TextBox txtAluno2;
        private System.Windows.Forms.TextBox txtAluno1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TrackBar trckPresentation;
        private System.Windows.Forms.TrackBar trckFinal;
        private System.Windows.Forms.TrackBar trckProject;
        private System.Windows.Forms.TrackBar trckReport;
    }
}