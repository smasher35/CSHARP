using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Timer = System.Timers.Timer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string channelID = "UCLNgMNfdksu_r5cwlplenBg";
        private string APIKey = "AIzaSyBvlAdPNUSwBomkCT1bj_F0k8BySK0fb-8";
        private string channelTitle;
        private string channelDescription;
        UTF8Encoding utf8 = new UTF8Encoding();

        private int seconds = 1000;
        //Timer timer1 = new Timer();

        public Form1()
        {
            InitializeComponent();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshApp();
            
        }

        private void refreshApp()
        {
            timer1.Tick += new EventHandler(updateLabels); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (seconds) * (1);              // Timer will tick evert second
            if (seconds <= 60000)
            {
                seconds += 5000;
            }
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();
        }
        private string InitializeChannel()
        {
            WebClient webClient = new WebClient();

            webClient.QueryString.Add("id", channelID);
            webClient.QueryString.Add("part", "snippet,contentDetails,statistics");
            webClient.QueryString.Add("key", APIKey);

            string result = webClient.DownloadString("https://www.googleapis.com/youtube/v3/channels/");
            return result;
        }

        private void updateLabels(object sender, EventArgs e)
        {
            deserializeJson();
            
        }

        private void deserializeJson()
        {
            string json = InitializeChannel();

            JObject result = JObject.Parse(json);

            string kind = (string)result["kind"];
            // James Newton-King

            string subscriberCount = (string)result["items"][0]["statistics"]["subscriberCount"];
            string videoCount = (string)result["items"][0]["statistics"]["videoCount"];
            string viewCount = (string)result["items"][0]["statistics"]["viewCount"];
            channelTitle  = (string)result["items"][0]["snippet"]["title"];
            channelDescription = (string)result["items"][0]["snippet"]["description"];
            // Json.NET 1.3 + New license + Now on CodePlex

            float value = 0;
            string specifier = "N0";
            value = float.Parse(subscriberCount);
            lblTotSubscribers.Text =  value.ToString(specifier);
            value = float.Parse(videoCount);
            lblTotVideos.Text = value.ToString(specifier);
            value = float.Parse(viewCount);
            lblTotViews.Text = value.ToString(specifier);
            
            lblChannelTitle.Text = channelTitle;
            lblChannelDescription.Text = channelDescription;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        public void SetCredentials(string channelID, string APIkey)
        {
            
            this.APIKey = APIkey;
            deserializeJson();
        }

        public void setChannelId(string channel)
        {
            this.channelID = channel;
            deserializeJson();
        }


        public void setAPIKeyId(string api)
        {
            this.APIKey = api;
            deserializeJson();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            deserializeJson();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.ShowDialog();
        }
    }
}
