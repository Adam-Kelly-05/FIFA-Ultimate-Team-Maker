using System.Collections.Generic;
using System.Data.Entity;

namespace FIFA_Ultimate_Team_Maker_Part_2
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Ranking { get; set; }
        public int Value { get; set; }

        public int LeagueID { get; set; }
        public virtual League League { get; set; }
    }

    public class League
    {
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public int LeagueRank { get; set; }
        public int LeagueValue { get; set; }

        public virtual List<Team> Teams { get; set; }
    }

    public class LeagueData : DbContext
    {
        public LeagueData() : base("Top10LeaguesData") { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}
