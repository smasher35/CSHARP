namespace Covid_19_pt
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfetadas = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFigueira = new System.Windows.Forms.Label();
            this.LabelAveiro = new System.Windows.Forms.Label();
            this.labelLeiria = new System.Windows.Forms.Label();
            this.labelSantarem = new System.Windows.Forms.Label();
            this.labelCoimbra = new System.Windows.Forms.Label();
            this.labelGuarda = new System.Windows.Forms.Label();
            this.labelViseu = new System.Windows.Forms.Label();
            this.labelBraga = new System.Windows.Forms.Label();
            this.labelPorto = new System.Windows.Forms.Label();
            this.labelEvora = new System.Windows.Forms.Label();
            this.labelBeja = new System.Windows.Forms.Label();
            this.labelFaro = new System.Windows.Forms.Label();
            this.labelSetubal = new System.Windows.Forms.Label();
            this.labelLisboa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelFalecidas = new System.Windows.Forms.Label();
            this.labelRecuperadas = new System.Windows.Forms.Label();
            this.labeltestadas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Bebas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1661, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL DE PESSOAS INFECTADAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelInfetadas
            // 
            this.labelInfetadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfetadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelInfetadas.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfetadas.ForeColor = System.Drawing.Color.White;
            this.labelInfetadas.Location = new System.Drawing.Point(12, 386);
            this.labelInfetadas.Name = "labelInfetadas";
            this.labelInfetadas.Size = new System.Drawing.Size(1661, 234);
            this.labelInfetadas.TabIndex = 1;
            this.labelInfetadas.Text = "0";
            this.labelInfetadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2502, 31);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 24);
            this.toolStripStatusLabel1.Text = "by Paulo Penicheiro";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1970, 24);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(177, 24);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(177, 24);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelFigueira);
            this.panel1.Controls.Add(this.LabelAveiro);
            this.panel1.Controls.Add(this.labelLeiria);
            this.panel1.Controls.Add(this.labelSantarem);
            this.panel1.Controls.Add(this.labelCoimbra);
            this.panel1.Controls.Add(this.labelGuarda);
            this.panel1.Controls.Add(this.labelViseu);
            this.panel1.Controls.Add(this.labelBraga);
            this.panel1.Controls.Add(this.labelPorto);
            this.panel1.Controls.Add(this.labelEvora);
            this.panel1.Controls.Add(this.labelBeja);
            this.panel1.Controls.Add(this.labelFaro);
            this.panel1.Controls.Add(this.labelSetubal);
            this.panel1.Controls.Add(this.labelLisboa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1699, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 1265);
            this.panel1.TabIndex = 3;
            // 
            // labelFigueira
            // 
            this.labelFigueira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelFigueira.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFigueira.ForeColor = System.Drawing.Color.White;
            this.labelFigueira.Location = new System.Drawing.Point(216, 481);
            this.labelFigueira.Name = "labelFigueira";
            this.labelFigueira.Size = new System.Drawing.Size(200, 65);
            this.labelFigueira.TabIndex = 4;
            this.labelFigueira.Text = "label6";
            this.labelFigueira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAveiro
            // 
            this.LabelAveiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelAveiro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAveiro.ForeColor = System.Drawing.Color.White;
            this.LabelAveiro.Location = new System.Drawing.Point(372, 399);
            this.LabelAveiro.Name = "LabelAveiro";
            this.LabelAveiro.Size = new System.Drawing.Size(89, 65);
            this.LabelAveiro.TabIndex = 3;
            this.LabelAveiro.Text = "aveiro";
            this.LabelAveiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLeiria
            // 
            this.labelLeiria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelLeiria.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeiria.ForeColor = System.Drawing.Color.White;
            this.labelLeiria.Location = new System.Drawing.Point(327, 565);
            this.labelLeiria.Name = "labelLeiria";
            this.labelLeiria.Size = new System.Drawing.Size(89, 65);
            this.labelLeiria.TabIndex = 3;
            this.labelLeiria.Text = "Leiria";
            this.labelLeiria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSantarem
            // 
            this.labelSantarem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSantarem.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSantarem.ForeColor = System.Drawing.Color.White;
            this.labelSantarem.Location = new System.Drawing.Point(422, 621);
            this.labelSantarem.Name = "labelSantarem";
            this.labelSantarem.Size = new System.Drawing.Size(122, 65);
            this.labelSantarem.TabIndex = 3;
            this.labelSantarem.Text = "santarem";
            this.labelSantarem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoimbra
            // 
            this.labelCoimbra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCoimbra.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoimbra.ForeColor = System.Drawing.Color.White;
            this.labelCoimbra.Location = new System.Drawing.Point(450, 481);
            this.labelCoimbra.Name = "labelCoimbra";
            this.labelCoimbra.Size = new System.Drawing.Size(134, 65);
            this.labelCoimbra.TabIndex = 3;
            this.labelCoimbra.Text = "coimbra";
            this.labelCoimbra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuarda
            // 
            this.labelGuarda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelGuarda.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuarda.ForeColor = System.Drawing.Color.White;
            this.labelGuarda.Location = new System.Drawing.Point(619, 433);
            this.labelGuarda.Name = "labelGuarda";
            this.labelGuarda.Size = new System.Drawing.Size(89, 65);
            this.labelGuarda.TabIndex = 3;
            this.labelGuarda.Text = "guarda";
            this.labelGuarda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelViseu
            // 
            this.labelViseu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelViseu.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViseu.ForeColor = System.Drawing.Color.White;
            this.labelViseu.Location = new System.Drawing.Point(524, 377);
            this.labelViseu.Name = "labelViseu";
            this.labelViseu.Size = new System.Drawing.Size(89, 65);
            this.labelViseu.TabIndex = 3;
            this.labelViseu.Text = "viseu";
            this.labelViseu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBraga
            // 
            this.labelBraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBraga.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBraga.ForeColor = System.Drawing.Color.White;
            this.labelBraga.Location = new System.Drawing.Point(467, 253);
            this.labelBraga.Name = "labelBraga";
            this.labelBraga.Size = new System.Drawing.Size(89, 65);
            this.labelBraga.TabIndex = 3;
            this.labelBraga.Text = "braga";
            this.labelBraga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPorto
            // 
            this.labelPorto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPorto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorto.ForeColor = System.Drawing.Color.White;
            this.labelPorto.Location = new System.Drawing.Point(372, 311);
            this.labelPorto.Name = "labelPorto";
            this.labelPorto.Size = new System.Drawing.Size(89, 65);
            this.labelPorto.TabIndex = 3;
            this.labelPorto.Text = "porto";
            this.labelPorto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEvora
            // 
            this.labelEvora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelEvora.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvora.ForeColor = System.Drawing.Color.White;
            this.labelEvora.Location = new System.Drawing.Point(514, 758);
            this.labelEvora.Name = "labelEvora";
            this.labelEvora.Size = new System.Drawing.Size(89, 65);
            this.labelEvora.TabIndex = 2;
            this.labelEvora.Text = "Evora";
            this.labelEvora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBeja
            // 
            this.labelBeja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBeja.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeja.ForeColor = System.Drawing.Color.White;
            this.labelBeja.Location = new System.Drawing.Point(514, 882);
            this.labelBeja.Name = "labelBeja";
            this.labelBeja.Size = new System.Drawing.Size(89, 65);
            this.labelBeja.TabIndex = 2;
            this.labelBeja.Text = "Beja";
            this.labelBeja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFaro
            // 
            this.labelFaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelFaro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaro.ForeColor = System.Drawing.Color.White;
            this.labelFaro.Location = new System.Drawing.Point(483, 1035);
            this.labelFaro.Name = "labelFaro";
            this.labelFaro.Size = new System.Drawing.Size(89, 65);
            this.labelFaro.TabIndex = 2;
            this.labelFaro.Text = "Faro";
            this.labelFaro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSetubal
            // 
            this.labelSetubal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSetubal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetubal.ForeColor = System.Drawing.Color.White;
            this.labelSetubal.Location = new System.Drawing.Point(313, 793);
            this.labelSetubal.Name = "labelSetubal";
            this.labelSetubal.Size = new System.Drawing.Size(121, 65);
            this.labelSetubal.TabIndex = 2;
            this.labelSetubal.Text = "setubal";
            this.labelSetubal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLisboa
            // 
            this.labelLisboa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelLisboa.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLisboa.ForeColor = System.Drawing.Color.White;
            this.labelLisboa.Location = new System.Drawing.Point(309, 686);
            this.labelLisboa.Name = "labelLisboa";
            this.labelLisboa.Size = new System.Drawing.Size(89, 65);
            this.labelLisboa.TabIndex = 2;
            this.labelLisboa.Text = "lisboa";
            this.labelLisboa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "INFECTADOS POR ZONAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 1263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2502, 78);
            this.panel2.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(2097, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(186, 59);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(778, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fonte: https://covid19.min-saude.pt/ponto-de-situacao-atual-em-portugal";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(2298, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 59);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelFalecidas);
            this.panel3.Controls.Add(this.labelRecuperadas);
            this.panel3.Controls.Add(this.labeltestadas);
            this.panel3.Controls.Add(this.labelInfetadas);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1693, 1265);
            this.panel3.TabIndex = 5;
            // 
            // labelFalecidas
            // 
            this.labelFalecidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFalecidas.BackColor = System.Drawing.Color.DarkRed;
            this.labelFalecidas.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFalecidas.ForeColor = System.Drawing.Color.White;
            this.labelFalecidas.Location = new System.Drawing.Point(12, 1014);
            this.labelFalecidas.Name = "labelFalecidas";
            this.labelFalecidas.Size = new System.Drawing.Size(1661, 234);
            this.labelFalecidas.TabIndex = 1;
            this.labelFalecidas.Text = "0";
            this.labelFalecidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecuperadas
            // 
            this.labelRecuperadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecuperadas.BackColor = System.Drawing.Color.Green;
            this.labelRecuperadas.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecuperadas.ForeColor = System.Drawing.Color.White;
            this.labelRecuperadas.Location = new System.Drawing.Point(12, 700);
            this.labelRecuperadas.Name = "labelRecuperadas";
            this.labelRecuperadas.Size = new System.Drawing.Size(1661, 234);
            this.labelRecuperadas.TabIndex = 1;
            this.labelRecuperadas.Text = "0";
            this.labelRecuperadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltestadas
            // 
            this.labeltestadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltestadas.BackColor = System.Drawing.Color.SkyBlue;
            this.labeltestadas.Font = new System.Drawing.Font("Bebas", 89.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltestadas.ForeColor = System.Drawing.Color.White;
            this.labeltestadas.Location = new System.Drawing.Point(12, 68);
            this.labeltestadas.Name = "labeltestadas";
            this.labeltestadas.Size = new System.Drawing.Size(1661, 241);
            this.labeltestadas.TabIndex = 1;
            this.labeltestadas.Text = "0";
            this.labeltestadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeltestadas.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Bebas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 949);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1661, 65);
            this.label7.TabIndex = 0;
            this.label7.Text = "TOTAL DE PESSOAS FALECIDAS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Bebas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1661, 65);
            this.label5.TabIndex = 0;
            this.label5.Text = "TOTAL DE PESSOAS TESTADAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Bebas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1661, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL DE PESSOAS RECUPERADAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(2502, 1383);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COVID-19 PORTUGAL LIVE STATS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfetadas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelRecuperadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labeltestadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFalecidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Label labelLisboa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPorto;
        private System.Windows.Forms.Label LabelAveiro;
        private System.Windows.Forms.Label labelLeiria;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelBraga;
        private System.Windows.Forms.Label labelFaro;
        private System.Windows.Forms.Label labelCoimbra;
        private System.Windows.Forms.Label labelEvora;
        private System.Windows.Forms.Label labelBeja;
        private System.Windows.Forms.Label labelSantarem;
        private System.Windows.Forms.Label labelGuarda;
        private System.Windows.Forms.Label labelViseu;
        private System.Windows.Forms.Label labelSetubal;
        private System.Windows.Forms.Label labelFigueira;
    }
}

