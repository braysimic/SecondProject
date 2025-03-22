using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSecondProject
{
    public partial class Form1 : Form
    {

        private List<WeatherRecord> weatherRecords = new List<WeatherRecord>();
        public Form1()
        {
            InitializeComponent();
        }

        public struct WeatherRecord
        {
            public string Location;
            public double Temperature;
            public double Humidity;
            public string Condition;
        }

        private void btnAddWeather_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            double temperature = double.TryParse(txtTemperature.Text, out temperature) ? temperature : 0;
            double humidity = double.TryParse(txtHumidity.Text, out humidity) ? humidity : 0;
            string condition = GetSelectedCondition();
            if (string.IsNullOrEmpty(location) || temperature == 0 || humidity == 0 || string.IsNullOrEmpty(condition))
                    {
                MessageBox.Show("Please enter valid data for all boxes");
                return;
            }

            WeatherRecord newRecord = new WeatherRecord
            {
                Location = location,
                Temperature = temperature,
                Humidity = humidity,
                Condition = condition
            };

            weatherRecords.Add(newRecord);

            txtLocation.Clear();
            txtTemperature.Clear();
            txtHumidity.Clear();
            radRainy.Checked = false;
            radSunny.Checked = false;
            radWindy.Checked = false;

            MessageBox.Show("Weather data has been recorded.");

        }

        private string GetSelectedCondition()
        {
            if (radSunny.Checked)
                return "Sunny";
            else if (radRainy.Checked)
                return "Rainy";
            else if (radWindy.Checked)
            return "Windy";
            return string.Empty;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            lstWeatherReports.Items.Clear();

            foreach (var record in weatherRecords)
            {
                string weatherInfo = $"{record.Location} - Temp: {record.Temperature}, Humidity: {record.Humidity}%, Condition: {record.Condition}";
                lstWeatherReports.Items.Add(weatherInfo);
            }

            if (lstWeatherReports.Items.Count == 0)
            {
                lstWeatherReports.Items.Add("No Weather data available, try pressing Add Weather :)");
            }
        }
    }
}
