﻿using System;
using System.Windows.Media.Imaging;

namespace FIFA_Ultimate_Team_Maker_Part_2
{
    class Player
    {
        public string Name { get; set; }
        public BitmapImage Photo { get; set; }
        public string Position { get; set; }
        public double Price { get; set; }
        public double Rating => Math.Floor((0.6 * Price) + 40);

        public Player(string name, BitmapImage photo, string position, double price)
        {
            Name = name;
            Photo = photo;
            Position = position;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
