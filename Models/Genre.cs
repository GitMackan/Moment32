using System.ComponentModel.DataAnnotations;

namespace Moment32.Models {
    public class Genre {
        // Properties
        public int Id { get; set; }

        [Required(ErrorMessage = "Ange genrenamn.")]
        public string? GenreName { get; set; }

        public List<Record>? Records { get; set; }
    }
}