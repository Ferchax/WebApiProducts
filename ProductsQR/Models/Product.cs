﻿using System;
namespace ProductsQR.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }

        public Product()
        {
        }
    }
}