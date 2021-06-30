using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIJECOMP;
using Color = System.Drawing.Color;

namespace BCryptor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtPwdVerify.ForeColor = Color.Gainsboro;
            mtPasswordEncrypt.ForeColor = Color.Gainsboro;
            mtEncryptedHash.ForeColor = Color.Gold;
            mtEncryptedHash2.ForeColor = Color.Gold;
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult option;

            option = MessageBox.Show("Really Want to Exit???", "EXIT APPLICATION", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (option == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void mbtnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mtPwdVerify_Enter(object sender, EventArgs e)
        {
            mtPwdVerify.Text = "";
            mtPwdVerify.ForeColor = Color.Black;
        }

        private void mtPasswordEncrypt_Enter(object sender, EventArgs e)
        {
            mtPasswordEncrypt.Text = "";
            mtPasswordEncrypt.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hash;

            if (mtPasswordEncrypt.Text != "" && mtPasswordEncrypt.ForeColor == Color.Black)
            {
                hash = Hashing.HashPassword(mtPasswordEncrypt.Text);
                mtEncryptedHash.Text = hash;
            }
            else
            {
                MessageBox.Show("Pleae type a password to encrypt...",
                    "WARNING....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool verify;

            if (mtPwdVerify.Text == "" || mtEncryptedHash2.Text == "")
            {
                MessageBox.Show("Values are missing, please enter a Password to Veriify and a Hashed Password...",
                    "WARNING....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                verify = Hashing.ValidatePassword(mtPwdVerify.Text, mtEncryptedHash2.Text);
                if (verify)
                {
                    MessageBox.Show("PASSWORD CORRECT...", "*** PASSWORD VALIDATION ***", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PASSWORD INCORRECT...", "*** PASSWORD VALIDATION ***", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void btnCopyPwd_Click(object sender, EventArgs e)
        {
            if (mtPasswordEncrypt.Text != "" && mtPasswordEncrypt.ForeColor == Color.Black)
            {
                mtPwdVerify.ForeColor = Color.Black;
                mtPwdVerify.Text = mtPasswordEncrypt.Text;
            }
            
        }

        private void btnCopyHash_Click(object sender, EventArgs e)
        {
            if (mtEncryptedHash.Text != "")
            {
                mtEncryptedHash2.ForeColor = Color.Gold;
                mtEncryptedHash2.Text = mtEncryptedHash.Text;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mtPasswordEncrypt.ForeColor = Color.Gainsboro;
            mtPasswordEncrypt.Text = "insert password to encrypt...";
            mtEncryptedHash.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mtPwdVerify.ForeColor = Color.Gainsboro;
            mtPasswordEncrypt.Text = "insert password to verify...";
            mtEncryptedHash2.Text = "";
        }

        private void btnPwdToolTip_Popup(object sender, PopupEventArgs e)
        {
           
        }
    }
}