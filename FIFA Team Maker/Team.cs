namespace FIFA_Team_Maker
{
    class CreatedTeam
    {
        public List<Player> Attackers { get; set; }
        public List<Player> Midfielders { get; }
        public List<Player> Defenders { get; set; }
        public List<Player> Goalkeepers { get; set; }

        public void AddPlayer(Player player)
        {
            if (player.Position == "Attacker")
            {
                if (Attackers.Count < 3)
                {
                    Attackers.Add(player);
                }
            }
            else if (player.Position == "Midfielder")
            {
                if (Midfielders.Count < 3)
                {
                    Midfielders.Add(player);
                }
            }
            else if (player.Position == "Defender")
            {
                if (Defenders.Count < 4)
                {
                    Defenders.Add(player);
                }
            }
            else if (player.Position == "Goalkeeper")
            {
                if (Goalkeepers.Count < 1)
                {
                    Goalkeepers.Add(player);
                }
            }
        }

        // for printing to json:
            // for player in Attacker... for player in Midfielders...
            // Add rating, name, photo to json
    }
}
