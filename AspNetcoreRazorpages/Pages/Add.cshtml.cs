using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class AddModel : PageModel
    {
        //50 prop
        // bindproperty helps us to bind the values from the form to the properties directly
        [BindProperty]
        public int x { get; set; }
        [BindProperty]
        public int y { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            TempData["res"] = x + y;
        }
    }
}
