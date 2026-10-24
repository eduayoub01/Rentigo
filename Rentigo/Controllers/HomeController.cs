
using Microsoft.AspNetCore.Mvc;
using Rentigo.Models;
using Rentigo.Repositories;
using System.Diagnostics;

namespace Rentigo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVoitureRepository _voitureRepository;

        public HomeController(IVoitureRepository voitureRepository)
        {
            _voitureRepository = voitureRepository;
        }

        public IActionResult Index()
        {
            var voitures = _voitureRepository.GetAll();
            return View(voitures);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(
            Duration = 0,
            Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id
                    ?? HttpContext.TraceIdentifier
            });
        }
    }
}
