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

        // Tüm ürün bilgilerinin listelendiği GET method
        // GET: api/ProductApi
        public IEnumerable<Product> Get()
        {
            try
            {
                return dbContext.Products.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbContext.Dispose();
            }
        }

        // Seçili ürün bilgilerinin listelendiği GET method
        // GET: api/ProductApi/5
        public IEnumerable<Product> Get(int id)
        {
            try
            {
                return dbContext.Products.Where(i => i.Id == id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbContext.Dispose();
            }         
        }
    }
}
