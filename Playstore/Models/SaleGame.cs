using Microsoft.AspNetCore.Mvc;

namespace Playstore.Models
{
    public class SaleGame
    {
        public int SaleID { get; set; }
        public int GameID { get; set; }
        public int UserID { get; set; }

        public User? User { get; set; }
        public Game? Game { get; set; }
    }
}
