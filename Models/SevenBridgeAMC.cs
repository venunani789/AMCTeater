using System.ComponentModel.DataAnnotations;

namespace SevenBridgeAMCProj.Models
{
    public class SevenBridgeAMC
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please select a Format.")]
        public string Format { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Showtime.")]
        //[RegularExpression(@"^(?:[01]\d|2[0-3]):[0-5]\d\s?–\s?(?:[01]\d|2[0-3]):[0-5]\d$", ErrorMessage = "Invalid time format. Please use HH:mm – HH:mm.")]
        public string? Showtime { get; set; }

        [Required(ErrorMessage = "Please enter a Price.")]
        [Range(1, 50, ErrorMessage = "Price must be between 1 and 50.")]
        public int? Price { get; set; }
    }
}
