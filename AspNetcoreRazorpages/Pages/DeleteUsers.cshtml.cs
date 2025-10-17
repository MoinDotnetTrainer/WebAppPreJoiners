using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class DeleteUsersModel : PageModel
    {
        public AppDatabase _db;
        public DeleteUsersModel()
        {
            _db = new AppDatabase();
        }

        [BindProperty]
        public UsersData _userdata { get; set; }
        public void OnGet(int UserID)
        {
            _userdata = (from s in _db.UsersData select s).FirstOrDefault(x => x.UserID == UserID);
        }

        public IActionResult OnPost(int UserID)
        {
            var res = _db.UsersData.Find(UserID);  // finding the existing reord from table
            if (res != null)
            {
                _db.UsersData.Remove(res);
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
