using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Me.Pages
{
    [ServiceFilter(typeof(SaveVisitorFilter))]
    public class ResumeModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
