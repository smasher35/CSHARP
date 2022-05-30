using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Timer = System.Timers.Timer;

namespace Covid_19_pt
{
    public partial class Form1 : Form
    {
        private int _seconds = 1000;
        private int _lastResult = 0;
        private bool _hasNewUpdate = false;
        private string _apiCovid ="https://api.apify.com/v2/key-value-stores/BXGEYTTUQzYBboEQK/records/LATEST?disableRedirect=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshApp();
            InitConstruct();
            InitializeAPI_start();
        }


        private void RefreshApp()
        {
            timer1.Tick += new EventHandler(InitializeApi); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = 180000;
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();
        }

        private void InitConstruct()
        {
            DateTime localDate = DateTime.Now;
            toolStripStatusLabel1.Text = "by Paulo Penicheiro";
            toolStripStatusLabel2.Text = String.Empty;
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel3.Text = localDate.ToShortDateString();
            toolStripStatusLabel4.Text = localDate.ToShortDateString();
        }

        private void InitializeApi(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            string apiPath = String.Format(_apiCovid);
            WebRequest request = WebRequest.Create(apiPath);
            request.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)request.GetResponse();

            string result = null;

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader rdr = new StreamReader(stream);
                result = rdr.ReadToEnd();
                rdr.Close();
            }

            DeserializeJson(result);
            Console.Write(result);
            toolStripStatusLabel2.Text = "Last Update: " + localDate;
            if (_hasNewUpdate)
            {
                PlaySound("update_sound.mp3");
            }
        }

        private void InitializeAPI_start()
        {
            DateTime localDate = DateTime.Now;
            string apiPath = String.Format(_apiCovid);
            WebRequest request = WebRequest.Create(apiPath);
            request.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)request.GetResponse();

            string result = null;

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader rdr = new StreamReader(stream);
                result = rdr.ReadToEnd();
                rdr.Close();
            }

            DeserializeJson(result);
            Console.Write(result);
            toolStripStatusLabel2.Text = "Last Update: " + localDate;
            PlaySound("update_sound.mp3");
        }

        void PlaySound(String sound)
        {
            WMPLib.WindowsMediaPlayer player;
            WMPLib.WindowsMediaPlayer winmp = new WMPLib.WindowsMediaPlayer();
            winmp.URL = sound;
            winmp.controls.play();
        }

        private void DeserializeJson(string apiResult)
        {
            _hasNewUpdate = false;
            string json = apiResult;

            JObject result = JObject.Parse(json);

            // James Newton-King
            string totTestados = (string) result["tested"];
            string totInfectados = (string)result["infected"];
            string totRecuperados = (string)result["recovered"];
            string totFalecidos = (string)result["deceased"];

            string totNewInfected = (string) result["newlyInfected"];
            string totNewRecovered = (string) result["newlyRecovered"];
            string totNewDeceased = (string) result["newlyDeceased"];
           

            labelInfetadas.Text = Convert.ToDouble(totInfectados).ToString("N0");
            labeltestadas.Text = Convert.ToDouble(totTestados).ToString("N0");
            labelRecuperadas.Text = Convert.ToDouble(totRecuperados).ToString("N0");
            labelFalecidas.Text = Convert.ToDouble(totFalecidos).ToString("N0");

            lblTotNewInfected.Text = Convert.ToDouble(totNewInfected).ToString("N0");
            lblTotNewRecovered.Text = Convert.ToDouble(totNewRecovered).ToString("N0");
            lblToNewDeceased.Text = Convert.ToDouble(totNewDeceased).ToString("N0");


            if (_lastResult == 0)
            {
                _lastResult = Int32.Parse(totInfectados);
                _hasNewUpdate = true;
            }
            else
            {
                if (_lastResult != Int32.Parse(totInfectados))
                {
                    _lastResult = Int32.Parse(totInfectados);
                    _hasNewUpdate = true;
                }
            }

            JArray categories = (JArray)result["infectedByRegion"];
            

            for (var i = 0;  i < categories.Count; i++)
            {
                var temp = (string) result["infectedByRegion"][i]["region"];
                temp = temp.ToUpper();
                var regionTotInfected="";
                if (temp == "ARS LISBOA E VALE DO TEJO")
                {
                   regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["infected"];
                   labelLisboa.Text = regionTotInfected;
                }
                else if (temp == "ARS NORTE")
                {
                    regionTotInfected = (string) result["infectedByRegion"][i]["region"] + "\n" +
                                        (string) result["infectedByRegion"][i]["infected"];
                    labelPorto.Text = regionTotInfected;
                }
                else if (temp == "ARS CENTRO")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["infected"];
                    labelLeiria.Text = regionTotInfected;
                }
                else if (temp == "ARS ALGARVE")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["infected"];
                    labelFaro.Text = regionTotInfected;
                }
                else if (temp == "ARS ALENTEJO")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["infected"];
                    labelBeja.Text = regionTotInfected;
                }
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            InitializeAPI_start();
        }
    }
}
