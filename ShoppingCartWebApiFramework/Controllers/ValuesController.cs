using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http; 
using System.Web.Cors;
using ShoppingCartWebApiFramework.Model;
using System.Web.Http.Cors;

namespace ShoppingCartWebApiFramework.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>()
        {
            new Product{ Id= 1, Name ="Wheat", Description="5kgs wheat description", Price=205},
            new Product{ Id= 2, Name ="Rice", Description="5kgs rice description", Price=254},
            new Product{ Id= 3, Name ="Jowar", Description="1kgs rice description", Price=25},
            new Product{ Id= 4, Name ="Bajra", Description="1kgs rice description", Price=45},
            new Product{ Id= 5, Name ="Sugar", Description="1kgs rice description", Price=45},
            new Product{ Id= 6, Name ="Oil", Description="5kgs rice description", Price=700},
            new Product{ Id= 7, Name ="Refined Groundnut Oil", Description="5kgs rice description", Price=500},
            new Product{ Id= 8, Name ="Toothpaste", Description="500gms Colgate zigzag", Price=254},
            new Product{ Id= 9, Name ="Brush", Description="Oral B brushes", Price=70},
            new Product{ Id= 10, Name ="Dress", Description="1 unit ", Price=2345},
        };

        // GET api/values
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
