using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PapEval
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGroup newGroup = new frmGroup();
            newGroup.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmGroup newGroup = new frmGroup();
            newGroup.ShowDialog();
        }
    }
}
