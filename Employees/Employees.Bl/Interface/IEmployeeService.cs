using Employees.Core;
using System.Collections.Generic;

namespace Employees.Bl.Interface
{
    public interface IEmployeeService
    {
        Employee CreateEmployee(Employee employee);
        IEnumerable<Employee> GetPartEmployeers(int? pageNumber = null, int? pageSize = null);
    }
}
