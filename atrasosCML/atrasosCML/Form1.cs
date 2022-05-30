using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atrasosCML
{
    [Serializable]
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {


        List<int> listaMinutosAtraso = new List<int>();
        List<Atrasos> historicoAtrasos = new List<Atrasos>();
        private int totMinutesMesActual = 0;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clearlabels();
            restoreDataFromFile();
            updateLabels();

            if (DateTime.Now.Day == 31 && DateTime.Now.Month == 12)
            {
                resetLabels();
            }
        }

        private void Clearlabels()
        {
            lblTotMinutos.Text = "0";
            lblTotFaltas.Text = "0";
            lbltotminutosMesCorrente.Text = "0";
            barFalta1.Value = 0;
            listaMinutosAtraso.Clear();
            historicoAtrasos.Clear();
        }
        private void resetLabels()
        {
            DialogResult result = MessageBox.Show("De certeza que quer fazer Reset à Aplicação?\n Todos os dados serão eliminados", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lblTotMinutos.Text = "0";
                lblTotFaltas.Text = "0";
                lbltotminutosMesCorrente.Text = "0";
                barFalta1.Value = 0;
                listaMinutosAtraso.Clear();
                historicoAtrasos.Clear();
            }
            else if (result == DialogResult.No)
            {
                this.Focus();
            }
        }

        public int totalMinutosMesCorrente()
        {
            totMinutesMesActual = 0;
            int dataAtrasoMes;
            int dataActualMes;
            foreach (Atrasos atraso in historicoAtrasos)
            {
                dataAtrasoMes = atraso.DataAtraso.Month;
                dataActualMes = DateTime.Now.Month;
                if (dataAtrasoMes == dataActualMes)
                {
                    totMinutesMesActual += atraso.MinutosAtraso;
                }
            }

            return totMinutesMesActual;
        }

        public int GetTotalMinutosAtraso()
        {
            return listaMinutosAtraso.Sum();
        }

        public void AdicionarMinutos(int minutos)
        {
            listaMinutosAtraso.Add(minutos);
        }

        public void AdicionaAtraso(Atrasos atraso)
        {
            historicoAtrasos.Add(atraso);
        }

        public void updateLabels()
        {
            
            int totMin = 0;
            totMin = listaMinutosAtraso.Sum();
            
            lbltotminutosMesCorrente.Text = totalMinutosMesCorrente().ToString();
            lblTotFaltas.Text = "0";
            barFalta1.Value = (totMin);
            lblTotMinutos.Text = totMin.ToString();
            if (totMin >= 420 && totMin < 840) { 
                lblTotFaltas.Text = "1";
            }else if (totMin >= 840 && totMin < 1260)
            {           
                lblTotFaltas.Text = "2";
            }else if (totMin == 1260)
            {
                lblTotFaltas.Text = "3";
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            saveDataToFile();
           this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Minutes gestMinutes = new Minutes(this);
            gestMinutes.ShowDialog();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateLabels();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetLabels();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            historico formHistorico = new historico(historicoAtrasos);
            formHistorico.ShowDialog();
        }


        private void saveDataToFile()
        {
            BinarySerialization.WriteToBinaryFile<List<Atrasos>>(Directory.GetCurrentDirectory() + @"\atrasos.bin", historicoAtrasos);
            BinarySerialization.WriteToBinaryFile<List<int>>(Directory.GetCurrentDirectory() + @"\minutos.bin", listaMinutosAtraso);
        }

        private void restoreDataFromFile()
        {
            List<Atrasos> historicoAtrasosFile = BinarySerialization.ReadFromBinaryFile<List<Atrasos>>(Directory.GetCurrentDirectory() + @"\atrasos.bin");
            List<int> listaMinutosAtrasoFile = BinarySerialization.ReadFromBinaryFile<List<int>>(Directory.GetCurrentDirectory() + @"\minutos.bin");
            historicoAtrasos.AddRange(historicoAtrasosFile);
            listaMinutosAtraso.AddRange(listaMinutosAtrasoFile);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveDataToFile();
        }
    }
}
