﻿using System.ComponentModel.DataAnnotations;

namespace Fridge_Client.Models
{
    public class Product
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Name { get; set; }

        public int? DefaultQuantity { get; set; }
    }
}
