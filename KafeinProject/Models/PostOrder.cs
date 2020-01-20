using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KafeinProject.Models
{
    public class PostOrder
    {
        public int UserId { get; set; }
        public List<int> ProductIds { get; set; }
    }
}