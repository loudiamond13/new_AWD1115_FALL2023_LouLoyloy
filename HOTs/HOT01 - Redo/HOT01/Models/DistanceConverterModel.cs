using System.ComponentModel.DataAnnotations;

namespace HOT01.Models
{
    public class DistanceConverterModel
    {
        const double CM_PER_IN = 2.54;

        [Required(ErrorMessage = "PLEASE ENTER DISTANCE IN INCHES")]
        [Range(1, 500, ErrorMessage = "PLEASE ENTER DISTANCE 1-500")]

        public double? DistanceInInches  { get; set; }

        public string DistanceInCentimeters()
        {
            if (DistanceInInches.HasValue)
            {
                var convertedInchesToCentimeters = DistanceInInches.Value * CM_PER_IN;
                
                return string.Format("{0:0.00}", DistanceInInches.Value) + " inches in  " + string.Format("{0:0.00}", convertedInchesToCentimeters) + " Centimeters";
            }
            else 
            {
                return "";
            }
        }
    }
}
