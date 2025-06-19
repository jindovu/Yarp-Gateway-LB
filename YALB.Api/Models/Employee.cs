namespace YALB.Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public required int DepartmentId { get; set; }
    }
}
