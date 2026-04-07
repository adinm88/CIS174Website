using Microsoft.AspNetCore.Mvc;

namespace CIS174Website.Models
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using PhoneWebApp.Models;

    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            var model = OlympicRepository.GetCountries();
            var favorites = HttpContext.Session.GetString("favorites");
            ViewBag.Favorites = favorites;
            return View(model);
        }

        public IActionResult Add(string id)
        {
            var favorites = HttpContext.Session.GetString("favorites");

            if (favorites == null)
            {
                favorites = id;
            }
            else
            {
                if (!(favorites.Contains(id)))
                {
                    favorites += "," + id;
                }
            }

            HttpContext.Session.SetString("favorites", favorites);

            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove("favorites");
            return RedirectToAction("Index");
        }
    }
}
