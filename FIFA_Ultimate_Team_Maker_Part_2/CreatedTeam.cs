using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;
namespace FIFA_Ultimate_Team_Maker_Part_2
{
    class CreatedTeam
    {
        public List<Player> AllPlayers { get; set; } = new List<Player>();
        public List<Player> Attackers { get; set; } = new List<Player>();
        public List<Player> Midfielders { get; } = new List<Player>();
        public List<Player> Defenders { get; set; } = new List<Player>();
        public List<Player> Goalkeepers { get; set; } = new List<Player>();

        public void AddPlayer(Player player)
        {
            if (player.Position == "Attacker")
            {
                if (Attackers.Count < 3)
                {
                    Attackers.Add(player);
                    AllPlayers.Add(player);
                }
            }
            else if (player.Position == "Midfielder")
            {
                if (Midfielders.Count < 3)
                {
                    Midfielders.Add(player);
                    AllPlayers.Add(player);
                }
            }
            else if (player.Position == "Defender")
            {
                if (Defenders.Count < 4)
                {
                    Defenders.Add(player);
                    AllPlayers.Add(player);
                }
            }
            else if (player.Position == "Goalkeeper")
            {
                if (Goalkeepers.Count < 1)
                {
                    Goalkeepers.Add(player);
                    AllPlayers.Add(player);
                }
            }
        }

        public double GetTeamPrice()
        {
            double totalTeamValue = 0;
            foreach (Player person in AllPlayers)
                totalTeamValue += person.Price;
            return totalTeamValue;
        }

        public double GetTeamScore()
        {
            double totalScoreValue = 0;
            foreach (Player person in AllPlayers)
                totalScoreValue += person.Rating;
            return totalScoreValue;
        }

        public void SaveGame()
        {
            string path = @"C:\..\..\..\FIFA_Ultimate_Team_Maker_Part_2\Save.csv";

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Player player in AllPlayers)
                    sw.WriteLine($"{player.Name},{player.Photo},{player.Position},{player.Price}");
            }
        }

        public List<Player> LoadGame()
        {
            string path = @"C:\..\..\..\FIFA_Ultimate_Team_Maker_Part_2\Save.csv";
            List<Player> players = new List<Player>();

            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splittedLine = line.Split(',');

                    string name = splittedLine[0];
                    BitmapImage photo = new BitmapImage(new Uri(splittedLine[1]));
                    string position = splittedLine[2];
                    double Price = double.Parse(splittedLine[3]);

                    Player player = new Player(name, photo, position, Price);
                    AddPlayer(player);
                    players.Add(player);
                }
            }
            return players;
        }
    }
}
