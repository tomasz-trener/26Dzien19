using Microsoft.AspNetCore.Mvc;

namespace P09ShopWebAppMVC.Client.Controllers
{
    //base_address/Calculator
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form) 
        {
            int number1 = int.Parse(form["number1"]);

            int number2 = int.Parse(form["number2"]);

            int result = number1 + number2;

            ViewBag.MyResult = result;
			ViewBag.Number1 = number1;
			ViewBag.Number2 = number2;

            //ViewBag - uzycie dynamicznej wlasciwosci (proste dane)
            //ViewData - uzycie slownika (proste dane)
            // preferencja programisty czego uzywamy 

            // przesylanie danych zlozonych - robimy inaczej 

			return View("Index");
        }
    }
}
