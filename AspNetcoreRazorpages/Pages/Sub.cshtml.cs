using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class SubModel : PageModel
    {
        [BindProperty]
        public Values _getdata { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            TempData["res"] = _getdata.x - _getdata.y;
        }   
    }
}
