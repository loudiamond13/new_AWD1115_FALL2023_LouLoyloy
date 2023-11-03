using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsPro.Models
{
    public class Incident 
    {
        public int IncidentID { get; set; }

        [ForeignKey("CustomerID")]
        [Required]
        public int CustomerID { get; set; }     // foreign key property
        public Customer? Customer { get; set; }  // navigation property

        [ForeignKey("ProductID")]
        [Required]
        public int ProductID { get; set; }     // foreign key property
        public Product? Product { get; set; }   // navigation property

        public int? TechnicianID { get; set; }     // foreign key property - nullable
        [ForeignKey("TechnicianID")]
        public Technician? Technician { get; set; }   // navigation property

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime DateOpened { get; set; } 

        public DateTime? DateClosed { get; set; }
    }
}