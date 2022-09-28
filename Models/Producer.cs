using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviNa.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        // Relationships in different sector of database
        public List<Movie> Movies { get; set; }
    }
}
