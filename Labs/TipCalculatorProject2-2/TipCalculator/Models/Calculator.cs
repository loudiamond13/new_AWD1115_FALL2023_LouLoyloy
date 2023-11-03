using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {

        [Required(ErrorMessage = "Please Enter A Value For Cost Of Meal.")]
        [Range(1, 100000, ErrorMessage = "Cost Of Meal Must Be 1 - 100000")]

        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            else 
            {
                return 0.0;
            }
        }
    }
}
