using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SportsPro.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }



      

       
        [Display(Name = "First Name")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Length must consist 1-25 character.")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        
        public string Address { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string State { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Country")]
        public string CountryID { get; set; } = string.Empty;

        //[ValidateNever]
        public Country? Country { get; set; }


        [ValidateNever]
        public string Phone { get; set; } = "";

        [ValidateNever]
        public string Email { get; set; } = "";



        public string FullName => FirstName + " " + LastName;   // read-only property

    }
}