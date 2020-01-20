using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KafeinCaseStudyProject.Models
{
    //Kullanıcıya eklenen ürünlerin bilgisinin tutulduğu tablo
    [Table("Orders")]
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //Product ve User tabloları ile ForeignKey bağlantıları kuruldu
        public virtual Product FProduct { get; set; }
        public virtual User FUser { get; set; }


    }
}