using System;
using System.Collections.Generic;

namespace APIService.Models
{
    public partial class TableUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public string Imgprofile { get; set; }
    }
}
