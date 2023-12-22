using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Gender
    {
        public int GenderID { get; set; }

        [Required(ErrorMessage ="Please enter a gender.")]
        public string GenderName { get; set; } = string.Empty;
    }
}
