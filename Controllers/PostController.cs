using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using Blog.ViewModels;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            using (var db = new BlogContext())
            {
                List<PostB> ListadoPost = db.Post.ToList<PostB>();
                return View(ListadoPost);
            }
        }
            
        [HttpGet] //Metodo para abrir pantalla de agregar
        public ActionResult AddEdit()
        {
            return View();
        }

        [HttpPost] //Metodo que guarda al editar y agregar nuevo
        public ActionResult AddEdit(PostB post)
        {
            using (var db = new BlogContext())
            {
                if (post.Id == 0)
                {      
                    db.Post.Add(post);
                    db.SaveChanges();
                }
                else
                {
                    PostB postBlog = db.Post.First(p => p.Id == post.Id);
                    postBlog.Title = post.Title;
                    postBlog.Content = post.Content;
                    //postBlog.Date = DateTime.Now.ToString("dd/MM/yyyy");
                }
            }
            return RedirectToAction("Index");
        }



        [HttpGet]//metodo abrir eliminar
        public ActionResult Delete(int idpost)
        {
            using (var db = new BlogContext())
            {
                PostB post = db.Post.First(p => p.Id == idpost);
                return View(post);
            }
        }

        [HttpPost]//metodo eliminar post
        public ActionResult Delete(PostB post)
        {
            using (var db = new BlogContext())
            {
                db.Post.Remove(post);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}