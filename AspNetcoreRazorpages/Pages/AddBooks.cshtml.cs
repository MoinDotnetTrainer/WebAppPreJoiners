using AspNetcoreRazorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetcoreRazorpages.Pages
{
    public class AddBooksModel : PageModel
    {
        public AppDatabase _db;
        public AddBooksModel()
        {
            _db = new AppDatabase();
        }

        [BindProperty]
        public Books _books { get; set; }  // to bind the data to Model class prop
        public void OnGet()
        {
        }
        public void OnPost()
        {
            //get data here from UI , _values 
            if (_books != null)
            {
                _db.Books.Add(_books);
                _db.SaveChanges();// commit the changes to DB
            }

            // _books --> Data
            // Add  is a method to insert records
            // Books --> Dbset Table
            // _ db --> instance of DB
        }
    }
}
