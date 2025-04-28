using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;

namespace MinhaDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id, Guid categoria)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //return Json("{'nome': 'Eduardo'}");

            //var fileBytes = System.IO.File.ReadAllBytes(@"F:\arquivo.txt");
            //var fileName = "arquivo.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            return Content("Qualquer coisa");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
