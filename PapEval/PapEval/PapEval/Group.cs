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
        private int _groupId = 0;
        private string _groupName = string.Empty;
        private string _aluno1 = string.Empty;
        private string _aluno2 = string.Empty;
        private string _aluno3 = string.Empty;
        private int _presentationGrade = 0;
        private int _reportGrade = 0;
        private int _projectGrade = 0;
        private int _finalGrade = 0;
        private string _observations = string.Empty;
        private frmMain form1;

        public frmGroup(frmMain form)
        {
            InitializeComponent();
            this.form1 = form;
            

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
            //GENERAL DATA
            _groupId = form1.totAlunos() + 1;
            _groupName = textBox1.Text;
            _aluno1 = textBox2.Text;
            _aluno2 = textBox3.Text;
            _aluno3 = textBox4.Text;
            //GRADES
            _presentationGrade = trckPresentation.Value;
            _reportGrade = trckReport.Value;
            _projectGrade = trckproject.Value;
            _finalGrade = trckFinalGrade.Value;
            //OBSERVATIONS
            _observations = textBox5.Text;


            if ((_groupName.Length == 0 || _aluno1.Length == 0) || (trckPresentation.Value == 1 || trckReport.Value == 1 || trckproject.Value ==1 || trckFinalGrade.Value == 1))
            {
                MessageBox.Show("Fill the mandatory Fields!!!", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                Grupo myGrupo = new Grupo();
                myGrupo.id = _groupId;
                myGrupo.name = _groupName;
                myGrupo.aluno1 = _aluno1;
                myGrupo.aluno2 = _aluno2;
                myGrupo.aluno3 = _aluno3;
                myGrupo.presentationGrade = _presentationGrade;
                myGrupo.reportGrade = _reportGrade;
                myGrupo.projectGrade = _projectGrade;
                myGrupo.finalGrade = _finalGrade;
                myGrupo.obs = _observations;

                form1.AddGroups(myGrupo);

                this.Close();
            }
           
        }

        private void panel2_Enter(object sender, EventArgs e)
        {
            
    }

        private void frmGroup_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
