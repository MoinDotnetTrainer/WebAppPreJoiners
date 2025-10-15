using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace AspNetcoreRazorpages.Models
{
    public class Books
    {
        [Key] // auto increment primary key
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
