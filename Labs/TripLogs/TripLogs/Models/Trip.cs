using System.ComponentModel.DataAnnotations;

namespace TripLogs.Models
{
    public class Trip
    {

        public int TripID { get; set; }

        [Required (ErrorMessage ="You Must Enter A Destination")]
        public string Destination { get; set;} = string.Empty;

        [Required(ErrorMessage ="You Must Provide A Trip Start Date")]
        public DateTime? StartDate { get; set;}


        [Required(ErrorMessage = "You Must Provide A Trip End Date")]
        public DateTime? EndDate { get; set; }

        public string? Accommodation { get; set; } = "";

        public string? AccommodationPhone { get; set; } = "";
        public string? AccommodationEmail { get; set; } = "";

        public string? ToDo1 { get; set; } = string.Empty;
        public string? ToDo2 { get; set; } = string.Empty;
        public string? ToDo3 { get; set; } = string.Empty;

    }
}
