using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Technician
    {

        public int TechnicianID { get; set; } // primary Key

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;
    }
}
