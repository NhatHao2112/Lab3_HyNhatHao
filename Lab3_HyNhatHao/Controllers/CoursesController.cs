using Lab3_HyNhatHao.Models;
using Lab3_HyNhatHao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_HyNhatHao.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}