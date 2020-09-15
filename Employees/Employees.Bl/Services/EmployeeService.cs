using Employees.Bl.Interface;
using Employees.Core;
using Employees.Dal.Interface;
using System.Linq;
using System.Collections.Generic;

namespace Employees.Bl.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Employee CreateEmployee(Employee employee)
        {
            this.unitOfWork.Repository<Employee>().Insert(employee);
            this.unitOfWork.Save();

            var t = this.unitOfWork
                .Repository<Employee>()
                .Get(
                    filter: x => x.Id == employee.Id,
                    orderBy: null,
                    pageNumber: null,
                    pageSize: null,
                    "EmployeePosition.Position",
                    "EmployeePosition.EmployeePositionInfo")
                .FirstOrDefault();

            return t;    
        }

        public IEnumerable<Employee> GetPartEmployeers(int? pageNumber = null, int? pageSize = null)
        {
            var employees = this.unitOfWork
                .Repository<Employee>()
                .Get(
                    filter: null,
                    orderBy: x => x.OrderBy(o => o.FirstName).ThenBy(t => t.LastName),
                    pageNumber: pageNumber,
                    pageSize: pageSize,
                    "EmployeePosition.Position",
                    "EmployeePosition.EmployeePositionInfo"
                    );

            return employees;
        }
    }
}