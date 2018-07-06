using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models;


namespace Blog.ViewModels
{
    public class PostViewModel
    {
        public PostB Post { get; set; }
        public List<Category> Categories { get; set; }

    }

    //public PostViewModel()
    //{
    //    //inicializa la lista de categorias
    //    this.Categories = Db.Courses;
    //}
}