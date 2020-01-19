using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KafeinCaseStudyProject.Models.Manager
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new Constructor());
        }
    }

    public class Constructor : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //DB'de oluşturulan User ve Product tablolarına kayıt eklendi

            var users = new List<User>
            {
                new User{TCKN="11111111111",Name="Alexander",Surname="Test2",Email="test@test.com",Gsm="05554446633"},
                new User{TCKN="22222222222",Name="Alonso",Surname="Test3",Email="test@test.com",Gsm="05554446633"},
                new User{TCKN="33333333333",Name="Anand",Surname="Test4",Email="test@test.com",Gsm="05554446633"},
                new User{TCKN="44444444444",Name="Barzdukas",Surname="Test5",Email="test@test.com",Gsm="05554446633"},
                new User{TCKN="55555555555",Name="Li",Surname="deneme1",Email="test@test.com",Gsm="05554446633"},
                new User{TCKN="66666666666",Name="Justice",Surname="deneme2",Email="test@test.com",Gsm="05554446633"},
                new User{TCKN="77777777777",Name="Norman",Surname="deneme3",Email="test@test.com",Gsm="05554446633"},
                new User{TCKN="88888888888",Name="Olivetto",Surname="deneme4",Email="test@test.com",Gsm="05554446633"}
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Name="Urun1",Description="Test2",Price="300 TL"},
                new Product{Name="Urun2",Description="Test3",Price="1200 TL"},
                new Product{Name="ürün3",Description="Test4",Price="650 TL"},
                new Product{Name="ürün4",Description="Test5",Price="3500 TL"},
                new Product{Name="ürün5",Description="deneme1",Price="120 TL"},
                new Product{Name="ürün6",Description="Test4",Price="2000 TL"},
                new Product{Name="ürün7",Description="Test5",Price="980 TL"},
                new Product{Name="ürün8",Description="deneme1",Price="60 TL"},
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}