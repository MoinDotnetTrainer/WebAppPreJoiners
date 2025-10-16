using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class CreateUserModel : PageModel
    {

        public AppDatabase _db;
        public CreateUserModel()
        {
            _db = new AppDatabase();
        }
        [BindProperty]
        public UsersData _values { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            //get data here from UI , _values 
            if (_values != null)
            {
                _db.UsersData.Add(_values);
                _db.SaveChanges();
                return RedirectToPage("UsersList");

            }
            else
            {
                return Page();
            }
        }
    }
}
