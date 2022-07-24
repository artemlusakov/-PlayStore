using Microsoft.AspNetCore.Mvc;

namespace Playstore.Models
{
    public class Role
    {
        public int RoleId  { get; set; }
        public string RoleName { get; set; }
        public uint price { get; set; }
    }
}
