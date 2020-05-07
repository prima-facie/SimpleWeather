using System;
using System.Windows.Forms;
using WeatherNet;
using WeatherNet.Clients;

namespace WeatherApplication
{
    class WeatherInformation
    {

        private string temp;
        private string humidity;
        private string status;
        private string wind;
        private string imageLocation;
        private string area;
        private string country;

        public WeatherInformation(string area, string country)
        {
            this.area = area;
            this.country = country;
        }

        public string getTemp() { return temp; }
        public string getHumidity() { return humidity; }
        public string getStatus() { return status; }
        public string getWindSpeed() { return wind; }
        public string getArea() { return area; }
        public string getImage() { return imageLocation; }

        public void GetInformation()
        {
            try
            {
                ClientSettings.ApiUrl = "http://api.openweathermap.org/data/2.5";
                ClientSettings.ApiKey = "YOUR-API-KEY"; // Enter your OpenWeatherMap API key here
                var information = CurrentWeather.GetByCityName(area, country, "en", "metric");
                temp = Math.Round(information.Item.Temp).ToString() + "°C"; // Temperature
                humidity = Math.Round(information.Item.Humidity).ToString() + "%"; // Humidity
                status = information.Item.Title; // Status
                wind = Math.Round(information.Item.WindSpeed) + "km/h"; // Wind Speed
                area = information.Item.City + ", " + information.Item.Country; // Weather location
                imageLocation = "http://openweathermap.org/img/wn/" + information.Item.Icon + "@2x.png"; // Get image location
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}