using Microsoft.AspNetCore.Mvc;

namespace AspNetcoreRazorpages.Models
{
    public class Users
    {
        [BindProperty]
        public string uname { get; set; }

        [BindProperty]
        public string email { get; set; }

        [BindProperty]
        public DateTime dob { get; set; }
    }
}
