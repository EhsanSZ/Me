using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Me.Pages
{
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
