using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class PostB
    {
  
        public int Id { get; set; }

        [Required(ErrorMessage = "El Titulo es obligatorio")]
        public string Title { get; set; }

        [Required(ErrorMessage = "El contenido es obligatorio")]
        public string Content { get; set; }


        public List<Comment> Comments { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria")]
        public string Category { get; set; }

        public DateTime Date { get; set; }  
    }
}