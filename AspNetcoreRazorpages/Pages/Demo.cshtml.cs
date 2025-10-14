using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class DemoModel : PageModel
    {
        public void OnGet() // exe on Load of ur page
        {
            // if somethings which we want to load as soon as the pages gets loaded 
            TempData["date"] = System.DateTime.Now.ToString();
        }

        public void OnPost()
        {
        }   
    }
}
