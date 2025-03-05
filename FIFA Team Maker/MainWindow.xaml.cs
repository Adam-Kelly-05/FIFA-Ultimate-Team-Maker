using System.Net.Http;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Newtonsoft.Json.Linq;

namespace FIFA_Team_Maker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Search_BTN_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBar.Text;
            SearchAPI(search);
        }

        private async Task SearchAPI(string search)
        {
            string apiKey = "496d47c537f35ec7b40b14859f19a74e";
            string apiUrl = $"https://v3.football.api-sports.io/players/profiles?search={search.Replace(" ", "%20")}";

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-rapidapi-key", apiKey);
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string responseString = await response.Content.ReadAsStringAsync();

            JObject responseJSON = JObject.Parse(responseString);
            Test.Text = responseJSON.ToString();

            JToken player = responseJSON["response"];

            if (player[0] != null)
            {
                Player1Border_BDR.BorderBrush = Brushes.Black;
                Player1Name_TXTBLK.Text = player[0]["player"]["name"].ToString();
                Player1Country_TXTBLK.Text = player[0]["player"]["nationality"].ToString();
                Player1Age_TXTBLK.Text = player[0]["player"]["age"].ToString();
                Player1Image_IMG.Source = new BitmapImage(new Uri(player[0]["player"]["photo"].ToString()));
                Player1Position_TXTBLK.Text = player[0]["player"]["position"].ToString();
            }

            if (player[1] != null)
            {
                Player2Border_BDR.BorderBrush = Brushes.Black;
                Player2Name_TXTBLK.Text = player[1]["player"]["name"].ToString();
                Player2Country_TXTBLK.Text = player[1]["player"]["nationality"].ToString();
                Player2Age_TXTBLK.Text = player[1]["player"]["age"].ToString();
                Player2Image_IMG.Source = new BitmapImage(new Uri(player[1]["player"]["photo"].ToString()));
                Player2Position_TXTBLK.Text = player[1]["player"]["position"].ToString();
            }

            if (player[2] != null)
            {
                Player3Border_BDR.BorderBrush = Brushes.Black;
                Player3Name_TXTBLK.Text = player[2]["player"]["name"].ToString();
                Player3Country_TXTBLK.Text = player[2]["player"]["nationality"].ToString();
                Player3Age_TXTBLK.Text = player[2]["player"]["age"].ToString();
                Player3Image_IMG.Source = new BitmapImage(new Uri(player[2]["player"]["photo"].ToString()));
                Player3Position_TXTBLK.Text = player[2]["player"]["position"].ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double budget = double.Parse(Budget_TXTBX.Text);
        }
    }
}
