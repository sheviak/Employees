using System.Collections.Generic;

namespace Employees.Core
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<EmployeePosition> EmployeePosition { get; set; }
    }
}