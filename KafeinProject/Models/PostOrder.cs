using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KafeinProject.Models
{
    // Bu class OrderApi POST methoduna UserId ve ProductId parametrelerini geçirmek amaçlı oluşturuldu
    public class PostOrder
    {
        public int UserId { get; set; }
        public List<int> ProductIds { get; set; }
    }
}