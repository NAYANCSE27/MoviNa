﻿using MoviNa.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviNa.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships with database
        public List<Actor_Movie> Actors_Movies { get; set; }

        // Cinema relation
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema{ get; set; }

        // Producer relation
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Cinema Producer { get; set; }
    }
}
