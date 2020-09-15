using Microsoft.AspNetCore.Mvc;
using Employees.Core;
using Employees.Bl.Interface;
using Employees.Api.ViewModels;
using Employees.Api.Helpers;
using AutoMapper;
using System.Collections.Generic;

namespace Employees.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : Controller
    {
        private readonly IPositionService positionService;
        private readonly IMapper mapper;
        private readonly ErrorHelper errorHelper;

        public PositionController(IPositionService positionService, IMapper mapper, ErrorHelper errorHelper)
        {
            this.positionService = positionService;
            this.errorHelper = errorHelper;
            this.mapper = mapper;
        }

        [HttpGet("")]
        public IActionResult GetPositions()
        {
            var position = this.mapper.Map<IEnumerable<PositionViewModel>>(this.positionService.GetPositions());
            return Ok(position);
        }

        [HttpPost("new")]
        public IActionResult CreatePosition(PositionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var errors = this.errorHelper.GetModelStateErrors(ModelState);
                return BadRequest(errors);
            }

            var position = this.positionService.CreatePosition(this.mapper.Map<Position>(model));
            var positionVm = this.mapper.Map<EmployeeViewModel>(position);

            return Ok(positionVm);
        }
    }
}