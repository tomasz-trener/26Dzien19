using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P08ShopWebApp.Client.Pages
{
    public class CalculatorBindingModel : PageModel
    {

        [BindProperty]
        public int Number1 { get; set; }
		
        [BindProperty] // ten atrybut musimy podac gdy odczytujemy z widoku dane do modelu 
		public int Number2 { get; set; }

		[TempData] // przechowuje dane tylko dla jednego ¿adania po przekierowaniu 
        // uzywa mechamiznu cachu oparte o sesje 
        public int AddictionResult { get; set; }

        [TempData]
        public int SubstractionResult { get; set; }

		public void OnGet()
        {
        }

        public void OnPostAdd()
        {
			AddictionResult = Number1 + Number2;

		}

		public void OnPostSubstract()
		{
			SubstractionResult = Number1 - Number2;

		}
	}
}
