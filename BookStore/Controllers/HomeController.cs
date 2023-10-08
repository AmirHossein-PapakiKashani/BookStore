using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private BookStoreContext context;
        public HomeController(BookStoreContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult About()
        {
            // Get the value of the "page" query parameter from the URL

            return View();
        }
    }
}