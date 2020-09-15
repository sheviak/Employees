using Employees.Bl.Interface;
using Employees.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employees.Api.Helpers;
using AutoMapper;
using Employees.Core;
using System.Collections.Generic;

namespace Employees.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IMapper mapper;
        private readonly ErrorHelper errorHelper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper, ErrorHelper errorHelper)
        {
            this.employeeService = employeeService;
            this.mapper = mapper;
            this.errorHelper = errorHelper;
        }

        [HttpGet("{pageNumber}/{pageSize}")]
        public IActionResult GetPartEmployee(int pageNumber, int pageSize)
        {
            var coll = this.employeeService.GetPartEmployeers(pageNumber, pageSize);
            var collVm = this.mapper.Map<IEnumerable<EmployeeViewModel>>(coll);
            return Ok(collVm);
        }

        [HttpPost("new")]
        public IActionResult CreateEmployee(InsertEmployeeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("tt", "sdsd");
                return BadRequest(this.errorHelper.GetModelStateErrors(ModelState));
            }

            var employee = this.employeeService.CreateEmployee(this.mapper.Map<Employee>(model));
            var employeeVm = this.mapper.Map<EmployeeViewModel>(employee);

            return Ok(employeeVm);
        }
    }
}