using KafeinCaseStudyProject.Models;
using KafeinCaseStudyProject.Models.Manager;
using KafeinProject.Repository;
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

        // GET: api/UserApi
        public IEnumerable<User> Get()
        {
            return dbContext.Users.ToList();
        }

        // GET: api/UserApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserApi/5
        public void Delete(int id)
        {
        }
    }
}
