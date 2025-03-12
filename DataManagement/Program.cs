﻿using FIFA_Ultimate_Team_Maker_Part_2;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeagueData db = new LeagueData();

            using (db)
            {
                League league1 = new League() { LeagueId = 1, LeagueName = "Premier League", LeagueRank = 1, LeagueValue = 20 };
                League league2 = new League() { LeagueId = 2, LeagueName = "La Liga", LeagueRank = 2, LeagueValue = 18 };
                League league3 = new League() { LeagueId = 3, LeagueName = "Bundesliga", LeagueRank = 3, LeagueValue = 16 };
                League league4 = new League() { LeagueId = 4, LeagueName = "Serie A", LeagueRank = 4, LeagueValue = 14 };
                League league5 = new League() { LeagueId = 5, LeagueName = "Ligue 1", LeagueRank = 5, LeagueValue = 12 };
                League league6 = new League() { LeagueId = 6, LeagueName = "Portuguese Primeira Liga", LeagueRank = 6, LeagueValue = 10 };
                League league7 = new League() { LeagueId = 7, LeagueName = "Belgian Pro League", LeagueRank = 7, LeagueValue = 8 };
                League league8 = new League() { LeagueId = 8, LeagueName = "Dutch Eredivisie", LeagueRank = 8, LeagueValue = 6 };
                League league9 = new League() { LeagueId = 9, LeagueName = "Super Lig", LeagueRank = 9, LeagueValue = 4 };
                League league10 = new League() { LeagueId = 10, LeagueName = "Major League Soccer", LeagueRank = 10, LeagueValue = 2 };

                db.Leagues.Add(league1);
                db.Leagues.Add(league2);
                db.Leagues.Add(league3);
                db.Leagues.Add(league4);
                db.Leagues.Add(league5);
                db.Leagues.Add(league6);
                db.Leagues.Add(league7);
                db.Leagues.Add(league8);
                db.Leagues.Add(league9);
                db.Leagues.Add(league10);

                Team team1 = new Team() { TeamId = 1, TeamName = "Manchester City", Ranking = 1, Value = 20, League = league1, LeagueID = 1 };
                Team team2 = new Team() { TeamId = 2, TeamName = "Arsenal", Ranking = 2, Value = 19, League = league1, LeagueID = 1 };
                Team team3 = new Team() { TeamId = 3, TeamName = "Liverpool", Ranking = 3, Value = 18, League = league1, LeagueID = 1 };
                Team team4 = new Team() { TeamId = 4, TeamName = "Aston Villa", Ranking = 4, Value = 17, League = league1, LeagueID = 1 };
                Team team5 = new Team() { TeamId = 5, TeamName = "Tottenham Hotspur", Ranking = 5, Value = 16, League = league1, LeagueID = 1 };
                Team team6 = new Team() { TeamId = 6, TeamName = "Chelsea", Ranking = 6, Value = 15, League = league1, LeagueID = 1 };
                Team team7 = new Team() { TeamId = 7, TeamName = "Newcastle United", Ranking = 7, Value = 14, League = league1, LeagueID = 1 };
                Team team8 = new Team() { TeamId = 8, TeamName = "Manchester City", Ranking = 8, Value = 13, League = league1, LeagueID = 1 };
                Team team9 = new Team() { TeamId = 9, TeamName = "West Ham United", Ranking = 9, Value = 12, League = league1, LeagueID = 1 };
                Team team10 = new Team() { TeamId = 10, TeamName = "Crystal Palace", Ranking = 10, Value = 11, League = league1, LeagueID = 1 };
                Team team11 = new Team() { TeamId = 11, TeamName = "Brighton & Hove Albion", Ranking = 11, Value = 10, League = league1, LeagueID = 1 };
                Team team12 = new Team() { TeamId = 12, TeamName = "Bournemouth", Ranking = 12, Value = 9, League = league1, LeagueID = 1 };
                Team team13 = new Team() { TeamId = 13, TeamName = "Fulham", Ranking = 13, Value = 8, League = league1, LeagueID = 1 };
                Team team14 = new Team() { TeamId = 14, TeamName = "Wolverhampton Wanderers", Ranking = 14, Value = 7, League = league1, LeagueID = 1 };
                Team team15 = new Team() { TeamId = 15, TeamName = "Everton", Ranking = 15, Value = 6, League = league1, LeagueID = 1 };
                Team team16 = new Team() { TeamId = 16, TeamName = "Brentford", Ranking = 16, Value = 5, League = league1, LeagueID = 1 };
                Team team17 = new Team() { TeamId = 17, TeamName = "Nottingham Forest", Ranking = 17, Value = 4, League = league1, LeagueID = 1 };
                Team team18 = new Team() { TeamId = 18, TeamName = "Luton Town", Ranking = 18, Value = 3, League = league1, LeagueID = 1 };
                Team team19 = new Team() { TeamId = 19, TeamName = "Burnley", Ranking = 19, Value = 2, League = league1, LeagueID = 1 };
                Team team20 = new Team() { TeamId = 20, TeamName = "Sheffield United", Ranking = 20, Value = 1, League = league1, LeagueID = 1 };

                // DeepSeek Code

                Team team21 = new Team() { TeamId = 21, TeamName = "Real Madrid", Ranking = 1, Value = 20, League = league2, LeagueID = 2 };
                Team team22 = new Team() { TeamId = 22, TeamName = "Barcelona", Ranking = 2, Value = 19, League = league2, LeagueID = 2 };
                Team team23 = new Team() { TeamId = 23, TeamName = "Girona", Ranking = 3, Value = 18, League = league2, LeagueID = 2 };
                Team team24 = new Team() { TeamId = 24, TeamName = "Atlético Madrid", Ranking = 4, Value = 17, League = league2, LeagueID = 2 };
                Team team25 = new Team() { TeamId = 25, TeamName = "Athletic Bilbao", Ranking = 5, Value = 16, League = league2, LeagueID = 2 };
                Team team26 = new Team() { TeamId = 26, TeamName = "Real Sociedad", Ranking = 6, Value = 15, League = league2, LeagueID = 2 };
                Team team27 = new Team() { TeamId = 27, TeamName = "Real Betis", Ranking = 7, Value = 14, League = league2, LeagueID = 2 };
                Team team28 = new Team() { TeamId = 28, TeamName = "Villarreal", Ranking = 8, Value = 13, League = league2, LeagueID = 2 };
                Team team29 = new Team() { TeamId = 29, TeamName = "Valencia", Ranking = 9, Value = 12, League = league2, LeagueID = 2 };
                Team team30 = new Team() { TeamId = 30, TeamName = "Getafe", Ranking = 10, Value = 11, League = league2, LeagueID = 2 };
                Team team31 = new Team() { TeamId = 31, TeamName = "Alavés", Ranking = 11, Value = 10, League = league2, LeagueID = 2 };
                Team team32 = new Team() { TeamId = 32, TeamName = "Sevilla", Ranking = 12, Value = 9, League = league2, LeagueID = 2 };
                Team team33 = new Team() { TeamId = 33, TeamName = "Osasuna", Ranking = 13, Value = 8, League = league2, LeagueID = 2 };
                Team team34 = new Team() { TeamId = 34, TeamName = "Las Palmas", Ranking = 14, Value = 7, League = league2, LeagueID = 2 };
                Team team35 = new Team() { TeamId = 35, TeamName = "Rayo Vallecano", Ranking = 15, Value = 6, League = league2, LeagueID = 2 };
                Team team36 = new Team() { TeamId = 36, TeamName = "Mallorca", Ranking = 16, Value = 5, League = league2, LeagueID = 2 };
                Team team37 = new Team() { TeamId = 37, TeamName = "Celta Vigo", Ranking = 17, Value = 4, League = league2, LeagueID = 2 };
                Team team38 = new Team() { TeamId = 38, TeamName = "Cádiz", Ranking = 18, Value = 3, League = league2, LeagueID = 2 };
                Team team39 = new Team() { TeamId = 39, TeamName = "Granada", Ranking = 19, Value = 2, League = league2, LeagueID = 2 };
                Team team40 = new Team() { TeamId = 40, TeamName = "Almería", Ranking = 20, Value = 1, League = league2, LeagueID = 2 };

                Team team41 = new Team() { TeamId = 41, TeamName = "Bayer Leverkusen", Ranking = 1, Value = 20, League = league3, LeagueID = 3 };
                Team team42 = new Team() { TeamId = 42, TeamName = "Bayern Munich", Ranking = 2, Value = 19, League = league3, LeagueID = 3 };
                Team team43 = new Team() { TeamId = 43, TeamName = "VfB Stuttgart", Ranking = 3, Value = 18, League = league3, LeagueID = 3 };
                Team team44 = new Team() { TeamId = 44, TeamName = "RB Leipzig", Ranking = 4, Value = 17, League = league3, LeagueID = 3 };
                Team team45 = new Team() { TeamId = 45, TeamName = "Borussia Dortmund", Ranking = 5, Value = 16, League = league3, LeagueID = 3 };
                Team team46 = new Team() { TeamId = 46, TeamName = "Eintracht Frankfurt", Ranking = 6, Value = 15, League = league3, LeagueID = 3 };
                Team team47 = new Team() { TeamId = 47, TeamName = "TSG Hoffenheim", Ranking = 7, Value = 14, League = league3, LeagueID = 3 };
                Team team48 = new Team() { TeamId = 48, TeamName = "SC Freiburg", Ranking = 8, Value = 13, League = league3, LeagueID = 3 };
                Team team49 = new Team() { TeamId = 49, TeamName = "FC Augsburg", Ranking = 9, Value = 12, League = league3, LeagueID = 3 };
                Team team50 = new Team() { TeamId = 50, TeamName = "VfL Wolfsburg", Ranking = 10, Value = 11, League = league3, LeagueID = 3 };
                Team team51 = new Team() { TeamId = 51, TeamName = "Borussia Mönchengladbach", Ranking = 11, Value = 9, League = league3, LeagueID = 3 };
                Team team52 = new Team() { TeamId = 52, TeamName = "Werder Bremen", Ranking = 12, Value = 7, League = league3, LeagueID = 3 };
                Team team53 = new Team() { TeamId = 53, TeamName = "1. FC Heidenheim", Ranking = 13, Value = 6, League = league3, LeagueID = 3 };
                Team team54 = new Team() { TeamId = 54, TeamName = "1. FC Union Berlin", Ranking = 14, Value = 5, League = league3, LeagueID = 3 };
                Team team55 = new Team() { TeamId = 55, TeamName = "VfL Bochum", Ranking = 15, Value = 4, League = league3, LeagueID = 3 };
                Team team56 = new Team() { TeamId = 56, TeamName = "Mainz 05", Ranking = 16, Value = 3, League = league3, LeagueID = 3 };
                Team team57 = new Team() { TeamId = 57, TeamName = "1. FC Köln", Ranking = 17, Value = 2, League = league3, LeagueID = 3 };
                Team team58 = new Team() { TeamId = 58, TeamName = "Darmstadt 98", Ranking = 18, Value = 1, League = league3, LeagueID = 3 };

                Team team59 = new Team() { TeamId = 59, TeamName = "Inter Milan", Ranking = 1, Value = 20, League = league4, LeagueID = 4 };
                Team team60 = new Team() { TeamId = 60, TeamName = "AC Milan", Ranking = 2, Value = 19, League = league4, LeagueID = 4 };
                Team team61 = new Team() { TeamId = 61, TeamName = "Juventus", Ranking = 3, Value = 18, League = league4, LeagueID = 4 };
                Team team62 = new Team() { TeamId = 62, TeamName = "Atalanta", Ranking = 4, Value = 17, League = league4, LeagueID = 4 };
                Team team63 = new Team() { TeamId = 63, TeamName = "Bologna", Ranking = 5, Value = 16, League = league4, LeagueID = 4 };
                Team team64 = new Team() { TeamId = 64, TeamName = "Roma", Ranking = 6, Value = 15, League = league4, LeagueID = 4 };
                Team team65 = new Team() { TeamId = 65, TeamName = "Lazio", Ranking = 7, Value = 14, League = league4, LeagueID = 4 };
                Team team66 = new Team() { TeamId = 66, TeamName = "Fiorentina", Ranking = 8, Value = 13, League = league4, LeagueID = 4 };
                Team team67 = new Team() { TeamId = 67, TeamName = "Torino", Ranking = 9, Value = 12, League = league4, LeagueID = 4 };
                Team team68 = new Team() { TeamId = 68, TeamName = "Napoli", Ranking = 10, Value = 11, League = league4, LeagueID = 4 };
                Team team69 = new Team() { TeamId = 69, TeamName = "Genoa", Ranking = 11, Value = 10, League = league4, LeagueID = 4 };
                Team team70 = new Team() { TeamId = 70, TeamName = "Monza", Ranking = 12, Value = 9, League = league4, LeagueID = 4 };
                Team team71 = new Team() { TeamId = 71, TeamName = "Hellas Verona", Ranking = 13, Value = 8, League = league4, LeagueID = 4 };
                Team team72 = new Team() { TeamId = 72, TeamName = "Lecce", Ranking = 14, Value = 7, League = league4, LeagueID = 4 };
                Team team73 = new Team() { TeamId = 73, TeamName = "Udinese", Ranking = 15, Value = 6, League = league4, LeagueID = 4 };
                Team team74 = new Team() { TeamId = 74, TeamName = "Cagliari", Ranking = 16, Value = 5, League = league4, LeagueID = 4 };
                Team team75 = new Team() { TeamId = 75, TeamName = "Empoli", Ranking = 17, Value = 4, League = league4, LeagueID = 4 };
                Team team76 = new Team() { TeamId = 76, TeamName = "Frosinone", Ranking = 18, Value = 3, League = league4, LeagueID = 4 };
                Team team77 = new Team() { TeamId = 77, TeamName = "Sassuolo", Ranking = 19, Value = 2, League = league4, LeagueID = 4 };
                Team team78 = new Team() { TeamId = 78, TeamName = "Salernitana", Ranking = 20, Value = 1, League = league4, LeagueID = 4 };

                Team team79 = new Team() { TeamId = 79, TeamName = "Paris Saint-Germain", Ranking = 1, Value = 20, League = league5, LeagueID = 5 };
                Team team80 = new Team() { TeamId = 80, TeamName = "Monaco", Ranking = 2, Value = 19, League = league5, LeagueID = 5 };
                Team team81 = new Team() { TeamId = 81, TeamName = "Lille", Ranking = 3, Value = 18, League = league5, LeagueID = 5 };
                Team team82 = new Team() { TeamId = 82, TeamName = "Brest", Ranking = 4, Value = 17, League = league5, LeagueID = 5 };
                Team team83 = new Team() { TeamId = 83, TeamName = "Nice", Ranking = 5, Value = 16, League = league5, LeagueID = 5 };
                Team team84 = new Team() { TeamId = 84, TeamName = "Lyon", Ranking = 6, Value = 15, League = league5, LeagueID = 5 };
                Team team85 = new Team() { TeamId = 85, TeamName = "Lens", Ranking = 7, Value = 14, League = league5, LeagueID = 5 };
                Team team86 = new Team() { TeamId = 86, TeamName = "Marseille", Ranking = 8, Value = 13, League = league5, LeagueID = 5 };
                Team team87 = new Team() { TeamId = 87, TeamName = "Reims", Ranking = 9, Value = 12, League = league5, LeagueID = 5 };
                Team team88 = new Team() { TeamId = 88, TeamName = "Rennes", Ranking = 10, Value = 11, League = league5, LeagueID = 5 };
                Team team89 = new Team() { TeamId = 89, TeamName = "Toulouse", Ranking = 11, Value = 9, League = league5, LeagueID = 5 };
                Team team90 = new Team() { TeamId = 90, TeamName = "Montpellier", Ranking = 12, Value = 7, League = league5, LeagueID = 5 };
                Team team91 = new Team() { TeamId = 91, TeamName = "Strasbourg", Ranking = 13, Value = 6, League = league5, LeagueID = 5 };
                Team team92 = new Team() { TeamId = 92, TeamName = "Nantes", Ranking = 14, Value = 5, League = league5, LeagueID = 5 };
                Team team93 = new Team() { TeamId = 93, TeamName = "Le Havre", Ranking = 15, Value = 4, League = league5, LeagueID = 5 };
                Team team94 = new Team() { TeamId = 94, TeamName = "Lorient", Ranking = 16, Value = 3, League = league5, LeagueID = 5 };
                Team team95 = new Team() { TeamId = 95, TeamName = "Clermont Foot", Ranking = 17, Value = 2, League = league5, LeagueID = 5 };
                Team team96 = new Team() { TeamId = 96, TeamName = "Metz", Ranking = 18, Value = 1, League = league5, LeagueID = 5 };

                Team team97 = new Team() { TeamId = 97, TeamName = "Benfica", Ranking = 1, Value = 20, League = league6, LeagueID = 6 };
                Team team98 = new Team() { TeamId = 98, TeamName = "Porto", Ranking = 2, Value = 19, League = league6, LeagueID = 6 };
                Team team99 = new Team() { TeamId = 99, TeamName = "Sporting CP", Ranking = 3, Value = 18, League = league6, LeagueID = 6 };
                Team team100 = new Team() { TeamId = 100, TeamName = "Braga", Ranking = 4, Value = 17, League = league6, LeagueID = 6 };
                Team team101 = new Team() { TeamId = 101, TeamName = "Vitória Guimarães", Ranking = 5, Value = 16, League = league6, LeagueID = 6 };
                Team team102 = new Team() { TeamId = 102, TeamName = "Moreirense", Ranking = 6, Value = 15, League = league6, LeagueID = 6 };
                Team team103 = new Team() { TeamId = 103, TeamName = "Arouca", Ranking = 7, Value = 14, League = league6, LeagueID = 6 };
                Team team104 = new Team() { TeamId = 104, TeamName = "Famalicão", Ranking = 8, Value = 13, League = league6, LeagueID = 6 };
                Team team105 = new Team() { TeamId = 105, TeamName = "Casa Pia", Ranking = 9, Value = 12, League = league6, LeagueID = 6 };
                Team team106 = new Team() { TeamId = 106, TeamName = "Estoril", Ranking = 10, Value = 11, League = league6, LeagueID = 6 };
                Team team107 = new Team() { TeamId = 107, TeamName = "Boavista", Ranking = 11, Value = 9, League = league6, LeagueID = 6 };
                Team team108 = new Team() { TeamId = 108, TeamName = "Portimonense", Ranking = 12, Value = 7, League = league6, LeagueID = 6 };
                Team team109 = new Team() { TeamId = 109, TeamName = "Gil Vicente", Ranking = 13, Value = 6, League = league6, LeagueID = 6 };
                Team team110 = new Team() { TeamId = 110, TeamName = "Rio Ave", Ranking = 14, Value = 5, League = league6, LeagueID = 6 };
                Team team111 = new Team() { TeamId = 111, TeamName = "Farense", Ranking = 15, Value = 4, League = league6, LeagueID = 6 };
                Team team112 = new Team() { TeamId = 112, TeamName = "Estrela da Amadora", Ranking = 16, Value = 3, League = league6, LeagueID = 6 };
                Team team113 = new Team() { TeamId = 113, TeamName = "Chaves", Ranking = 17, Value = 2, League = league6, LeagueID = 6 };
                Team team114 = new Team() { TeamId = 114, TeamName = "Vizela", Ranking = 18, Value = 1, League = league6, LeagueID = 6 };

                Team team115 = new Team() { TeamId = 115, TeamName = "Union SG", Ranking = 1, Value = 20, League = league7, LeagueID = 7 };
                Team team116 = new Team() { TeamId = 116, TeamName = "Anderlecht", Ranking = 2, Value = 19, League = league7, LeagueID = 7 };
                Team team117 = new Team() { TeamId = 117, TeamName = "Royal Antwerp", Ranking = 3, Value = 18, League = league7, LeagueID = 7 };
                Team team118 = new Team() { TeamId = 118, TeamName = "Club Brugge", Ranking = 4, Value = 17, League = league7, LeagueID = 7 };
                Team team119 = new Team() { TeamId = 119, TeamName = "Gent", Ranking = 5, Value = 16, League = league7, LeagueID = 7 };
                Team team120 = new Team() { TeamId = 120, TeamName = "Cercle Brugge", Ranking = 6, Value = 15, League = league7, LeagueID = 7 };
                Team team121 = new Team() { TeamId = 121, TeamName = "Genk", Ranking = 7, Value = 14, League = league7, LeagueID = 7 };
                Team team122 = new Team() { TeamId = 122, TeamName = "Mechelen", Ranking = 8, Value = 13, League = league7, LeagueID = 7 };
                Team team123 = new Team() { TeamId = 123, TeamName = "Standard Liège", Ranking = 9, Value = 11, League = league7, LeagueID = 7 };
                Team team124 = new Team() { TeamId = 124, TeamName = "Westerlo", Ranking = 10, Value = 9, League = league7, LeagueID = 7 };
                Team team125 = new Team() { TeamId = 125, TeamName = "OH Leuven", Ranking = 11, Value = 7, League = league7, LeagueID = 7 };
                Team team126 = new Team() { TeamId = 126, TeamName = "Charleroi", Ranking = 12, Value = 5, League = league7, LeagueID = 7 };
                Team team127 = new Team() { TeamId = 127, TeamName = "Kortrijk", Ranking = 13, Value = 4, League = league7, LeagueID = 7 };
                Team team128 = new Team() { TeamId = 128, TeamName = "Eupen", Ranking = 14, Value = 3, League = league7, LeagueID = 7 };
                Team team129 = new Team() { TeamId = 129, TeamName = "Sint-Truiden", Ranking = 15, Value = 2, League = league7, LeagueID = 7 };
                Team team130 = new Team() { TeamId = 130, TeamName = "RWDM", Ranking = 16, Value = 1, League = league7, LeagueID = 7 };

                Team team131 = new Team() { TeamId = 131, TeamName = "PSV Eindhoven", Ranking = 1, Value = 20, League = league8, LeagueID = 8 };
                Team team132 = new Team() { TeamId = 132, TeamName = "Feyenoord", Ranking = 2, Value = 19, League = league8, LeagueID = 8 };
                Team team133 = new Team() { TeamId = 133, TeamName = "Twente", Ranking = 3, Value = 18, League = league8, LeagueID = 8 };
                Team team134 = new Team() { TeamId = 134, TeamName = "AZ Alkmaar", Ranking = 4, Value = 17, League = league8, LeagueID = 8 };
                Team team135 = new Team() { TeamId = 135, TeamName = "Ajax", Ranking = 5, Value = 16, League = league8, LeagueID = 8 };
                Team team136 = new Team() { TeamId = 136, TeamName = "NEC Nijmegen", Ranking = 6, Value = 15, League = league8, LeagueID = 8 };
                Team team137 = new Team() { TeamId = 137, TeamName = "Utrecht", Ranking = 7, Value = 14, League = league8, LeagueID = 8 };
                Team team138 = new Team() { TeamId = 138, TeamName = "Sparta Rotterdam", Ranking = 8, Value = 13, League = league8, LeagueID = 8 };
                Team team139 = new Team() { TeamId = 139, TeamName = "Heerenveen", Ranking = 9, Value = 12, League = league8, LeagueID = 8 };
                Team team140 = new Team() { TeamId = 140, TeamName = "Fortuna Sittard", Ranking = 10, Value = 11, League = league8, LeagueID = 8 };
                Team team141 = new Team() { TeamId = 141, TeamName = "Go Ahead Eagles", Ranking = 11, Value = 9, League = league8, LeagueID = 8 };
                Team team142 = new Team() { TeamId = 142, TeamName = "PEC Zwolle", Ranking = 12, Value = 7, League = league8, LeagueID = 8 };
                Team team143 = new Team() { TeamId = 143, TeamName = "Almere City", Ranking = 13, Value = 6, League = league8, LeagueID = 8 };
                Team team144 = new Team() { TeamId = 144, TeamName = "Heracles Almelo", Ranking = 14, Value = 5, League = league8, LeagueID = 8 };
                Team team145 = new Team() { TeamId = 145, TeamName = "Excelsior", Ranking = 15, Value = 4, League = league8, LeagueID = 8 };
                Team team146 = new Team() { TeamId = 146, TeamName = "RKC Waalwijk", Ranking = 16, Value = 3, League = league8, LeagueID = 8 };
                Team team147 = new Team() { TeamId = 147, TeamName = "Volendam", Ranking = 17, Value = 2, League = league8, LeagueID = 8 };
                Team team148 = new Team() { TeamId = 148, TeamName = "Vitesse", Ranking = 18, Value = 1, League = league8, LeagueID = 8 };

                Team team149 = new Team() { TeamId = 149, TeamName = "Galatasaray", Ranking = 1, Value = 20, League = league9, LeagueID = 9 };
                Team team150 = new Team() { TeamId = 150, TeamName = "Fenerbahçe", Ranking = 2, Value = 19, League = league9, LeagueID = 9 };
                Team team151 = new Team() { TeamId = 151, TeamName = "Trabzonspor", Ranking = 3, Value = 18, League = league9, LeagueID = 9 };
                Team team152 = new Team() { TeamId = 152, TeamName = "Beşiktaş", Ranking = 4, Value = 17, League = league9, LeagueID = 9 };
                Team team153 = new Team() { TeamId = 153, TeamName = "Başakşehir", Ranking = 5, Value = 16, League = league9, LeagueID = 9 };
                Team team154 = new Team() { TeamId = 154, TeamName = "Kayserispor", Ranking = 6, Value = 15, League = league9, LeagueID = 9 };
                Team team155 = new Team() { TeamId = 155, TeamName = "Alanyaspor", Ranking = 7, Value = 14, League = league9, LeagueID = 9 };
                Team team156 = new Team() { TeamId = 156, TeamName = "Antalyaspor", Ranking = 8, Value = 13, League = league9, LeagueID = 9 };
                Team team157 = new Team() { TeamId = 157, TeamName = "Sivasspor", Ranking = 9, Value = 12, League = league9, LeagueID = 9 };
                Team team158 = new Team() { TeamId = 158, TeamName = "Adana Demirspor", Ranking = 10, Value = 11, League = league9, LeagueID = 9 };
                Team team159 = new Team() { TeamId = 159, TeamName = "Kasımpaşa", Ranking = 11, Value = 10, League = league9, LeagueID = 9 };
                Team team160 = new Team() { TeamId = 160, TeamName = "Hatayspor", Ranking = 12, Value = 9, League = league9, LeagueID = 9 };
                Team team161 = new Team() { TeamId = 161, TeamName = "Konyaspor", Ranking = 13, Value = 8, League = league9, LeagueID = 9 };
                Team team162 = new Team() { TeamId = 162, TeamName = "Gaziantep FK", Ranking = 14, Value = 7, League = league9, LeagueID = 9 };
                Team team163 = new Team() { TeamId = 163, TeamName = "İstanbulspor", Ranking = 15, Value = 6, League = league9, LeagueID = 9 };
                Team team164 = new Team() { TeamId = 164, TeamName = "Pendikspor", Ranking = 16, Value = 5, League = league9, LeagueID = 9 };
                Team team165 = new Team() { TeamId = 165, TeamName = "Fatih Karagümrük", Ranking = 17, Value = 4, League = league9, LeagueID = 9 };
                Team team166 = new Team() { TeamId = 166, TeamName = "Çaykur Rizespor", Ranking = 18, Value = 3, League = league9, LeagueID = 9 };
                Team team167 = new Team() { TeamId = 167, TeamName = "Samsunspor", Ranking = 19, Value = 2, League = league9, LeagueID = 9 };
                Team team168 = new Team() { TeamId = 168, TeamName = "Ankaragücü", Ranking = 20, Value = 1, League = league9, LeagueID = 9 };

                Team team169 = new Team() { TeamId = 169, TeamName = "Inter Miami CF", Ranking = 1, Value = 20, League = league10, LeagueID = 10 };
                Team team170 = new Team() { TeamId = 170, TeamName = "Columbus Crew", Ranking = 2, Value = 19, League = league10, LeagueID = 10 };
                Team team171 = new Team() { TeamId = 171, TeamName = "Los Angeles FC", Ranking = 3, Value = 18, League = league10, LeagueID = 10 };
                Team team172 = new Team() { TeamId = 172, TeamName = "LA Galaxy", Ranking = 4, Value = 17, League = league10, LeagueID = 10 };
                Team team173 = new Team() { TeamId = 173, TeamName = "FC Cincinnati", Ranking = 5, Value = 16, League = league10, LeagueID = 10 };
                Team team174 = new Team() { TeamId = 174, TeamName = "Real Salt Lake", Ranking = 6, Value = 15, League = league10, LeagueID = 10 };
                Team team175 = new Team() { TeamId = 175, TeamName = "Seattle Sounders FC", Ranking = 7, Value = 14, League = league10, LeagueID = 10 };
                Team team176 = new Team() { TeamId = 176, TeamName = "Houston Dynamo FC", Ranking = 8, Value = 13, League = league10, LeagueID = 10 };
                Team team177 = new Team() { TeamId = 177, TeamName = "Orlando City SC", Ranking = 9, Value = 12, League = league10, LeagueID = 10 };
                Team team178 = new Team() { TeamId = 178, TeamName = "Minnesota United FC", Ranking = 10, Value = 11, League = league10, LeagueID = 10 };
                Team team179 = new Team() { TeamId = 179, TeamName = "Charlotte FC", Ranking = 11, Value = 10, League = league10, LeagueID = 10 };
                Team team180 = new Team() { TeamId = 180, TeamName = "Colorado Rapids", Ranking = 12, Value = 9, League = league10, LeagueID = 10 };
                Team team181 = new Team() { TeamId = 181, TeamName = "New York City FC", Ranking = 13, Value = 9, League = league10, LeagueID = 10 };
                Team team182 = new Team() { TeamId = 182, TeamName = "Vancouver Whitecaps FC", Ranking = 14, Value = 8, League = league10, LeagueID = 10 };
                Team team183 = new Team() { TeamId = 183, TeamName = "Portland Timbers", Ranking = 15, Value = 8, League = league10, LeagueID = 10 };
                Team team184 = new Team() { TeamId = 184, TeamName = "New York Red Bulls", Ranking = 16, Value = 7, League = league10, LeagueID = 10 };
                Team team185 = new Team() { TeamId = 185, TeamName = "CF Montréal", Ranking = 17, Value = 7, League = league10, LeagueID = 10 };
                Team team186 = new Team() { TeamId = 186, TeamName = "Austin FC", Ranking = 18, Value = 6, League = league10, LeagueID = 10 };
                Team team187 = new Team() { TeamId = 187, TeamName = "FC Dallas", Ranking = 19, Value = 6, League = league10, LeagueID = 10 };
                Team team188 = new Team() { TeamId = 188, TeamName = "Atlanta United FC", Ranking = 20, Value = 5, League = league10, LeagueID = 10 };
                Team team189 = new Team() { TeamId = 189, TeamName = "D.C. United", Ranking = 21, Value = 5, League = league10, LeagueID = 10 };
                Team team190 = new Team() { TeamId = 190, TeamName = "Toronto FC", Ranking = 22, Value = 4, League = league10, LeagueID = 10 };
                Team team191 = new Team() { TeamId = 191, TeamName = "Philadelphia Union", Ranking = 23, Value = 4, League = league10, LeagueID = 10 };
                Team team192 = new Team() { TeamId = 192, TeamName = "St. Louis City SC", Ranking = 24, Value = 3, League = league10, LeagueID = 10 };
                Team team193 = new Team() { TeamId = 193, TeamName = "Nashville SC", Ranking = 25, Value = 3, League = league10, LeagueID = 10 };
                Team team194 = new Team() { TeamId = 194, TeamName = "New England Revolution", Ranking = 26, Value = 2, League = league10, LeagueID = 10 };
                Team team195 = new Team() { TeamId = 195, TeamName = "Sporting Kansas City", Ranking = 27, Value = 2, League = league10, LeagueID = 10 };
                Team team196 = new Team() { TeamId = 196, TeamName = "Chicago Fire FC", Ranking = 28, Value = 1, League = league10, LeagueID = 10 };
                Team team197 = new Team() { TeamId = 197, TeamName = "San Jose Earthquakes", Ranking = 29, Value = 1, League = league10, LeagueID = 10 };

                db.Teams.Add(team1);
                db.Teams.Add(team2);
                db.Teams.Add(team3);
                db.Teams.Add(team4);
                db.Teams.Add(team5);
                db.Teams.Add(team6);
                db.Teams.Add(team7);
                db.Teams.Add(team8);
                db.Teams.Add(team9);
                db.Teams.Add(team10);
                db.Teams.Add(team11);
                db.Teams.Add(team12);
                db.Teams.Add(team13);
                db.Teams.Add(team14);
                db.Teams.Add(team15);
                db.Teams.Add(team16);
                db.Teams.Add(team17);
                db.Teams.Add(team18);
                db.Teams.Add(team19);
                db.Teams.Add(team20);
                db.Teams.Add(team21);
                db.Teams.Add(team22);
                db.Teams.Add(team23);
                db.Teams.Add(team24);
                db.Teams.Add(team25);
                db.Teams.Add(team26);
                db.Teams.Add(team27);
                db.Teams.Add(team28);
                db.Teams.Add(team29);
                db.Teams.Add(team30);
                db.Teams.Add(team31);
                db.Teams.Add(team32);
                db.Teams.Add(team33);
                db.Teams.Add(team34);
                db.Teams.Add(team35);
                db.Teams.Add(team36);
                db.Teams.Add(team37);
                db.Teams.Add(team38);
                db.Teams.Add(team39);
                db.Teams.Add(team40);
                db.Teams.Add(team41);
                db.Teams.Add(team42);
                db.Teams.Add(team43);
                db.Teams.Add(team44);
                db.Teams.Add(team45);
                db.Teams.Add(team46);
                db.Teams.Add(team47);
                db.Teams.Add(team48);
                db.Teams.Add(team49);
                db.Teams.Add(team50);
                db.Teams.Add(team51);
                db.Teams.Add(team52);
                db.Teams.Add(team53);
                db.Teams.Add(team54);
                db.Teams.Add(team55);
                db.Teams.Add(team56);
                db.Teams.Add(team57);
                db.Teams.Add(team58);
                db.Teams.Add(team59);
                db.Teams.Add(team60);
                db.Teams.Add(team61);
                db.Teams.Add(team62);
                db.Teams.Add(team63);
                db.Teams.Add(team64);
                db.Teams.Add(team65);
                db.Teams.Add(team66);
                db.Teams.Add(team67);
                db.Teams.Add(team68);
                db.Teams.Add(team69);
                db.Teams.Add(team70);
                db.Teams.Add(team71);
                db.Teams.Add(team72);
                db.Teams.Add(team73);
                db.Teams.Add(team74);
                db.Teams.Add(team75);
                db.Teams.Add(team76);
                db.Teams.Add(team77);
                db.Teams.Add(team78);
                db.Teams.Add(team79);
                db.Teams.Add(team80);
                db.Teams.Add(team81);
                db.Teams.Add(team82);
                db.Teams.Add(team83);
                db.Teams.Add(team84);
                db.Teams.Add(team85);
                db.Teams.Add(team86);
                db.Teams.Add(team87);
                db.Teams.Add(team88);
                db.Teams.Add(team89);
                db.Teams.Add(team90);
                db.Teams.Add(team91);
                db.Teams.Add(team92);
                db.Teams.Add(team93);
                db.Teams.Add(team94);
                db.Teams.Add(team95);
                db.Teams.Add(team96);
                db.Teams.Add(team97);
                db.Teams.Add(team98);
                db.Teams.Add(team99);
                db.Teams.Add(team100);
                db.Teams.Add(team101);
                db.Teams.Add(team102);
                db.Teams.Add(team103);
                db.Teams.Add(team104);
                db.Teams.Add(team105);
                db.Teams.Add(team106);
                db.Teams.Add(team107);
                db.Teams.Add(team108);
                db.Teams.Add(team109);
                db.Teams.Add(team110);
                db.Teams.Add(team111);
                db.Teams.Add(team112);
                db.Teams.Add(team113);
                db.Teams.Add(team114);
                db.Teams.Add(team115);
                db.Teams.Add(team116);
                db.Teams.Add(team117);
                db.Teams.Add(team118);
                db.Teams.Add(team119);
                db.Teams.Add(team120);
                db.Teams.Add(team121);
                db.Teams.Add(team122);
                db.Teams.Add(team123);
                db.Teams.Add(team124);
                db.Teams.Add(team125);
                db.Teams.Add(team126);
                db.Teams.Add(team127);
                db.Teams.Add(team128);
                db.Teams.Add(team129);
                db.Teams.Add(team130);
                db.Teams.Add(team131);
                db.Teams.Add(team132);
                db.Teams.Add(team133);
                db.Teams.Add(team134);
                db.Teams.Add(team135);
                db.Teams.Add(team136);
                db.Teams.Add(team137);
                db.Teams.Add(team138);
                db.Teams.Add(team139);
                db.Teams.Add(team140);
                db.Teams.Add(team141);
                db.Teams.Add(team142);
                db.Teams.Add(team143);
                db.Teams.Add(team144);
                db.Teams.Add(team145);
                db.Teams.Add(team146);
                db.Teams.Add(team147);
                db.Teams.Add(team148);
                db.Teams.Add(team149);
                db.Teams.Add(team150);
                db.Teams.Add(team151);
                db.Teams.Add(team152);
                db.Teams.Add(team153);
                db.Teams.Add(team154);
                db.Teams.Add(team155);
                db.Teams.Add(team156);
                db.Teams.Add(team157);
                db.Teams.Add(team158);
                db.Teams.Add(team159);
                db.Teams.Add(team160);
                db.Teams.Add(team161);
                db.Teams.Add(team162);
                db.Teams.Add(team163);
                db.Teams.Add(team164);
                db.Teams.Add(team165);
                db.Teams.Add(team166);
                db.Teams.Add(team167);
                db.Teams.Add(team168);
                db.Teams.Add(team169);
                db.Teams.Add(team170);
                db.Teams.Add(team171);
                db.Teams.Add(team172);
                db.Teams.Add(team173);
                db.Teams.Add(team174);
                db.Teams.Add(team175);
                db.Teams.Add(team176);
                db.Teams.Add(team177);
                db.Teams.Add(team178);
                db.Teams.Add(team179);
                db.Teams.Add(team180);
                db.Teams.Add(team181);
                db.Teams.Add(team182);
                db.Teams.Add(team183);
                db.Teams.Add(team184);
                db.Teams.Add(team185);
                db.Teams.Add(team186);
                db.Teams.Add(team187);
                db.Teams.Add(team188);
                db.Teams.Add(team189);
                db.Teams.Add(team190);
                db.Teams.Add(team191);
                db.Teams.Add(team192);
                db.Teams.Add(team193);
                db.Teams.Add(team194);
                db.Teams.Add(team195);
                db.Teams.Add(team196);
                db.Teams.Add(team197);

                db.SaveChanges();
            }
        }
    }
}