using System.ComponentModel.DataAnnotations;

namespace NET_Mom4.Models {

    // Track list
    public class Track {

        // Properties
        public int TrackId { get; set; } // ID
        public string? Aritst { get; set; } // Artist

        [Required]
        public string? Title { get; set; } // Title

        public int Length { get; set; } // Track length in seconds
        public string? Category { get; set; } // Categories

    }

}