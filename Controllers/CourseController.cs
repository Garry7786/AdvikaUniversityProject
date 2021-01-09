using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopCartMVCLab1.Models;
using ShopCartMVCLab1.ViewModels;

namespace ShopCartMVCLab1.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ICategoryRepository categoryRepository;
        public CourseController(ICourseRepository courseRepository, ICategoryRepository categoryRepository)
        {
            this.courseRepository = courseRepository;
            this.categoryRepository = categoryRepository;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult List()
        {
            //ViewBag.SelectedCategory = categoryRepository.AllCategories.ToList()[2].Name;
            //return View(courseRepository.AllCourses);
            CourseListVM courseListVM = new CourseListVM()
            {
                Courses = courseRepository.AllCourses,
                SelectedCategoryName = categoryRepository.AllCategories.ToList()[1].Name
            };
            return View(courseListVM);
        }
    }
}
