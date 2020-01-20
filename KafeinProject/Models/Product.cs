using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KafeinCaseStudyProject.Models
{
    //Ürün bilgilerinin tutulduğu tablonun model'i
    [Table("Products")]
    public class Product
    {
     
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(250), Required]
        public string Name { get; set; }

        [StringLength(750)]
        public string Description { get; set; }

        [StringLength(50), Required]
        public string Price { get; set; }

    }
}