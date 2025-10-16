using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class UsersListModel : PageModel
    {
        public AppDatabase _db;
        public UsersListModel()
        {
            _db = new AppDatabase();
        }

        public IList<UsersData> usersDatas { get; set; }
        public void OnGet()
        {
            // var res = from s in obj select s;
            //ef core also linq syntax

            usersDatas = (from s in _db.UsersData select s).ToList();

        }
    }
}
