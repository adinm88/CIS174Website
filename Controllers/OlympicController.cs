using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneWebApp.Models;

namespace PhoneWebApp.Controllers
{
    public class OlympicController : Controller
    {
        public IActionResult Index(string game, string category)
        {
            var model = OlympicRepository.GetCountries();

            if (!string.IsNullOrEmpty(game) && game != "ALL")
            {
                model = model.Where(x => x.Game == game).ToList();
            }
            if (!string.IsNullOrEmpty(game) && category != "ALL")
            {
                model = model.Where(x => x.Category == category).ToList();
            }
            return View(model);
        }
        public IActionResult Details(string id)
        {
            var country = OlympicRepository
                .GetCountries()
                .FirstOrDefault(x => x.Country == id);

            return View(country);
        }
    }
}
