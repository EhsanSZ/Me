using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Me.Pages
{
    public class PortfolioModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnGetShop1()
        {
            return Partial("Shop1");
        }

        public IActionResult OnGetSQL()
        {
            return Partial("SQL");
        }

    }
}
