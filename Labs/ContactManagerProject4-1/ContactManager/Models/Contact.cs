using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {

        public int ContactID { get; set; }  // primary key

        [Required(ErrorMessage = "Please Enter Contact First Name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter Contact Last Name.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter Contact Phone Number.")]
        public string PhoneNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter Contact Email Address.")]
        public string Email { get; set; } = string.Empty;


        public string Organization { get; set; } = "";

        public DateTime DateAdded { get; set; }


        // foreign key
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter Contact Category. ")]
        public int CategoryID { get; set; }

        [ValidateNever]
        public Category? Category { get; set; }



        // read only property
        public string Slug => FirstName?.Replace(' ', '-').ToLower() 
                        +'-'+ LastName?.Replace(' ', '-').ToLower();


    }
}
