using AutoMapper;
using Employees.Api.ViewModels;
using Employees.Core;
using System.Collections.Generic;

namespace Employees.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Position, PositionViewModel>();
            CreateMap<PositionViewModel, Position>();

            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(x => x.EmployeePositions, x => x.MapFrom(x => x.EmployeePosition));

            CreateMap<EmployeePosition, EmployeePositionViewModel>()
                .ForMember(x => x.PositionName, x => x.MapFrom(x => x.Position.Name))
                .ForMember(x => x.Cash, x => x.MapFrom(x => x.EmployeePositionInfo.Cash))
                .ForMember(x => x.StartedWork, x => x.MapFrom(x => x.EmployeePositionInfo.StartedWork))
                .ForMember(x => x.EndedWork, x => x.MapFrom(x => x.EmployeePositionInfo.EndedWork));

            CreateMap<InsertEmployeeViewModel, Employee>()
                .ForMember(x => x.EmployeePosition, x => x.MapFrom(x => new List<EmployeePosition> 
                {
                    new EmployeePosition
                    {
                        PositionId = x.PositionId,
                        EmployeeId = x.Id,
                        EmployeePositionInfo = new EmployeePositionInfo
                        {
                            Cash = x.Cash,
                            StartedWork = x.StartedWork,
                            EndedWork = x.EndedWork
                        }
                    }
                }));
        }
    }
}