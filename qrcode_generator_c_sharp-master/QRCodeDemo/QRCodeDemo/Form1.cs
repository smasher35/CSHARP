using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using Color = System.Drawing.Color;

namespace QRCodeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtQRCode.Text = "Enter text to code";
            txtQRCode.ForeColor = Color.DarkGray;
            txtQRCode.TextAlign = HorizontalAlignment.Center;
            notifyIcon.Icon = SystemIcons.Application;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generateQRCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQRCode_Enter(object sender, EventArgs e)
        {
            pic.Image = null;
            txtQRCode.ForeColor = Color.Black;
            txtQRCode.TextAlign = HorizontalAlignment.Left;
            txtQRCode.Text = "";


        }

        private void txtQRCode_Leave(object sender, EventArgs e)
        {
            if (txtQRCode.Text == "")
            {
                txtQRCode.Text = "Enter text to code";
                txtQRCode.ForeColor  = Color.DarkGray; ;
                txtQRCode.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void txtQRCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerate.Focus();
                generateQRCode();
            }
        }


        private void generateQRCode()
        {
            if (!string.IsNullOrEmpty(txtQRCode.Text) && txtQRCode.Text != "Enter text to code")
            {

                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(txtQRCode.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pic.Image = code.GetGraphic(5);
                txtQRCode.Text = "Enter text to code";
                txtQRCode.ForeColor = Color.DarkGray;
                txtQRCode.TextAlign = HorizontalAlignment.Center;
                notifyIcon.ShowBalloonTip(3000, "Message", "QR Code generated with success!!", ToolTipIcon.Info);
            }
            else
            {
                pic.Image = null;
                MessageBox.Show("Please fill the text to code...", "Error...", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
