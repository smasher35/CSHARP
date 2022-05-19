using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atrasosCML
{
    public partial class Minutes : MetroFramework.Forms.MetroForm
    {
        Form1 fm1;
        private int totMinutes = 0;
        public Minutes(Form1 parent)
        {
            InitializeComponent();
            fm1 = parent;
        }

       
        

        private void minutes_Load(object sender, EventArgs e)
        {
            addMinutes.Text = "";
            rmvMinutes.Text = "";

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnremoveMinutes_Click(object sender, EventArgs e)
        {
            if (rmvMinutes.Text == "")
            {
                MessageBox.Show("Tem de preencher os minutos de atraso a remover, e o valor tem de ser superior a 0", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                rmvMinutes.Focus();
                rmvMinutes.Value = 1;
            }
            else
            {
                Atrasos novoAtraso = new Atrasos(DateTime.Now, ((int)rmvMinutes.Value * (-1)));
                int minutes = ((int)rmvMinutes.Value * (-1));
                fm1.AdicionarMinutos(minutes);
                novoAtraso.ActualizarTotMinutos(fm1.GetTotalMinutosAtraso());
                fm1.AdicionaAtraso(novoAtraso);
                fm1.updateLabels();
                this.Close();
            }
            
        }

        private void btnAdicionarMinutos_Click(object sender, EventArgs e)
        {
            if (addMinutes.Text == "")
            {
                MessageBox.Show("Tem de preencher os minutos de atraso a adicionar, e o valor tem de ser superior a 0", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                addMinutes.Focus();
                addMinutes.Value = 1;
            }
            else
            {
                Atrasos novoAtraso = new Atrasos(DateTime.Now, (int)addMinutes.Value);
                int minutes = (int)addMinutes.Value;
                fm1.AdicionarMinutos(minutes);
                novoAtraso.ActualizarTotMinutos(fm1.GetTotalMinutosAtraso());
                fm1.AdicionaAtraso(novoAtraso);
                fm1.updateLabels();
                this.Close();
            }
        }
    }
}
