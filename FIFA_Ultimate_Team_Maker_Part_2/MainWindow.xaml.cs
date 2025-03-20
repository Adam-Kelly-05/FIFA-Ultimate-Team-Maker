using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FIFA_Ultimate_Team_Maker_Part_2
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
            RemainingBudget_TXTBLK.Text = "∞";
        }

        private void ClearOldResults() // Not Implamented Yet
        {
            Player1Name_TXTBLK.Text = string.Empty;
            Player1Country_TXTBLK.Text = string.Empty;
            Player1Age_TXTBLK.Text = string.Empty;
            Player1ID_TXTBLK.Text = string.Empty;
            Player1_BTN.Opacity = 0;
            Player1Image_IMG.Source = null;
            Player1Position_TXTBLK.Text = string.Empty;
            Player1Border_BDR.Opacity = 0;

            Player2Name_TXTBLK.Text = string.Empty;
            Player2Country_TXTBLK.Text = string.Empty;
            Player2Age_TXTBLK.Text = string.Empty;
            Player2ID_TXTBLK.Text = string.Empty;
            Player2_BTN.Opacity = 0;
            Player2Image_IMG.Source = null;
            Player2Position_TXTBLK.Text = string.Empty;
            Player2Border_BDR.Opacity = 0;

            Player3Name_TXTBLK.Text = string.Empty;
            Player3Country_TXTBLK.Text = string.Empty;
            Player3Age_TXTBLK.Text = string.Empty;
            Player3ID_TXTBLK.Text = string.Empty;
            Player3_BTN.Opacity = 0;
            Player3Image_IMG.Source = null;
            Player3Position_TXTBLK.Text = string.Empty;
            Player3Border_BDR.Opacity = 0;
        }

        private void AddPlayer(Player player)
        {
            if (player.Position == "Attacker" || player.Position == "Midfielder" || player.Position == "Defender" || player.Position == "Goalkeeper")
            {
                string[] name = player.Name.Split(' ');
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
                else
                    MessageBox.Show("That position is full");
            }
        }

        private async Task GetTopThreePlayers(string search)
        {
            string apiKey = "496d47c537f35ec7b40b14859f19a74e";
            string apiUrl = $"https://v3.football.api-sports.io/players/profiles?search={search.Replace(" ", "%20")}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-rapidapi-key", apiKey);
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string responseString = await response.Content.ReadAsStringAsync();

                JObject responseJSON = JObject.Parse(responseString);

                JToken player = responseJSON["response"];

                if (player[0] != null)
                {
                    Player1Border_BDR.BorderBrush = Brushes.White;
                    Player1Name_TXTBLK.Text = player[0]["player"]["name"].ToString();
                    Player1Country_TXTBLK.Text = player[0]["player"]["nationality"].ToString();
                    Player1Age_TXTBLK.Text = player[0]["player"]["age"].ToString();
                    Player1ID_TXTBLK.Text = player[0]["player"]["id"].ToString();
                    Player1Image_IMG.Source = new BitmapImage(new Uri(player[0]["player"]["photo"].ToString()));
                    Player1Position_TXTBLK.Text = player[0]["player"]["position"].ToString();
                    Player1_BTN.Opacity = 100;
                }

                if (player[1] != null)
                {
                    Player2Border_BDR.BorderBrush = Brushes.White;
                    Player2Name_TXTBLK.Text = player[1]["player"]["name"].ToString();
                    Player2Country_TXTBLK.Text = player[1]["player"]["nationality"].ToString();
                    Player2Age_TXTBLK.Text = player[1]["player"]["age"].ToString();
                    Player2ID_TXTBLK.Text = player[1]["player"]["id"].ToString();
                    Player2Image_IMG.Source = new BitmapImage(new Uri(player[1]["player"]["photo"].ToString()));
                    Player2Position_TXTBLK.Text = player[1]["player"]["position"].ToString();
                    Player2_BTN.Opacity = 100;
                }

                if (player[2] != null)
                {
                    Player3Border_BDR.BorderBrush = Brushes.White;
                    Player3Name_TXTBLK.Text = player[2]["player"]["name"].ToString();
                    Player3Country_TXTBLK.Text = player[2]["player"]["nationality"].ToString();
                    Player3Age_TXTBLK.Text = player[2]["player"]["age"].ToString();
                    Player3ID_TXTBLK.Text = player[2]["player"]["id"].ToString();
                    Player3Image_IMG.Source = new BitmapImage(new Uri(player[2]["player"]["photo"].ToString()));
                    Player3Position_TXTBLK.Text = player[2]["player"]["position"].ToString();
                    Player3_BTN.Opacity = 100;
                }

                if (player[0] == null && player[1] == null && player[2] == null)
                    Player1Name_TXTBLK.Text = "No Results";
            }
        }

        private double CalculatePlayerPrice(string playersTeam, string playersPosition)
        {
            LeagueData db = new LeagueData();

            var teamPositionValue = db.Teams
                                      .Where(t => t.TeamName == playersTeam)
                                      .Select(t => t.Value)
                                      .FirstOrDefault();

            var league = db.Teams
                           .Where(t => t.TeamName == playersTeam)
                           .Select(t => t.LeagueID)
                           .FirstOrDefault();

            var leagueValue = db.Leagues
                                .Where(l => l.LeagueId == league)
                                .Select(l => l.LeagueValue)
                                .FirstOrDefault();

            int positionValue = 1;
            switch (playersPosition)
            {
                case "Attacker":
                    positionValue = 20;
                    break;
                case "Midfielder":
                    positionValue = 14;
                    break;
                case "Defender":
                    positionValue = 7;
                    break;
                case "Goalkeeper":
                    positionValue = 1;
                    break;
                default:
                    break;
            }

            return (0.1 * teamPositionValue * leagueValue * positionValue) / 8;
        }

        private async Task<double> GetPlayerPrice(string playersID, string playersPosition)
        {
            string apiKey = "496d47c537f35ec7b40b14859f19a74e";
            string apiUrl = $"https://v3.football.api-sports.io/players/teams?player={playersID}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-rapidapi-key", apiKey);
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string responseString = await response.Content.ReadAsStringAsync();

                JObject responseJSON = JObject.Parse(responseString);

                JToken player = responseJSON["response"];

                HashSet<string> fifaRecognizedCountries = new HashSet<string> { "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China PR", "Chinese Taipei", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Curaçao", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "DR Congo", "Ecuador", "Egypt", "El Salvador", "England", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Faroe Islands", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Grenada", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Korea DPR", "Korea Republic", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Northern Ireland", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Ireland", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Scotland", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tahiti", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United States", "Uruguay", "US Virgin Islands", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Wales", "Yemen", "Zambia", "Zimbabwe" };

                foreach (JToken team in player)
                {
                    if (!fifaRecognizedCountries.Contains(team["team"]["name"].ToString()))
                        return CalculatePlayerPrice(team["team"]["name"].ToString(), playersPosition);
                }
                return CalculatePlayerPrice(responseJSON["response"][0]["team"]["name"].ToString(), playersPosition);
            }
        }

        private void AddPlayerAndStatsTotals(Player player)
        {
            if (double.Parse(RemainingBudget_TXTBLK.Text) > player.Price)
            {
                AddPlayer(player);
                TeamScore_TXTBLK.Text = (double.Parse(TeamScore_TXTBLK.Text) + player.Rating).ToString();
                TeamValue_TXTBLK.Text = (double.Parse(TeamValue_TXTBLK.Text) + player.Price).ToString();
                if (RemainingBudget_TXTBLK.Text != "∞")
                    RemainingBudget_TXTBLK.Text = (double.Parse(RemainingBudget_TXTBLK.Text) - player.Price).ToString();
            }
            else
                MessageBox.Show("You can not afford this player!");
        }

        private void StartGame_BTN_Click(object sender, RoutedEventArgs e)
        {
            double enteredBudget = double.Parse(Budget_TXTBX.Text);
            if (enteredBudget != 0)
                RemainingBudget_TXTBLK.Text = enteredBudget.ToString();
        }

        private void Search_BTN_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBar.Text;
            _ = GetTopThreePlayers(search);
        }

        private async void Player1_BTN_Click(object sender, RoutedEventArgs e)
        {
            double price = await GetPlayerPrice(Player1ID_TXTBLK.Text, Player1Position_TXTBLK.Text);
            Player player = new Player(Player1Name_TXTBLK.Text, (BitmapImage)Player1Image_IMG.Source, Player1Position_TXTBLK.Text, price);
            AddPlayerAndStatsTotals(player);
        }

        private async void Player2_BTN_Click(object sender, RoutedEventArgs e)
        {
            double price = await GetPlayerPrice(Player2ID_TXTBLK.Text, Player2Position_TXTBLK.Text);
            Player player = new Player(Player2Name_TXTBLK.Text, (BitmapImage)Player2Image_IMG.Source, Player2Position_TXTBLK.Text, price);
            AddPlayerAndStatsTotals(player);
        }

        private async void Player3_BTN_Click(object sender, RoutedEventArgs e)
        {
            double price = await GetPlayerPrice(Player3ID_TXTBLK.Text, Player3Position_TXTBLK.Text);
            Player player = new Player(Player3Name_TXTBLK.Text, (BitmapImage)Player3Image_IMG.Source, Player3Position_TXTBLK.Text, price);
            AddPlayerAndStatsTotals(player);
        }
    }
}
