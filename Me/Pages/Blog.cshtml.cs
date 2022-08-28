using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Me.Pages
{
    [ServiceFilter(typeof(SaveVisitorFilter))]
    public class BlogModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnGetSinglePost()
        {
            return Partial("SinglePost");
        }
    }
}
