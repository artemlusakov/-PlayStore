using Microsoft.AspNetCore.Mvc;

namespace Playstore.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public char Description { get; set; }
    }
}
