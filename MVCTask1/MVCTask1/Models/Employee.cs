using Microsoft.AspNetCore.Identity;
namespace MVCTask1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string NationalId { get; set; }

        public string Nationality { get; set; }

        public string MaritalStatus { get; set; }

        public string? Photo { get; set; }

        public DateTime EntryDate { get; set; }

        public Department Department { get; set; }

        public int DepartmentId {  get; set; }      
        public ICollection<EmployeeTask> Tasks { get; set; }

        public string UserId { get; set; }

        public IdentityUser User { get; set; }

    }
}
