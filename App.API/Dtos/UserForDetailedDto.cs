using System;
using App.API.Models;
using System.Collections.Generic;
using App.API.Dtos;

namespace App.API.Dtos
{
    public class UserForDetailedDto
    {
        public int  Id { get; set; }
        public string Username { get; set; }

        public string Type { get; set; }

        public int YearsActive { get; set; }

        public string KnownAs { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastActive { get; set; }

        public string Description { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string PhotoUrl { get; set; }

        public ICollection<PhotosForDetailedDto> Photos { get; set; }
        
    }
}