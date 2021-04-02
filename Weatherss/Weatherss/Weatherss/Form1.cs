using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weatherss
{
    public partial class Form1 : Form
    {
        const string APPID = "a7fd91410c0f31a52bbb77660bef5394";
        string cityID= "1566083";
        public Form1()
        {
            InitializeComponent();
            GetWeather("1566083");
            //geForcast("1566083");
        }

        void GetWeather(string v)
        {
           
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&cnt=6", cityID, APPID);
                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root output = result;

                lbtextcity.Text = string.Format("{0}", output.name);
               // lbcountry.Text = string.Format("{0}", output.sys.country);
               // lbDoce.Text = string.Format("{0} \u00B0" + "C", output.main.temp);
            }

        }
        /*void geForcast(string city)
        {

           int day = 5;
               string url = string.Format("http://api.openweathermap.org/data/2.5/forcast/daily?id={0}&units=metric&cnt={1}&appid={2}", city, day, APPID); ;
               using (WebClient web = new WebClient())
               {

                  var json = web.DownloadString(url);
                  var Object = JsonConvert.DeserializeObject<WeatherForcast>(json);
                  WeatherForcast forcasts = Object;

                   lbcon.Text = string.Format("{0}", forcasts.list[1].weather[0].main);
                   lbDes.Text = string.Format("{0}", forcasts.list[1].weather[0].descriptions);
                   lbDes1.Text = string.Format("{0} \u00B0" + "C", forcasts.list[1].temp);
                   lbspeed.Text = string.Format("{0}", forcasts.list[1].speed);

               }

        }*/
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
