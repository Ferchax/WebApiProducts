using System;
namespace ProductsQR.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int FKIdUser { get; set; }
        public string FKIdProduct { get; set; }
        public int Quantity { get; set; }
    }
}
