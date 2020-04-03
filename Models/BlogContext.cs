using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogContext : DbContext
    {
        //Initiliazer metodu devreye girmesi için. Tanıtmak için.
        //Seed metodu modelde değişiklik yapıldığında devreye girer.
        public BlogContext() : base("blogDb") // Veritabanı ismi (web configdeki name'in adresini alacak)
        {
            Database.SetInitializer(new BlogInitializer());
        }
        //Models klasöründeki sınıfları tablolar olarak tanımlamak gerekiyor.
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}