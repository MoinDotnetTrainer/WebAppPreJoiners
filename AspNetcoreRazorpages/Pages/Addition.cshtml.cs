using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class AdditionModel : PageModel
    {
        public void OnGet()
        {
            int x = 35, y = 45, z;
            z = x + y;
            TempData["z"] = z;
            TempData["sub"] = x - y;
            TempData["mul"] = x * y;
            TempData["div"] = x / y;
        }
    }
}
