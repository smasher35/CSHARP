using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;


namespace smileyFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Configurations();
        }

        
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "GYItixO1aP73dL2buz8zA2bpOGXAJVYGYL8x0Xz0",
            BasePath = "https://smileyapp-d2d59-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        


        private void Configurations()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime time = DateTime.Now;
            string password = "Admin2022#";
            statusDateTime.Text = dateTime.ToString("dd/MM/yyyy") + " - " + time.ToString("HH:mm:ss");
            statusMessageBoard.Text = "Clicar no Smiley pretendido para indicar a supa opinião!!";
            statusCopywrite.Text = "©Munícípio de Leiria, por Paulo Penicheiro";
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Abandonar a Aplicação?", "Terminar Apçicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There was a problem with the internet!!");
            }
        }

        private long uniqueValue()
        {
            DateTime dataRnd = DateTime.Now;
            long unique = dataRnd.Ticks;
       
            return unique;
            
        }

        private void btnVeryBad_Click(object sender, EventArgs e)
        {
            setEvaluation(1);
        }


        private async void setEvaluation(int grade)
        {
            DisableButtons();
            long numero = uniqueValue();
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime time = DateTime.Now;
            Eval evaluation = new Eval()
            {
                idEval = numero,
                DataEval = dateTime.ToString("dd/MM/yyyy"),
                HoraEval = time.ToString("HH:mm:ss"),
                GradeEval = grade
            };

            var setter = client.Set("ListaEvals/" + numero, evaluation);
            snackBar.Show(this, "Avaliação Inserida com Sucesso!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,2500, "",
     Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

            await Task.Delay(TimeSpan.FromSeconds(10));
            EnableButtons();

        }

        private void EnableButtons()
        {
            shadowPanelVeryBad.PanelColor = Color.LightGray;
            ShadowPanelBad.PanelColor = Color.LightGray;
            ShadowPanelAverage.PanelColor = Color.LightGray;
            ShadowPanelGood.PanelColor = Color.LightGray;
            ShadowPanelExcelent.PanelColor = Color.LightGray;
            btnVeryBad.Enabled = true;
            btnBad.Enabled = true;
            btnAverage.Enabled = true;
            btnGood.Enabled = true;
            btnExcellent.Enabled = true;
        }

        private void DisableButtons()
        {
            shadowPanelVeryBad.PanelColor = Color.IndianRed;
            ShadowPanelBad.PanelColor = Color.IndianRed;
            ShadowPanelAverage.PanelColor = Color.IndianRed;
            ShadowPanelGood.PanelColor = Color.IndianRed;
            ShadowPanelExcelent.PanelColor = Color.IndianRed;
            btnVeryBad.Enabled = false;    
            btnBad.Enabled = false;
            btnAverage.Enabled = false;
            btnGood.Enabled = false;
            btnExcellent.Enabled = false;
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            setEvaluation(2);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            setEvaluation(3);
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            setEvaluation(4);
        }

        private void btnExcellent_Click(object sender, EventArgs e)
        {
            setEvaluation(5);
        }
    }
}
