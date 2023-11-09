using Microsoft.AspNetCore.Mvc;
using SQLite.Data;
using SQLite.Models;

namespace SQLite.Controllers
{
    public class CharactersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CharactersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var characters = _context.RpgCharacters;
            return View(characters);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RpgCharacter model)
        {
            if (ModelState.IsValid)
            {
                _context.RpgCharacters.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
