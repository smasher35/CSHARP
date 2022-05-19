namespace atrasosCML
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.tileAcumulado = new MetroFramework.Controls.MetroTile();
            this.lblTotMinutos = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblTotFaltas = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tileMesAtual = new MetroFramework.Controls.MetroTile();
            this.lbltotminutosMesCorrente = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.barFalta1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.tileAcumulado.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTile1.SuspendLayout();
            this.tileMesAtual.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroPanel1.Controls.Add(this.btnReset);
            this.metroPanel1.Controls.Add(this.btnUpdate);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.btnExit);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 46);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReset.Location = new System.Drawing.Point(354, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 46);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "RESET";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Location = new System.Drawing.Point(236, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 46);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButton2.Location = new System.Drawing.Point(118, 0);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(118, 46);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "HISTÓRICO ATRASOS";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 46);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "GESTÃO MINUTOS";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(671, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 46);
            this.btnExit.Style = MetroFramework.MetroColorStyle.Red;
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "SAIR";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tileAcumulado
            // 
            this.tileAcumulado.Controls.Add(this.lblTotMinutos);
            this.tileAcumulado.Location = new System.Drawing.Point(13, 60);
            this.tileAcumulado.Name = "tileAcumulado";
            this.tileAcumulado.Size = new System.Drawing.Size(219, 219);
            this.tileAcumulado.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileAcumulado.TabIndex = 2;
            this.tileAcumulado.Text = "MINUTOS";
            this.tileAcumulado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileAcumulado.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAcumulado.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // lblTotMinutos
            // 
            this.lblTotMinutos.BackColor = System.Drawing.Color.Transparent;
            this.lblTotMinutos.Font = new System.Drawing.Font("Anton", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotMinutos.ForeColor = System.Drawing.Color.White;
            this.lblTotMinutos.Location = new System.Drawing.Point(3, 0);
            this.lblTotMinutos.Name = "lblTotMinutos";
            this.lblTotMinutos.Size = new System.Drawing.Size(213, 190);
            this.lblTotMinutos.TabIndex = 0;
            this.lblTotMinutos.Text = "419";
            this.lblTotMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroTile1);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.tileMesAtual);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.tileAcumulado);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 106);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(760, 448);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(563, 23);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(169, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "FALTAS INJUSTIFICADAS";
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Controls.Add(this.lblTotFaltas);
            this.metroTile1.Location = new System.Drawing.Point(538, 61);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(219, 219);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "TOTAL";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // lblTotFaltas
            // 
            this.lblTotFaltas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotFaltas.Font = new System.Drawing.Font("Anton", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotFaltas.ForeColor = System.Drawing.Color.White;
            this.lblTotFaltas.Location = new System.Drawing.Point(3, 3);
            this.lblTotFaltas.Name = "lblTotFaltas";
            this.lblTotFaltas.Size = new System.Drawing.Size(213, 186);
            this.lblTotFaltas.TabIndex = 0;
            this.lblTotFaltas.Text = "2";
            this.lblTotFaltas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(285, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(153, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "MINUTOS MÊS ATUAL";
            // 
            // tileMesAtual
            // 
            this.tileMesAtual.Controls.Add(this.lbltotminutosMesCorrente);
            this.tileMesAtual.Location = new System.Drawing.Point(252, 60);
            this.tileMesAtual.Name = "tileMesAtual";
            this.tileMesAtual.Size = new System.Drawing.Size(219, 219);
            this.tileMesAtual.Style = MetroFramework.MetroColorStyle.Brown;
            this.tileMesAtual.TabIndex = 4;
            this.tileMesAtual.Text = "MINUTOS";
            this.tileMesAtual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileMesAtual.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileMesAtual.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // lbltotminutosMesCorrente
            // 
            this.lbltotminutosMesCorrente.BackColor = System.Drawing.Color.Transparent;
            this.lbltotminutosMesCorrente.Font = new System.Drawing.Font("Anton", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotminutosMesCorrente.ForeColor = System.Drawing.Color.White;
            this.lbltotminutosMesCorrente.Location = new System.Drawing.Point(1, 1);
            this.lbltotminutosMesCorrente.Name = "lbltotminutosMesCorrente";
            this.lbltotminutosMesCorrente.Size = new System.Drawing.Size(215, 189);
            this.lbltotminutosMesCorrente.TabIndex = 0;
            this.lbltotminutosMesCorrente.Text = "56";
            this.lbltotminutosMesCorrente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(12, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(220, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "TOTAL MINUTOS ACUMULADOS";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.barFalta1);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.panel1);
            this.metroPanel3.Controls.Add(this.panel2);
            this.metroPanel3.Controls.Add(this.panel3);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 407);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(760, 147);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // barFalta1
            // 
            this.barFalta1.Location = new System.Drawing.Point(12, 76);
            this.barFalta1.Maximum = 1260;
            this.barFalta1.Name = "barFalta1";
            this.barFalta1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.barFalta1.Size = new System.Drawing.Size(731, 30);
            this.barFalta1.Step = 1;
            this.barFalta1.Style = MetroFramework.MetroColorStyle.Teal;
            this.barFalta1.TabIndex = 3;
            this.barFalta1.Value = 420;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(13, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(222, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "FALTAS INJUSTIFICADAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(499, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 100);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "3ª FALTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(255, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 100);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "2ª FALTA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 100);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "1ª FALTA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Atrasos CML - Artigo 56º";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.tileAcumulado.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTile1.ResumeLayout(false);
            this.tileMesAtual.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroTile tileAcumulado;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile tileMesAtual;
        private MetroFramework.Controls.MetroProgressBar barFalta1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label lblTotMinutos;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label lblTotFaltas;
        private System.Windows.Forms.Label lbltotminutosMesCorrente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnReset;
    }
}

