﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SportsPro.Models
{
    public class Product
    {
        public int ProductID { get; set; }  // primary key

        [Required(ErrorMessage = "Please Enter The Product Code.")]
        public string ProductCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter The Product Name.")]
        public string Name { get; set; } = string.Empty;


        
       
        [Column(TypeName = "decimal(8,2)")]
        [Range(0, 1000000, ErrorMessage = "Please Enter The Product Price.")]
        public decimal YearlyPrice { get; set; }

        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
}
