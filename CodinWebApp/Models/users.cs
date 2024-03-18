using System.ComponentModel.DataAnnotations;

namespace CodinWebApp.Models
{
    public class users
    {
        [Key]
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
