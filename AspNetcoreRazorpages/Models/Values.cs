using Microsoft.AspNetCore.Mvc;

namespace AspNetcoreRazorpages.Models
{
    public class Values
    {
        [BindProperty]
        public int x { get; set; }

        [BindProperty]
        public int y { get; set; }
    }
}
