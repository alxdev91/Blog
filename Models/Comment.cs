using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int IdPost { get; set; }
        public string TextComment { get; set; }
        public string NameVisitor { get; set; }
    }
}