using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class UserViewModel
    {
        
        public int Id {get; set;}
        public string Username {get; set;}
        private string? Email {get; set;}
        public string Password {get; set;}
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}