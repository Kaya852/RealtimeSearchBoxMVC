using System.Diagnostics;
using InteractiveTextBox.Models;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveTextBox.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
