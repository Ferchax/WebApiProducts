using System;
using System.Collections.Generic;
using System.Linq;
using ProductsQR.Models;

namespace ProductsQR.Repositories
{
    public class OrderRepository
    {
        private static OrderRepository _instance;

        public static OrderRepository Instance()
        {
            if (_instance == null)
            {
                _instance = new OrderRepository();
            }

            return _instance;
        }

        List<Order> orders;

        private int id;

        protected OrderRepository()
        {
            id = 1;

            orders = new List<Order>
            {
                new Order
                {
                    Id = id++,
                    FKIdProduct = "5fa5367b-5a0f-4266-9b37-0aa657baf2a0",
                    FKIdUser =  1,
                    Quantity = 100
                }
            };
        }

        public bool AddOrUpdateOrder(Order _order)
        {
            var order = GetOrder(_order.FKIdProduct, _order.FKIdUser);

            if(order != null)
            {
                _order.Id = order.Id;
                UpdateOrder(_order);
            }
            else
            {
                var repoProduct = new ProductRepository();
                var product = repoProduct.GetProduct(_order.FKIdProduct);
                var repoUser = new UserRepository();
                var user = repoUser.GetUserById(_order.FKIdUser);

                if(user != null && product != null)
                {
                    AddOrder(_order);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool AddOrder(Order order)
        {
            order.Id = id++;
            orders.Add(order);
            return true;
        }

        public bool UpdateOrder(Order order)
        {
            if (order.Id != 0)
            {
                var index = orders.FindIndex(x => x.Id == order.Id);
                orders[index].Quantity = order.Quantity;
                return true;
            }

            return false;
        }

        public IEnumerable<Order> GetOrders()
        {
            return orders;
        }

        public IEnumerable<Order> GetOrdersByUser(int iduser)
        {
            var orders = this.orders.Where(x => x.FKIdUser == iduser);
            return orders;
        }

        public Order GetOrderById(int id)
        {
            var order = orders.Where(x => x.Id == id).FirstOrDefault();
            return order;
        }

        public Order GetOrder(string idproduct, int iduser)
        {
            var order = orders.Where(x => x.FKIdProduct == idproduct &&
                                        x.FKIdUser == iduser).FirstOrDefault();
            return order;
        }
    }
}
