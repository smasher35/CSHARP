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
    public partial class Form2 : Form
    {
        private Form1 formulario;
        private string channelKey;
        private string APIKey;
        public Form2(Form1 form)
        {
            InitializeComponent();
            this.formulario = form;
            startFormConfigurations();
            
        }

        private void startFormConfigurations()
        {
            radioChangeChannelID.Checked = true;
            txtChannelId.BackColor = Color.White;
            txtAPIKey.BackColor = Color.DarkGray;
            txtAPIKey.Enabled = false;
            btnPastAPI.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            channelKey = txtChannelId.Text;
            APIKey = txtAPIKey.Text;


            if (radioChangeChannelID.Checked)
            {
                if (String.IsNullOrEmpty(channelKey)){
                    MessageBox.Show("Please fill the Channel ID with respective value", "Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtChannelId.Focus();
                }
                else
                {
                   formulario.setChannelId(channelKey);
                    this.Close();
              
                }
            }else if (radioChangeAPIKey.Checked){

                if (String.IsNullOrEmpty(APIKey))
                {
                    MessageBox.Show("Please fill the API Key with respective value", "Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtAPIKey.Focus();
                }
                else
                {
                    formulario.setAPIKeyId(APIKey);
                    this.Close();

                }
            }
            else
            {
                if (String.IsNullOrEmpty(channelKey) || String.IsNullOrEmpty(APIKey))
                {
                    MessageBox.Show("Please fill both feilds with respective values", "Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtChannelId.Focus();
                }
                else
                {
                    formulario.SetCredentials(channelKey, APIKey);
                    this.Close();
                }
            }

            
        }

        private void btnPasteChannel_Click(object sender, EventArgs e)
        {
            txtChannelId.Text = Clipboard.GetText();
        }

        private void btnPastAPI_Click(object sender, EventArgs e)
        {
            txtAPIKey.Text = Clipboard.GetText();
        }

        private void radioChangeAPIKey_CheckedChanged(object sender, EventArgs e)
        {
            txtAPIKey.BackColor = Color.White;
            txtAPIKey.Enabled = true;
            btnPastAPI.Enabled = true;

            txtChannelId.BackColor = Color.DarkGray;
            txtChannelId.Enabled = false;
            btnPasteChannel.Enabled = false;
        }

        private void radioChangeBoth_CheckedChanged(object sender, EventArgs e)
        {
            txtAPIKey.BackColor = Color.White;
            txtAPIKey.Enabled = true;
            btnPastAPI.Enabled = true;

            txtChannelId.BackColor = Color.White;
            txtChannelId.Enabled = true;
            btnPasteChannel.Enabled = true;
        }

        private void radioChangeChannelID_CheckedChanged(object sender, EventArgs e)
        {
            txtChannelId.BackColor = Color.White;
            txtChannelId.Enabled = true;
            btnPasteChannel.Enabled = true;

            txtAPIKey.BackColor = Color.DarkGray;
            txtAPIKey.Enabled = false;
            btnPastAPI.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAPIKey.Text = Clipboard.GetText();
        }
    }
}
