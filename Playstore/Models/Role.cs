using Microsoft.AspNetCore.Mvc;

namespace Playstore.Models
{
    public class Role
    {
        public int RoleID  { get; set; }
        public string RoleName { get; set; }
        public uint Price { get; set; }
    }
}
