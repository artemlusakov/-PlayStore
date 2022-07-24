using Microsoft.AspNetCore.Mvc;

namespace Playstore.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string? NameGame { get; set; }
        public int GenreID { get; set; }
        public int DeveloperID { get; set; }
        public string? Description { get; set; }
        public uint Price { get; set; }

        public Genre? Genre { get; set; }
        public Developer? Developer { get; set; }
    }
}
