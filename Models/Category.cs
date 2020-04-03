using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        //Her kategoriden birden fazla olabilir.Alttaki satır.
        public List<Blog> Bloglar { get; set; }

    }
}