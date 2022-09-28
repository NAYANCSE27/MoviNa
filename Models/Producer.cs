﻿using System.ComponentModel.DataAnnotations;

namespace MoviNa.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

    }
}
