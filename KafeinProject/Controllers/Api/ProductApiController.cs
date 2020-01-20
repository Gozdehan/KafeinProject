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
        public IEnumerable<Product> Get(int id)
        {
            return dbContext.Products.Where(i => i.Id == id).ToList();
        }
    }
}
