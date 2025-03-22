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
        public Form1()
        {
            InitializeComponent();
        }

        public struct WeatherRecord
        {
            public string Location;
            public string Temperature;
            public string Humidity;
            public string Condition;
        }

        private void btnAddWeather_Click(object sender, EventArgs e)
        {
            string location = lblLocation.Text;
            double temperature = double.TryParse(txtTemperature.Text, out temperature) ? temperature : 0;
            double humidity = double.TryParse(txtHumidity.Text, out humidity) ? humidity : 0;
            string condition = GetSelectedCondition();
            if (string.IsNullOrEmpty) || temperature == 0 || humidity == 0 || string.IsNullOrEmpty(condition))
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


        }
    }
}
