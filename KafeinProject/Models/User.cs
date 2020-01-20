using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KafeinCaseStudyProject.Models
{
    //Kullanıcı bilgilerinin tutulduğu tablonun model'i
    [Table("Users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(11), Required]
        public string TCKN { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(11), Required]
        public string Gsm { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

    }
}