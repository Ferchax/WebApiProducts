using System;
using System.Collections.Generic;
using System.Text.Json;
using ProductsQR.Models;

namespace ProductsQR.Repositories
{
    public class ProductRepository
    {
        readonly List<Product> products;

        private string serverUrl;

        public ProductRepository()
        {
            serverUrl = "https://localhost:5001";

            products = new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Category = "Cola",
                    Name = "COLA",
                    Description = "Sabor Manaos Cola 1,25LTS",
                    Price = 61.00m,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-1,25LTS.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Category = "Cola",
                    Name = "COLA",
                    Description = "Sabor Manaos Cola 2,25LTS",
                    Price = 83.00m,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-2,25LTS.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Category = "Cola",
                    Name = "COLA",
                    Description = "Sabor Manaos Cola 3LTS",
                    Price = 95.45m,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-3LTS.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Category = "Cola",
                    Name = "COLA",
                    Description = "Sabor Manaos Cola 600LTS",
                    Price = 39.15m,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-600CC.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Category = "Cola Sin Azúcar",
                    Name = "COLA",
                    Description = "Sabor Manaos Cola Sin Azúcar 2,25LTS",
                    Price = 83.00m,
                    ImageUrl = $"{serverUrl}/images/Productos/cola-sin-azucar/MANAOS-COLA-SIN-AZÚCAR-2,25LTS.jpg"
                }
            };
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
