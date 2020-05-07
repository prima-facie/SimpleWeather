using System.Windows.Forms;

namespace WeatherApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ActiveControl = panel1;
            CountryBox.SelectedIndex = 185;
            TxtCity.Text = "London";
        }

        private void GetWeather()
        {
            if (!string.IsNullOrEmpty(TxtCity.Text) && !string.IsNullOrEmpty(CountryBox.SelectedItem.ToString())) // Check if user provided information
            {
                string country = CountryBox.SelectedItem.ToString();
                string city = TxtCity.Text;
                WeatherInformation information = new WeatherInformation(city, country);
                information.GetInformation();
                TxtTemperature.Text = "Temperature: " + information.getTemp();
                TxtWind.Text = "Wind: " + information.getWindSpeed();
                TxtHumidity.Text = "Humidity: " + information.getHumidity();
                TxtStatus.Text = "Status: " + information.getStatus();
                ImageBox.ImageLocation = information.getImage();
                txtArea.Text = information.getArea();
            }
            else
            {
                MessageBox.Show("Please fill all required fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRefresh_Click(object sender, System.EventArgs e)
        {
            GetWeather();
        }

        private void BtnGet_Click(object sender, System.EventArgs e)
        {
            GetWeather();
        }
    }
}
