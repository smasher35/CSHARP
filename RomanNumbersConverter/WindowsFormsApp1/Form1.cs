using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        List<string> KnownRomanNumersList = new List<string>() { "1","2","3","5","10","50","100","500","1000"};
        string[] romanNumbers = { "I", "II", "III", "V", "X", "L", "C", "D", "M" };
        public frmMain()
        {
            InitializeComponent();
            ConvertCurrentYear();
            InitStatusLabels();
            GetCurrentTime();
            
        }

        private void GetCurrentTime()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string HoraHoje;
            HoraHoje = DateTime.Now.ToString("h:mm:ss tt");
            toolStripStatusDate.Text = GetCurrentDate() + " - " + HoraHoje;

        }


        private string GetCurrentDate()
        {
            string DataHoje;
            DataHoje = DateTime.Now.ToString("d/MMM/yyyy"); ;
            return DataHoje;
        }

        private void InitStatusLabels()
        {
            toolStripStatusVersion.Text = "RomanConverter V 1.0 by Paulo Penicheiro";
            toolStripStatusMessages.Text = "Roman Numbers Converter, type a number to convert";
            

        }

        private void ConvertCurrentYear()
        {
            string RomanNumber = "";
            string currentYear = DateTime.Now.Year.ToString();
            RomanNumber = numbersLessThanFiveThowsand(Int32.Parse(currentYear));
            lblResult.Text = RomanNumber;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[0];
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[1];
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[2];
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[3];
        }

        private void btnNum10_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[4];
        }

        private void bynNum50_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[5];
        }

        private void btnNum100_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[6];
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[7];
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            txtNumToConvert.Text = string.Empty;
            lblResult.Text = romanNumbers[8];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Exit Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Exit Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            convertNumberToRoman();
        }

        private void convertNumberToRoman()
        {
            if (txtNumToConvert.Text == string.Empty)
            {
                MessageBox.Show("Insert a number to convert...", "ERROR - NO NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumToConvert.Focus();
            }
            else
            {
                string romanNumber = "";
                string knownNumber;
                int number;
                bool conversion = int.TryParse(txtNumToConvert.Text, out number);

                if (conversion)
                {
                    knownNumber = IsKnownNumber(txtNumToConvert.Text);
                }else
                {
                    MessageBox.Show("Must input a number...", "ERROR - CAN ONLY CONVERT NUMBERS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumToConvert.Text = String.Empty;
                    txtNumToConvert.Focus();
                    return;
                }
                
                
                if (knownNumber != "-1")
                {
                    lblResult.Text = romanNumbers[Int32.Parse(knownNumber)];
                }
                else
                {

                    int numberToConvert = Int32.Parse(txtNumToConvert.Text);
                    if (numberToConvert > 3999)
                    {
                        MessageBox.Show("The App only converts numbers to 3999.\n Please insert a smaller number...", "ERROR - OVER THE LIMIT NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumToConvert.Text = String.Empty;
                        txtNumToConvert.Focus();
                        return;
                    }

                    if (numberToConvert < 10)
                    {
                        romanNumber = numbersLessThanTen(numberToConvert);
                        lblResult.Text = romanNumber;

                    }
                    else if (numberToConvert < 100)
                    {
                        romanNumber = numbersLessThanHundred(numberToConvert);
                        lblResult.Text = romanNumber;
                    }
                    else if (numberToConvert < 1000)
                    {
                        romanNumber = numbersLessThanThowsand(numberToConvert);
                        lblResult.Text = romanNumber;
                    }else
                    {
                        romanNumber = numbersLessThanFiveThowsand(numberToConvert);
                        lblResult.Text = romanNumber;
                    }
                }
            }
        }

        private string numbersLessThanFiveThowsand(int numberToConvert)
        {
            string romanNumber = String.Empty;
            string RomanMilhares = "";
            string RomanCentenas = "";
            string RomanDezenas = "";
            string RomanUnidades = "";

            int milhares = numberToConvert / 1000;

            if (numberToConvert % 1000 > 0 && numberToConvert % 1000 < 10)
            {
                RomanUnidades = numbersLessThanTen(numberToConvert % 100);
            }
            else if (numberToConvert % 1000 >10 && numberToConvert % 1000 < 100)
            {
                RomanDezenas = numbersLessThanHundred(numberToConvert % 100);
            }else
            {
                RomanCentenas = numbersLessThanThowsand(numberToConvert % 1000);
            }

            switch (milhares)
            {
                case 1:
                    RomanMilhares = romanNumbers[8];
                    break;
                case 2:
                    RomanMilhares = romanNumbers[8] + romanNumbers[8];
                    break;
                case 3:
                    RomanMilhares = romanNumbers[8] + romanNumbers[8] + romanNumbers[8];
                    break;
            }

            romanNumber = RomanMilhares + RomanCentenas + RomanDezenas + RomanUnidades;
            return romanNumber;


        }

        private string numbersLessThanThowsand(int numberToConvert)
        {
            string romanNumber = String.Empty;
            string RomanCentenas = "";
            string RomanDezenas = "";
            string RomanUnidades = "";

            int centenas = numberToConvert / 100;

            if (numberToConvert % 100 >0 && numberToConvert % 100 < 10 )
            {
                RomanUnidades = numbersLessThanTen(numberToConvert % 100);
            }else
            {
                RomanDezenas = numbersLessThanHundred(numberToConvert % 100);
            }
            
            switch (centenas)
            {
                case 1:
                    RomanCentenas = romanNumbers[6];
                    break;
                case 2:
                    RomanCentenas = romanNumbers[6] + romanNumbers[6];
                    break;
                case 3:
                    RomanCentenas = romanNumbers[6] + romanNumbers[6] + romanNumbers[6];
                    break;
                case 4:
                    RomanCentenas = romanNumbers[6] + romanNumbers[7];
                    break;
                case 5:
                    RomanCentenas = romanNumbers[7];
                    break;
                case 6:
                    RomanCentenas = romanNumbers[7] + romanNumbers[6];
                    break;
                case 7:
                    RomanCentenas = romanNumbers[7] + romanNumbers[6] + romanNumbers[6];
                    break;
                case 8:
                    RomanCentenas = romanNumbers[7] + romanNumbers[6] + romanNumbers[6] + romanNumbers[6];
                    break;
                case 9:
                    RomanCentenas = romanNumbers[6] + romanNumbers[8];
                    break;
            }

            romanNumber = RomanCentenas + RomanDezenas + RomanUnidades;
            return romanNumber;
        }

        private string numbersLessThanHundred(int numberToConvert)
        {
            string romanNumber=String.Empty;
            string RomanDezenas = "";
            string RomanUnidades = "";
            int dezenas = numberToConvert / 10;
            int unidades = numberToConvert % 10;

            if (unidades > 0)
            {
                RomanUnidades = numbersLessThanTen(unidades);
            }

      
            switch (dezenas){
                case 1:
                    RomanDezenas = romanNumbers[4];
                    break;
                case 2:
                    RomanDezenas = romanNumbers[4] + romanNumbers[4];
                    break;
                case 3:
                    RomanDezenas = romanNumbers[4] + romanNumbers[4] + romanNumbers[4];
                    break;
                case 4:
                    RomanDezenas = romanNumbers[4] + romanNumbers[5];
                    break;
                case 5:
                    RomanDezenas = romanNumbers[5];
                    break;
                case 6:
                    RomanDezenas = romanNumbers[5] + romanNumbers[4];
                    break;
                case 7:
                    RomanDezenas = romanNumbers[5] + romanNumbers[4] + romanNumbers[4];
                    break;
                case 8:
                    RomanDezenas = romanNumbers[5] + romanNumbers[4] + romanNumbers[4] + romanNumbers[4];
                    break;
                case 9:
                        RomanDezenas = romanNumbers[4] + romanNumbers[6];
                    break; 
            }
           
            romanNumber = RomanDezenas + RomanUnidades;
            return romanNumber;
        }

        private string numbersLessThanTen(int numberToConvert)
        {
            string romanNumber = "";
            switch (numberToConvert){
                case 1:
                    romanNumber = romanNumbers[0];
                    break;
                case 2:
                    romanNumber = romanNumbers[1];
                    break;
                case 3:
                    romanNumber = romanNumbers[2];
                    break;
                case 4:
                    romanNumber = romanNumbers[0] + romanNumbers[3];
                    break;
                case 5:
                    romanNumber = romanNumbers[3];
                    break;
                case 6:
                    romanNumber = romanNumbers[3] + romanNumbers[0];
                    break;
                case 7:
                    romanNumber = romanNumbers[3] + romanNumbers[1];
                    break;
                case 8:
                    romanNumber = romanNumbers[3] + romanNumbers[2];
                    break;
                case 9:
                    romanNumber = romanNumbers[0] + romanNumbers[4];
                    break;

                
            }

            return romanNumber;
        }

        private string IsKnownNumber(string text)
        {   
            bool flag = false;
            int index = 0;
            foreach (var item in KnownRomanNumersList)
            {
                if(item == text)
                {
                    flag = true;
                    break;
                }else
                {
                    flag = false;
                    index++;
                }
            }

            if (flag)// number is a known roman number
            {
                return index.ToString();
            }
            else
            {
                return "-1";
            }
        }

        private void txtNumToConvert_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = String.Empty;

        }

        private void txtNumToConvert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertNumberToRoman();
            }
        }
    }
}
