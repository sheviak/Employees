using System;

namespace Employees.Core
{
    public class EmployeePositionInfo : BaseEntity
    {
        public double Cash { get; set; }
        public DateTime StartedWork { get; set; }
        public DateTime? EndedWork { get; set; }

        public EmployeePosition EmployeePosition { get; set; }
        public int EmployeePositionId { get; set; }
    }
}