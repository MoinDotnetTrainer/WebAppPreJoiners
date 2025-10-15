using System.ComponentModel.DataAnnotations;

namespace AspNetcoreRazorpages.Models
{
    public class UsersData
    {
        [Key] // Userid is PK and Auto increment
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
