using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class HrsSecondsModel : PageModel
    {
        public void OnGet()  // on load
        {
        }

        public void OnPost() // on click
        {
            int getHrs = Convert.ToInt32(Request.Form["hrs"].ToString());
            TempData["res"] = getHrs * 3600;
        }
    }
}
