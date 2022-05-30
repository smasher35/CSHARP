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
    public partial class historico : MetroFramework.Forms.MetroForm
    {
        public historico(List<Atrasos> historicoAtrasos)
        {
            InitializeComponent();
            dataGridAtrasos.DataSource = historicoAtrasos;
            dataGridFormatter();
        }

        private void historico_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridFormatter()
        {
            DataGridViewColumn data = dataGridAtrasos.Columns[0];
            DataGridViewColumn minutos = dataGridAtrasos.Columns[1];
            DataGridViewColumn totMinutos = dataGridAtrasos.Columns[2];

            dataGridAtrasos.Columns[0].HeaderText = "Data do Atraso";
            dataGridAtrasos.Columns[1].HeaderText = "Minutos de Atraso";
            dataGridAtrasos.Columns[2].HeaderText = "Total de Minutos em Atraso";

            data.Width = 150;
            minutos.Width = 280;
            totMinutos.Width = 280;
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em contrucção!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em contrucção!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
