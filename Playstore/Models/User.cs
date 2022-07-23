using Microsoft.AspNetCore.Mvc;

namespace Playstore.Models
{
    public class User : Controller
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Wallet { get; set; }

        public SaleGame? SaleGame { get; set; }
    }
}
