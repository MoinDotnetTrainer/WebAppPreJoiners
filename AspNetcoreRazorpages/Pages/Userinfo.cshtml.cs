using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class UserinfoModel : PageModel
    {
        [BindProperty]
        public Users _Users { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() {
            TempData["Uname"]= _Users.uname;
            TempData["email"] = _Users.email;
            TempData["dob"] = _Users.dob;
        }    
    }
}
