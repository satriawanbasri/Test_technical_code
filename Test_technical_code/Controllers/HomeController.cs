using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;
using Test_technical_code.Models;

namespace Test_technical_code.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult Segitiga(int inputAngka)
        {
            return Json("test");
        }

        public JsonResult Ganjil(int inputAngka)
        {
            var listGanjil = new List<int>();
            var ganjil = 0;
            listGanjil.Add(ganjil);
            var i = 1;
            while (ganjil <= inputAngka)
            {
                ganjil = 2 * i - 1;
                if (ganjil <= inputAngka)
                    listGanjil.Add(ganjil);
                i++;
            }
            return Json(listGanjil);
        }

        public JsonResult Prima(int inputAngka)
        {
            var listPrima = new List<int>();
            bool prima = true;
            int bilangan = inputAngka;
            if (bilangan >= 2)
            {
                for (int i = 2; i <= bilangan; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }
                    if (prima)
                        listPrima.Add(i);
                    prima = true;
                }
            }
            return Json(listPrima);
        }

    }
}