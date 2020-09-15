using System.Collections.Generic;

namespace Employees.Core
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<EmployeePosition> EmployeePosition { get; set; }
    }
}