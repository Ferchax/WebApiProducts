using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ProductsController : Controller
    {
        private ProductRepository repo;

        public ProductsController()
        {
            repo = new ProductRepository();
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get(int _page = 0, int _limit = 0)
        {
            var products = repo.GetProducts();

            if (_page != 0) {

                var limit = _limit != 0 ? _limit : 3;

                var totalProducts = products.Count;

                var firstPage = 1;
                var previousPage = _page > firstPage ? _page - 1 : 0;
                var lastPage = (int)Math.Ceiling(totalProducts / (double)limit);
                var nextPage = _page < lastPage ? _page + 1 : 0;

                var serverURL = "https://webapiproductsqr.azurewebsites.net/api/products";

                var limitParam = _limit != 0 ? $"&_limit={limit}" : string.Empty;

                var firstPageLink = $"<{serverURL}?_page=1{limitParam}>; rel=\"first\", ";
                var previousPageLink = previousPage != 0 ? $"<{serverURL}?_page={previousPage}{limitParam}>; rel=\"prev\", " : string.Empty;
                var nextPageLink = nextPage != 0 ? $"<{serverURL}?_page={nextPage}{limitParam}>; rel=\"next\", " : string.Empty;
                var lastPageLink = $"<{serverURL}?_page={lastPage}{limitParam}>; rel=\"last\"";

                Response.Headers.Add("Link", $"{firstPageLink}{previousPageLink}{nextPageLink}{lastPageLink}");

                var index = (_page - 1) * limit;

                var maxLimit = (limit * _page);

                limit = maxLimit > totalProducts ? limit - (maxLimit - totalProducts) : limit;

                products = products.GetRange(index, limit);
            }
            
            var result = new ObjectResult(products);            

            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
