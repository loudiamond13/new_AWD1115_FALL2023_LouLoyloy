using System.ComponentModel.DataAnnotations;

namespace BikeShop_HOT.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Customer First Name is Required!")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Customer Last Name is Required!")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Customer Address is Required!")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Customer City is Required!")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Customer State is Required!")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Customer Zip Code is Required!")]
        public string ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Customer Phone Number is Required!")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
