using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice_MVCaspnet.Models;

namespace Practice_MVCaspnet.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Lucy" };
            return View(movie);
            //return new ViewResult();
        }
        public ActionResult Edit(int id)
        {
            return Content("id =" + id);
        }
    }
}