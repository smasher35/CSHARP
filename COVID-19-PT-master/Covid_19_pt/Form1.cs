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
        private int seconds = 1000;
        private int last_result = 0;
        private bool hasNewUpdate = false;
        private string api_covid =
            "https://api.apify.com/v2/key-value-stores/BXGEYTTUQzYBboEQK/records/LATEST?disableRedirect=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshApp();
            initConstruct();
            InitializeAPI_start();
        }


        private void refreshApp()
        {
            timer1.Tick += new EventHandler(InitializeAPI); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = 180000;
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();
        }

        private void initConstruct()
        {
            DateTime localDate = DateTime.Now;
            toolStripStatusLabel1.Text = "by Paulo Penicheiro";
            toolStripStatusLabel2.Text = String.Empty;
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel3.Text = localDate.ToShortDateString();
            toolStripStatusLabel4.Text = localDate.ToShortDateString();
        }

        private void InitializeAPI(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            string apiPath = String.Format(api_covid);
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

            deserializeJson(result);
            Console.Write(result);
            toolStripStatusLabel2.Text = "Last Update: " + localDate;
            if (hasNewUpdate)
            {
                PlaySound("update_sound.mp3");
            }
        }

        private void InitializeAPI_start()
        {
            DateTime localDate = DateTime.Now;
            string apiPath = String.Format(api_covid);
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

            deserializeJson(result);
            Console.Write(result);
            toolStripStatusLabel2.Text = "Last Update: " + localDate;
            PlaySound("update_sound.mp3");
        }

        void PlaySound(String sound)
        {
            WMPLib.WindowsMediaPlayer Player;
            WMPLib.WindowsMediaPlayer winmp = new WMPLib.WindowsMediaPlayer();
            winmp.URL = sound;
            winmp.controls.play();
        }

        private void deserializeJson(string api_result)
        {
            hasNewUpdate = false;
            string json = api_result;
            string temp;
            string regionTotInfected="";

            JObject result = JObject.Parse(json);

            // James Newton-King
            string totTestados = (string) result["suspicious"];
            string totInfectados = (string)result["infected"];
            string totRecuperados = (string)result["recovered"];
            string totFalecidos = (string)result["deceased"];

            labelInfetadas.Text = totInfectados;
            labeltestadas.Text = totTestados;
            labelRecuperadas.Text = totRecuperados;
            labelFalecidas.Text = totFalecidos;

            if (last_result == 0)
            {
                last_result = Int32.Parse(totFalecidos);
                hasNewUpdate = true;
            }
            else
            {
                if (last_result != Int32.Parse(totFalecidos))
                {
                    last_result = Int32.Parse(totFalecidos);
                    hasNewUpdate = true;
                }
            }

            JArray categories = (JArray)result["infectedByRegion"];
            

            for (int i = 0;  i < categories.Count; i++)
            {
                temp = (string) result["infectedByRegion"][i]["region"];
                temp = temp.ToUpper();
                if (temp == "LISBOA")
                {
                   regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                   labelLisboa.Text = regionTotInfected;
                }
                else if (temp == "PORTO")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelPorto.Text = regionTotInfected;
                }
                else if (temp == "COIMBRA")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelCoimbra.Text = regionTotInfected;
                }
                else if (temp == "AVEIRO")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    LabelAveiro.Text = regionTotInfected;
                }
                else if (temp == "LEIRIA")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelLeiria.Text = regionTotInfected;
                }
                else if (temp == "FIGUEIRA DA FOZ")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelFigueira.Text = regionTotInfected;
                }
                else if (temp == "BRAGA")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelBraga.Text = regionTotInfected;
                }
                else if (temp == "FARO")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelFaro.Text = regionTotInfected;
                }
                else if (temp == "BEJA")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelBeja.Text = regionTotInfected;
                }
                else if (temp == "ÉVORA")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelEvora.Text = regionTotInfected;
                }
                else if (temp == "VISEU")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelViseu.Text = regionTotInfected;
                }
                else if (temp == "GUARDA")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelGuarda.Text = regionTotInfected;
                }
                else if (temp == "SANTARÉM")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelSantarem.Text = regionTotInfected;
                }
                else if (temp == "SETÚBAL")
                {
                    regionTotInfected = (string)result["infectedByRegion"][i]["region"] + "\n" + (string)result["infectedByRegion"][i]["value"];
                    labelSetubal.Text = regionTotInfected;
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
