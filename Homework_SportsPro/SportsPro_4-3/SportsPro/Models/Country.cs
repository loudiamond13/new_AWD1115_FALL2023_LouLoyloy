using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Country
    {
        [Required]
        public string CountryID { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
