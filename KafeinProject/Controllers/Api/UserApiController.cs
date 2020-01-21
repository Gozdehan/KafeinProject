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
    public class UserApiController : ApiController
    {
        DatabaseContext dbContext = new DatabaseContext();

        // Kullanıcı bilgilerini listeleyen GET method
        // GET: api/UserApi
        public IEnumerable<User> Get()
        {
            try
            {
                return dbContext.Users.ToList();
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

        // Seçili kullanıcı bilgilerini listeleyen GET method
        // GET: api/UserApi/5
        public IEnumerable<User> Get(int id)
        {
            try
            {
                return dbContext.Users.Where(i => i.Id == id).ToList();
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
    }
}
