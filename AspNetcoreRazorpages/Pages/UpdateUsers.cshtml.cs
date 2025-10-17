using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class UpdateUsersModel : PageModel
    {
        public AppDatabase _db;
        public UpdateUsersModel()
        {
            _db = new AppDatabase();
        }

        [BindProperty]
        public UsersData _Useradata { get; set; }
        public void OnGet(int UserID)
        {
            // write  , which will get the data from databse based on Userid 

            _Useradata = (from s in _db.UsersData select s).FirstOrDefault(x => x.UserID == UserID);
        }

        public IActionResult OnPost()
        {
            if (_Useradata != null)
            {
                _db.Attach(_Useradata).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
