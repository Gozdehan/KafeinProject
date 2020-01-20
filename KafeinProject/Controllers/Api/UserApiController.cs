﻿using KafeinCaseStudyProject.Models;
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

        // GET: api/UserApi
        public IEnumerable<User> Get()
        {
            return dbContext.Users.ToList();
        }

        // GET: api/UserApi/5
        public IEnumerable<User> Get(int id)
        {
            return dbContext.Users.Where(i => i.Id == id).ToList();
        }
    }
}
