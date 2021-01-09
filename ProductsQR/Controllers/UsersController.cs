using System;
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
    public class UsersController : Controller
    {
        private UserRepository repo;

        public UsersController()
        {
            repo = new UserRepository();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = repo.GetUsers();
            return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var user = JsonSerializer.Serialize(repo.GetUserById(id));
            return user;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
