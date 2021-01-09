﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProductsQR.Models;
using ProductsQR.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsQR.Controllers
{
    [EnableCors("allowSpecificOrigins")]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private OrderRepository repo;

        public OrdersController()
        {
            repo = OrderRepository.Instance();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            var orders = repo.GetOrders();
            return orders;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var order = JsonSerializer.Serialize(repo.GetOrderById(id));
            return order;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            //var order = JsonSerializer.Deserialize<Order>(value);
            repo.AddOrUpdateOrder(order);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
