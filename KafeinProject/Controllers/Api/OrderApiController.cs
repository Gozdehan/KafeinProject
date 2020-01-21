using KafeinCaseStudyProject.Models;
using KafeinCaseStudyProject.Models.Manager;
using KafeinProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KafeinProject.Controllers.Api
{
    public class OrderApiController : ApiController
    {
        DatabaseContext dbContext = new DatabaseContext();

        // Tüm siparişleri listeleyen GET method
        // GET: api/OrderApi
        public IEnumerable<Order> Get()
        {
            return dbContext.Orders.ToList();
        }

        // Seçili siparişi listeleyen GET method
        // GET: api/OrderApi/5
        public IEnumerable<Order> Get(int id)
        {
          return dbContext.Orders.Where(i => i.Id == id).ToList();
        }

        // Hangi kullanıcının hangi ürünü aldığını Order tablosuna kaydeden POST method
        // POST: api/OrderApi
        public void Post(PostOrder postOrder)
        {
            DatabaseContext db = new DatabaseContext();
            Order order = new Order();
            try
            {             
               var orderList= db.Products.Where(c => postOrder.ProductIds.Contains(c.Id)).ToList();
               
                order.FUser = db.Users.FirstOrDefault(c => c.Id == postOrder.UserId);
                foreach(var productItem in orderList)
                {
                    order.FProduct = productItem;
                    db.Orders.Add(order);
                    db.SaveChanges();
                }               
               
            }
            catch (Exception e)
            {           
                throw e; 
            }
            finally
            {
                db.Dispose();
            }
        }

    }
}
