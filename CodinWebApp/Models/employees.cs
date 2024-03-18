using System.ComponentModel.DataAnnotations;

namespace CodinWebApp.Models
{
    public class employees
    {
        [Key]
        public int employee_id { get; set; }
        public string? employee_name { get; set; }
        public string? designation { get; set; }
        public DateOnly? doj { get; set; }
        public DateOnly? dol { get; set; }
        public string? email { get; set; }
    }
}
