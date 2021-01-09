using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using ProductsQR.Models;

namespace ProductsQR.Repositories
{
    public class ProductRepository
    {
        readonly IEnumerable<Product> products;

        private string serverUrl;

        public ProductRepository()
        {
            serverUrl = "https://webapiproductsqr.azurewebsites.net";
            //serverUrl = "https://localhost:5001";

            products = new List<Product>
            {
                new Product
                {
                    Id = "5fa5367b-5a0f-4266-9b37-0aa657baf2a0",
                    Category = "Cola",
                    Name = "MANAOS COLA",
                    Description = "Sabor Manaos Cola 1,25LTS",
                    Price = 61.00m,
                    Quantity = 99899,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-1,25LTS.jpg"
                },
                new Product
                {
                    Id = "6456d4fb-3f70-4ca8-ae78-646cd5000f5d",
                    Category = "Cola",
                    Name = "MANAOS COLA",
                    Description = "Sabor Manaos Cola 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "e8613a5b-62c6-4bca-8877-3434b59a6fc4",
                    Category = "Cola",
                    Name = "MANAOS COLA",
                    Description = "Sabor Manaos Cola 3LTS",
                    Price = 95.45m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-3LTS.jpg"
                },
                new Product
                {
                    Id = "8a1b847e-df2b-483b-80dd-7e08c8466c4c",
                    Category = "Cola",
                    Name = "MANAOS COLA",
                    Description = "Sabor Manaos Cola 600CC",
                    Price = 39.15m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/productos/cola/MANAOS-COLA-600CC.jpg"
                },
                new Product
                {
                    Id = "2e639103-3cf7-4664-9814-f5068e9145bc",
                    Category = "Cola Sin Azúcar",
                    Name = "MANAOS COLA SIN AZUCAR",
                    Description = "Sabor Manaos Cola Sin Azúcar 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/cola-sin-azucar/MANAOS-COLA-SIN-AZÚCAR-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "1c4212e3-ac19-4277-86d3-18df773abb10",
                    Category = "Guarana",
                    Name = "MANAOS GUARANA",
                    Description = "Sabor Manaos Guaraná 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/guarana/MANAOS-GUARANÁ-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "8a7c2a2d-1405-43f9-8c21-6da735102c1e",
                    Category = "Guarana",
                    Name = "MANAOS GUARANA",
                    Description = "Sabor Manaos Guaraná 3LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/guarana/MANAOS-GUARANÁ-3LTS.jpg"
                },
                new Product
                {
                    Id = "587f197e-5118-4a8f-bd72-324a323d3e58",
                    Category = "Lima Limon",
                    Name = "MANAOS LIMA LIMON",
                    Description = "Sabor Manaos Lima Limón 1,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/lima-limon/MANAOS-LIMA-LIMÓN-1,25LTS.jpg"
                },
                new Product
                {
                    Id = "fbcd3f6c-64c7-436d-bad4-02ed1d36a59c",
                    Category = "Lima Limon",
                    Name = "MANAOS LIMA LIMON",
                    Description = "Sabor Manaos Lima Limón 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/lima-limon/MANAOS-LIMA-LIMÓN-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "b6e7b0fc-58f5-4eee-b2c5-75f40bcc3aa9",
                    Category = "Lima Limon",
                    Name = "MANAOS LIMA LIMON",
                    Description = "Sabor Manaos Lima Limón 3LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/lima-limon/MANAOS-LIMA-LIMÓN-3LTS.jpg"
                },
                new Product
                {
                    Id = "4ce9cbaa-91d8-4194-bf7d-452b4066e875",
                    Category = "Lima Limon",
                    Name = "MANAOS LIMA LIMON",
                    Description = "Sabor Manaos Lima Limón 600CC",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/lima-limon/MANAOS-LIMA-LIMÓN-600CC.jpg"
                },
                new Product
                {
                    Id = "6a742869-a686-4337-9013-b7e5ee57c5c5",
                    Category = "Limon",
                    Name = "MANAOS LIMON",
                    Description = "Sabor Manaos Limón 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/limon/MANAOS-LIMÓN-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "2a5a6b2b-57a3-4607-b82b-8cb70c55092a",
                    Category = "Limon",
                    Name = "MANAOS LIMON",
                    Description = "Sabor Manaos Limón 3LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/limon/MANAOS-LIMÓN-3LTS.jpg"
                },
                new Product
                {
                    Id = "55d564d1-ccc4-45d8-889b-36176bbb98ae",
                    Category = "Manzana",
                    Name = "MANAOS MANZANA",
                    Description = "Sabor Manaos Manzana 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/manzana/MANAOS-MANZANA-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "886c2fcd-f15a-47a2-bc7e-e1b2dfcc53b1",
                    Category = "Manzana",
                    Name = "MANAOS MANZANA",
                    Description = "Sabor Manaos Manzana 3LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/manzana/MANAOS-MANZANA-3LTS.jpg"
                },
                new Product
                {
                    Id = "27009da8-449e-48f3-a163-355dbbe33b73",
                    Category = "Naranja",
                    Name = "MANAOS NARANJA",
                    Description = "Sabor Manaos Naranja 1,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/naranja/MANAOS-NARANJA-1,25LTS.jpg"
                },
                new Product
                {
                    Id = "cd24f901-e408-4934-a358-e7c49fc1c39d",
                    Category = "Naranja",
                    Name = "MANAOS NARANJA",
                    Description = "Sabor Manaos Naranja 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/naranja/MANAOS-NARANJA-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "eeae4e4a-0b73-4dba-af0a-f477939f2b3b",
                    Category = "Naranja",
                    Name = "MANAOS NARANJA",
                    Description = "Sabor Manaos Naranja 3LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/naranja/MANAOS-NARANJA-3LTS.jpg"
                },
                new Product
                {
                    Id = "d994cda9-c02b-4fa6-8ec9-2d5fd4981007",
                    Category = "Naranja",
                    Name = "MANAOS NARANJA",
                    Description = "Sabor Manaos Naranja 600CC",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/naranja/MANAOS-NARANJA-600CC.jpg"
                },
                new Product
                {
                    Id = "fd133aed-0b8f-4c75-a5e7-7c16b2bc7982",
                    Category = "Pomelo Amarillo",
                    Name = "MANAOS POMELO AMARILLO",
                    Description = "Sabor Manaos Pomelo Amarillo 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/pomelo-amarillo/MANAOS-POMELO-AMARILLO-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "cc2ed4d6-9159-4ed9-8540-87fc186a1232",
                    Category = "Pomelo Blanco",
                    Name = "MANAOS POMELO BLANCO",
                    Description = "Sabor Manaos Pomelo Blanco 1,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/pomelo-blanco/MANAOS-POMELO-BLANCO-1,25LTS.jpg"
                },
                new Product
                {
                    Id = "f636f9e5-226a-47c0-b276-d126178ae315",
                    Category = "Pomelo Blanco",
                    Name = "MANAOS POMELO BLANCO",
                    Description = "Sabor Manaos Pomelo Blanco 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/pomelo-blanco/MANAOS-POMELO-BLANCO-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "a7009cc6-6101-41e1-99c0-8eeeed31b297",
                    Category = "Pomelo Blanco",
                    Name = "MANAOS POMELO BLANCO",
                    Description = "Sabor Manaos Pomelo Blanco 3LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/pomelo-blanco/MANAOS-POMELO-BLANCO-3LTS.jpg"
                },
                new Product
                {
                    Id = "101f718f-964f-4eb1-80b3-047dcbb02ed8",
                    Category = "Pomelo Blanco",
                    Name = "MANAOS POMELO BLANCO",
                    Description = "Sabor Manaos Pomelo Blanco 600CC",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/pomelo-blanco/MANAOS-POMELO-BLANCO-600CC.jpg"
                },
                new Product
                {
                    Id = "9d1a58df-0957-4cc7-bf3f-0e632db6ec90",
                    Category = "Pomelo Rosado",
                    Name = "MANAOS POMELO ROSADO",
                    Description = "Sabor Manaos Pomelo Rosado 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/pomelo-rosado/MANAOS-POMELO-ROSADO-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "c0fa445e-33b1-4097-aed3-facacec9bcd9",
                    Category = "Uva",
                    Name = "MANAOS UVA",
                    Description = "Sabor Manaos Uva 1,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/uva/MANAOS-UVA-1,25LTS.jpg"
                },
                new Product
                {
                    Id = "2bf3e5a3-6da5-4c4b-bc8c-6859fd08586c",
                    Category = "Uva",
                    Name = "MANAOS UVA",
                    Description = "Sabor Manaos Uva 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/uva/MANAOS-UVA-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "9428a078-66e3-4b63-adbd-8e0a3aa11902",
                    Category = "Uva",
                    Name = "MANAOS UVA",
                    Description = "Sabor Manaos Uva 600CC",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/uva/MANAOS-UVA-600CC.jpg"
                },
                new Product
                {
                    Id = "d9754716-d08c-4510-ae8c-26fb826e07d8",
                    Category = "Soda",
                    Name = "MANAOS SODA",
                    Description = "Sabor Manaos Soda 2LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/soda/MANAOS-SODA-2LTS.jpg"
                },
                new Product
                {
                    Id = "e3bea647-6ee4-47d5-9794-bf6de6cb0b08",
                    Category = "Citrus",
                    Name = "MANAOS CITRUS",
                    Description = "Sabor Manaos Citrus 2LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/citrus/MANAOS-CITRUS-2,25LTS.jpg"
                },
                new Product
                {
                    Id = "000d6c47-69c6-4b5f-8109-018f7791a928",
                    Category = "Citrus",
                    Name = "MANAOS CITRUS",
                    Description = "Sabor Manaos Citrus 3LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/citrus/MANAOS-CITRUS-3LTS.jpg"
                },
                new Product
                {
                    Id = "85351fe0-bb6b-4da7-be52-770f89bd1302",
                    Category = "Naranja Durazno",
                    Name = "MANAOS NARANJA DURAZNO",
                    Description = "Sabor Manaos Naranja Durazno 2,25LTS",
                    Price = 83.00m,
                    Quantity = 99999,
                    ImageUrl = $"{serverUrl}/images/Productos/naranja-durazno/MANAOS-NARANJA-DURAZNO-2,25LTS.jpg"
                }
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(string id)
        {
            var product = products.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }
    }
}
