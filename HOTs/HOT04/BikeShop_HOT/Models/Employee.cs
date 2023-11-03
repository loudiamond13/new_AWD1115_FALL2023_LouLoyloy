using System.ComponentModel.DataAnnotations;

namespace BikeShop_HOT.Models
{
    public class Employee
    {

        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Employee First Name is Required!")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee Last Name is Required!")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee Address is Required!")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee City is Required!")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee State is Required!")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee Zip Code is Required!")]
        public string ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee Phone Number is Required!")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
