using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }





        [Required(ErrorMessage = "Please Enter A First Name.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter A Last Name.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter The Address.")]
        [StringLength(50)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter A City.")]
        [StringLength(50)]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter A State.")]
        [StringLength(50)]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter A Postal Code.")]
        [Display(Name = "Postal Code")]
        [StringLength(20)]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Select A Country.")]
        [Display(Name = "Country")]
        public string CountryID { get; set; } = string.Empty;

        [ValidateNever]
        public Country? Country { get; set; }


        [RegularExpression(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$",
            ErrorMessage = "Phone Number Must Be In (000) 000-0000 Format.")]
        public string Phone { get; set; } = "";


        [Required(ErrorMessage = "Please Enter A Valid E-mail.")]
        [StringLength(70)]
        [DataType(DataType.EmailAddress)]
        [Remote("ValidateEmail", "Validation", AdditionalFields = "CustomerID")]
        public string? Email { get; set; }

        public ICollection<Registration>? Registrations { get; set; }

        public string FullName => FirstName + " " + LastName;   // read-only property

    }
}