using System;
using System.Collections.Generic;

namespace App.API.Models
{
    public class User
    {
        public int  Id { get; set; }
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Type { get; set; }

        public DateTime FoundedIn { get; set; }

        public string KnownAs { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastActive { get; set; }

        public string Description { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
        
        public ICollection<Photo> Photos { get; set; }

        public ICollection<Like> Likers { get; set; }

        public ICollection<Like> Likees { get; set; }
    }
}