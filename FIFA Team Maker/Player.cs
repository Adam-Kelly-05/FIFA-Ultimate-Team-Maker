using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Windows.Media.Imaging;

namespace FIFA_Team_Maker
{
    //TeamData db = new TeamData();

    class Player
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public BitmapImage Photo { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }

        private async Task APICalls()
        {
            string apiKey = "496d47c537f35ec7b40b14859f19a74e";
            string apiUrl = $"https://v3.football.api-sports.io/players/teams?player={ID}";

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-rapidapi-key", apiKey);
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string responseString = await response.Content.ReadAsStringAsync();

            JObject responseJSON = JObject.Parse(responseString);

            JToken player = responseJSON["response"];

            string team = player["team"]["name"].ToString();

            //var query = from t in db.teams
            //            where 
        }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                price = 0;

                // List of all countries, use players id to search their team, ignore the team if it's in the list of countries
                // Then use database to fill formula
            }
        }

        private double rating;
        public double Rating
        {
            get { return rating; }
            set
            {
                rating = Math.Floor((0.6 * price) + 40);
            }
        }

        public Player(string name, BitmapImage photo, string position)
        {
            Name = name;
            Photo = photo;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
