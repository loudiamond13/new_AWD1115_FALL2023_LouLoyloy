using System.ComponentModel.DataAnnotations;

namespace BikeShop_HOT.Models
{
    public class Vendor
    {
        public int VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Name is Required!")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vendor Address is Required!")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vendor City is Required!")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vendor State is Required!")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vendor Zip Code is Required!")]
        public string ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vendor Phone Number is Required!")]
        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
