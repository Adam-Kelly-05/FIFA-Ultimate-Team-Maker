using System.Collections.Generic;
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
            {
                totalTeamValue += person.Price;
            }
            return totalTeamValue;
        }

        public double GetTeamScore()
        {
            double totalScoreValue = 0;
            foreach (Player person in AllPlayers)
            {
                totalScoreValue += person.Rating;
            }
            return totalScoreValue;
        }

        // for printing to json:
        // for player in Attacker... for player in Midfielders...
        // Add rating, name, photo to json
    }
}
