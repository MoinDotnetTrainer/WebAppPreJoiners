using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class MulModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(Values obj)
        {
           TempData["res"] = obj.x * obj.y;
        }
    }
}
