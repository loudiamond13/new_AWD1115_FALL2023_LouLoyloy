﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SportsPro.Models
{
    public class Product
    {
        public int ProductID { get; set; }  // primary key

        [Required]
        public string ProductCode { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(0, 1000000)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal YearlyPrice { get; set; }

        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
}
