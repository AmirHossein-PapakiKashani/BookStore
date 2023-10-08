using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private BookStoreContext context;

        public CategoryController(BookStoreContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            IQueryable<Category> query = context.Categories.OrderBy(e => e.Name);

            var queryList = query.ToList();

            return View(queryList);
        }
    }
}
