using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Brand
    {
        public int BrandID { get; set; }

        [Required(ErrorMessage ="Please enter a brand name.")]
        public string BrandName { get; set; } = string.Empty;
    }
}
