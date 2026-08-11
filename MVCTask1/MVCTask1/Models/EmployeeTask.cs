namespace MVCTask1.Models
{
    public class EmployeeTask
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public ImportanceLevel Importance { get; set; }

        public int EmployeeId { get; set; }

        // Navigation Property
        public Employee Employee { get; set; }
    }
}
