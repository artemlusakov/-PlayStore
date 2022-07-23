using Microsoft.AspNetCore.Mvc;

namespace Playstore.Models
{
    public class SaleGame : Controller
    {
        public int SaleID { get; set; }
        public int GameID { get; set; }
        public int UserID { get; set; }

        public Game? Game { get; set; }
    }
}
