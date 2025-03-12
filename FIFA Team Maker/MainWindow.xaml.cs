using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FIFA_Team_Maker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int attackerCounter = 0;
        int midfielderCounter = 0;
        int defenderCounter = 0;
        int goalkeeperCounter = 0;

        CreatedTeam createdTeam = new CreatedTeam();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearOldResults() // Not Implamented Yet
        {
            Player1Name_TXTBLK.Text = string.Empty;
            Player1Country_TXTBLK.Text = string.Empty;
            Player1Age_TXTBLK.Text = string.Empty;
            Player1_BTN.Opacity = 0;
            Player1Image_IMG.Source = null;
            Player1Position_TXTBLK.Text = string.Empty;
            Player1Border_BDR.Opacity = 0;

            Player2Name_TXTBLK.Text = string.Empty;
            Player2Country_TXTBLK.Text = string.Empty;
            Player2Age_TXTBLK.Text = string.Empty;
            Player2_BTN.Opacity = 0;
            Player2Image_IMG.Source = null;
            Player2Position_TXTBLK.Text = string.Empty;
            Player2Border_BDR.Opacity = 0;

            Player3Name_TXTBLK.Text = string.Empty;
            Player3Country_TXTBLK.Text = string.Empty;
            Player3Age_TXTBLK.Text = string.Empty;
            Player2_BTN.Opacity = 0;
            Player3Image_IMG.Source = null;
            Player3Position_TXTBLK.Text = string.Empty;
            Player3Border_BDR.Opacity = 0;
        }

        private void AddPlayer(Player player)
        {
            if (player.Position == "Attacker" || player.Position == "Midfielder" || player.Position == "Defender" || player.Position == "Goalkeeper")
            {
                string[] name = player.Name.Split(" ");
                string lastName = name[name.Length - 1];

                if (player.Position == "Attacker" && attackerCounter <= 2)
                {
                    if (attackerCounter == 0)
                    {
                        ST1_RATING.Text = player.Rating.ToString();
                        ST1_IMG.Source = player.Photo;
                        ST1_NAME.Text = lastName;
                        ST1OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(ST1OVERLAY_REC, -1);
                    }
                    else if (attackerCounter == 1)
                    {
                        ST2_RATING.Text = player.Rating.ToString();
                        ST2_IMG.Source = player.Photo;
                        ST2_NAME.Text = lastName;
                        ST2OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(ST2OVERLAY_REC, -1);
                    }
                    else if (attackerCounter == 2)
                    {
                        ST3_RATING.Text = player.Rating.ToString();
                        ST3_IMG.Source = player.Photo;
                        ST3_NAME.Text = lastName;
                        ST3OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(ST3OVERLAY_REC, -1);
                    }
                    attackerCounter++;
                    createdTeam.AddPlayer(player);
                }
                else if (player.Position == "Midfielder" && midfielderCounter <= 2)
                {
                    if (midfielderCounter == 0)
                    {
                        MF1_RATING.Text = player.Rating.ToString();
                        MF1_IMG.Source = player.Photo;
                        MF1_NAME.Text = lastName;
                        MF1OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(MF1OVERLAY_REC, -1);
                    }
                    else if (midfielderCounter == 1)
                    {
                        MF2_RATING.Text = player.Rating.ToString();
                        MF2_IMG.Source = player.Photo;
                        MF2_NAME.Text = lastName;
                        MF2OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(MF2OVERLAY_REC, -1);
                    }
                    else if (midfielderCounter == 2)
                    {
                        MF3_RATING.Text = player.Rating.ToString();
                        MF3_IMG.Source = player.Photo;
                        MF3_NAME.Text = lastName;
                        MF3OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(MF3OVERLAY_REC, -1);
                    }
                    midfielderCounter++;
                    createdTeam.AddPlayer(player);
                }
                else if (player.Position == "Defender" && midfielderCounter <= 3)
                {
                    if (defenderCounter == 0)
                    {
                        DEF1_RATING.Text = player.Rating.ToString();
                        DEF1_IMG.Source = player.Photo;
                        DEF1_NAME.Text = lastName;
                        DEF1OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(DEF1OVERLAY_REC, -1);
                    }
                    else if (defenderCounter == 1)
                    {
                        DEF2_RATING.Text = player.Rating.ToString();
                        DEF2_IMG.Source = player.Photo;
                        DEF2_NAME.Text = lastName;
                        DEF2OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(DEF2OVERLAY_REC, -1);
                    }
                    else if (defenderCounter == 2)
                    {
                        DEF3_RATING.Text = player.Rating.ToString();
                        DEF3_IMG.Source = player.Photo;
                        DEF3_NAME.Text = lastName;
                        DEF3OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(DEF3OVERLAY_REC, -1);
                    }
                    else if (defenderCounter == 3)
                    {
                        DEF4_RATING.Text = player.Rating.ToString();
                        DEF4_IMG.Source = player.Photo;
                        DEF4_NAME.Text = lastName;
                        DEF4OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(DEF4OVERLAY_REC, -1);
                    }
                    defenderCounter++;
                    createdTeam.AddPlayer(player);
                }
                else if (player.Position == "Goalkeeper" && goalkeeperCounter <= 0)
                {
                    if (goalkeeperCounter == 0)
                    {
                        GK1_RATING.Text = player.Rating.ToString();
                        GK1_IMG.Source = player.Photo;
                        GK1_NAME.Text = lastName;
                        GK1OVERLAY_TXTBLK.Opacity = 0;
                        Panel.SetZIndex(GK1OVERLAY_REC, -1);
                    }
                    goalkeeperCounter++;
                    createdTeam.AddPlayer(player);
                }
            }
        }

        private void StartGame_BTN_Click(object sender, RoutedEventArgs e)
        {
            double budget = double.Parse(Budget_TXTBX.Text);
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
                Player1_BTN.Opacity = 100;
            }

            if (player[1] != null)
            {
                Player2Border_BDR.BorderBrush = Brushes.Black;
                Player2Name_TXTBLK.Text = player[1]["player"]["name"].ToString();
                Player2Country_TXTBLK.Text = player[1]["player"]["nationality"].ToString();
                Player2Age_TXTBLK.Text = player[1]["player"]["age"].ToString();
                Player2Image_IMG.Source = new BitmapImage(new Uri(player[1]["player"]["photo"].ToString()));
                Player2Position_TXTBLK.Text = player[1]["player"]["position"].ToString();
                Player2_BTN.Opacity = 100;
            }

            if (player[2] != null)
            {
                Player3Border_BDR.BorderBrush = Brushes.Black;
                Player3Name_TXTBLK.Text = player[2]["player"]["name"].ToString();
                Player3Country_TXTBLK.Text = player[2]["player"]["nationality"].ToString();
                Player3Age_TXTBLK.Text = player[2]["player"]["age"].ToString();
                Player3Image_IMG.Source = new BitmapImage(new Uri(player[2]["player"]["photo"].ToString()));
                Player3Position_TXTBLK.Text = player[2]["player"]["position"].ToString();
                Player3_BTN.Opacity = 100;
            }

            if (player[0] == null && player[1] == null && player[2] == null)
            {
                Player1Name_TXTBLK.Text = "No Results";
            }
        }

        private void Search_BTN_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBar.Text;
            SearchAPI(search);
        }

        private void Player1_BTN_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer(new Player(Player1Name_TXTBLK.Text, (BitmapImage)Player1Image_IMG.Source, Player1Position_TXTBLK.Text));
        }

        private void Player2_BTN_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer(new Player(Player2Name_TXTBLK.Text, (BitmapImage)Player2Image_IMG.Source, Player2Position_TXTBLK.Text));
        }

        private void Player3_BTN_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer(new Player(Player3Name_TXTBLK.Text, (BitmapImage)Player3Image_IMG.Source, Player3Position_TXTBLK.Text));
        }
    }
}
