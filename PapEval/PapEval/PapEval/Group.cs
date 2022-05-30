using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapEval
{
    public partial class frmGroup : Form
    {
        private int groupId = 0;
        private string GroupName;
        private string _aluno1;
        private string _aluno2;
        private string _aluno3;
        private int _presentationGrade = 0;
        private int _reportGrade = 0;
        private int _projectGrade = 0;
        private int _finalGrade = 0;

        public frmGroup()
        {
            InitializeComponent();
            groupId++; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trckPresentation_ValueChanged(object sender, EventArgs e)
        {
            lblPresentation.Text = trckPresentation.Value.ToString();
           
        }

        private void frmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trckPresentation_Scroll(object sender, EventArgs e)
        {

        }

        private void trckReport_ValueChanged(object sender, EventArgs e)
        {
            lblReport.Text = trckReport.Value.ToString();
            
        }

        private void trckproject_ValueChanged(object sender, EventArgs e)
        {
            lblProject.Text = trckproject.Value.ToString();
            
        }

        private void trckFinalGrade_ValueChanged(object sender, EventArgs e)
        {
            lblFinalGrade.Text = trckFinalGrade.Value.ToString();
            

        }

        private void frmSave_Click(object sender, EventArgs e)
        {
            _presentationGrade = trckPresentation.Value;
            _reportGrade = trckReport.Value;
            _projectGrade = trckproject.Value;
            _finalGrade = trckFinalGrade.Value;


        }
    }
}
