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
    public partial class editGrades : Form
    {
        private List<Grupo> tempList = new List<Grupo>();
        private int index;
        private frmMain form1;
        public editGrades(int index, frmMain formMain)
        {
            InitializeComponent();
            this.index = index;
            form1 = formMain;
            tempList = form1.getGroups();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            txtGroupName.Text = tempList[index].name;
            txtAluno1.Text = tempList[index].aluno1;
            txtAluno2.Text = tempList[index].aluno2;
            txtAluno3.Text = tempList[index].aluno3;
            txtPresentationGrade.Text = tempList[index].presentationGrade.ToString();
            trckPresentation.Value = tempList[index].presentationGrade;
            txtReportGrade.Text = tempList[index].reportGrade.ToString();
            trckReport.Value = tempList[index].reportGrade;
            txtProjectGrade.Text = tempList[index].projectGrade.ToString();
            trckProject.Value = tempList[index].projectGrade;
            txtFinalGrade.Text = tempList[index].finalGrade.ToString();
            trckFinal.Value = tempList[index].finalGrade;

            txtObs.Text = tempList[index].obs;

        }

        private void frmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trckPresentation_ValueChanged(object sender, EventArgs e)
        {
            txtPresentationGrade.Text = trckPresentation.Value.ToString();
            txtReportGrade.Text = trckReport.Value.ToString();
            txtProjectGrade.Text = trckProject.Value.ToString();
            txtFinalGrade.Text = trckFinal.Value.ToString();
        }
    }
}
