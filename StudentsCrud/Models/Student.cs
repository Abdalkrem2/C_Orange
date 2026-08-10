using System.ComponentModel.DataAnnotations;

namespace StudentsCrud.Models
{
    public class Student
    {
        public int Id { set; get; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { set; get; }

        [Range(1, 120, ErrorMessage = "Age must be greater than 0")]
        public int Age { set; get; }

    }
}
