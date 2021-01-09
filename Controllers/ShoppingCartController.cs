using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCartMVCLab1.Models;
namespace ShopCartMVCLab1.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ShoppingCart ShoppingCart;
        public ShoppingCartController(ICourseRepository courseRepository, ShoppingCart cart)
        {
            this.courseRepository = courseRepository;
            this.ShoppingCart = cart;

        }
        public IActionResult Index()
        {
            ShoppingCart.ShoppingCartItems = ShoppingCart.GetShoppingCartItems();
            return View(ShoppingCart);
        }
        public RedirectToActionResult AddToShoppingCart(int courseId)
        {
            var selectedCourse = courseRepository.GetCourseById(courseId);
            ShoppingCart.AddItemToCart(selectedCourse, selectedCourse.Fee);
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int courseId)
        {
            var selectedCourse = courseRepository.GetCourseById(courseId);
            ShoppingCart.RemoveItemFromCart(selectedCourse);
            return RedirectToAction("Index");
        }
    }
}
