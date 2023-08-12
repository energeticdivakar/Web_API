using System.ComponentModel.DataAnnotations;

namespace MVC_API.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string MobileNum { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
    }
}
