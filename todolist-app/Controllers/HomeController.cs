using Microsoft.AspNetCore.Mvc;
using todolist_app.Models;
using Microsoft.EntityFrameworkCore;

namespace todolist_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoItemDBContext _context;
        public HomeController(TodoItemDBContext context)
        {
            _context = context;
        }

        //
        public async Task<IActionResult> Index()
        {
            return View(await _context.TodoItems.ToListAsync());
        }
    }
}