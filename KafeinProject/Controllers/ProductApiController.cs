using KafeinCaseStudyProject.Models;
using KafeinCaseStudyProject.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KafeinProject.Controllers
{
    public class ProductApiController : ApiController
    {
        DatabaseContext dbContext = new DatabaseContext();

        // GET: api/ProductApi
        public IEnumerable<Product> Get()
        {
            return dbContext.Products.ToList();
        }

        // GET: api/ProductApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductApi/5
        public void Delete(int id)
        {
        }
    }
}
