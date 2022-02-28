using System.ComponentModel.DataAnnotations;

namespace Moment32.Models {
    public class Record {
        // Properties
        public int Id { get; set; }

        [Required(ErrorMessage = "Ange album.")]
        [Display(Name = "Album")]
        public string? RecordName { get; set; }

        [Required(ErrorMessage = "Ange artist.")]
        [Display(Name = "Artist")]
        public string? ArtistName { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public Genre? Genre { get; set; }
    }
}