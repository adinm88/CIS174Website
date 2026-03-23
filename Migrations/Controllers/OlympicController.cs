using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneWebApp.Models;

namespace PhoneWebApp.Controllers
{
    public class OlympicController : Controller
    {
        public IActionResult Index(OlympicFilterViewModel model)
        {
            var countries = OlympicRepository.GetCountries();

            if (!string.IsNullOrEmpty(model.Game) && model.Game != "ALL")
            {
                countries = countries.Where(x => x.Game == model.Game).ToList();
            }
            if (!string.IsNullOrEmpty(model.Category) && model.Category != "ALL")
            {
                countries = countries.Where(x => x.Category == model.Category).ToList();
            }
            model.Countries = countries;
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
