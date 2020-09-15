using System.Collections.Generic;

namespace Employees.Api.ViewModels
{
    public class EmployeeViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<EmployeePositionViewModel> EmployeePositions { get; set; }
    }
}