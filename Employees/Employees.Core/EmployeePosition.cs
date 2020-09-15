namespace Employees.Core
{
    public class EmployeePosition : BaseEntity
    {
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Position Position { get; set; }
        public int PositionId { get; set; }

        public EmployeePositionInfo EmployeePositionInfo { get; set; }
    }
}