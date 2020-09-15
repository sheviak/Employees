using System;

namespace Employees.Api.ViewModels
{
    public class EmployeePositionViewModel
    {
        public string PositionName { get; set; }
        public double Cash { get; set; }
        public DateTime StartedWork { get; set; }
        public DateTime? EndedWork { get; set; }
    }
}