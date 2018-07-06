using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Blog.Models;

namespace Blog
{
    public class BlogContext : DbContext
    {
        public DbSet<PostB> Post { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}