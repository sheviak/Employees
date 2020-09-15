using Employees.Bl.Interface;
using Employees.Core;
using Employees.Dal.Interface;
using System.Collections.Generic;

namespace Employees.Bl.Services
{
    public class PositionService : IPositionService
    {
        private readonly IUnitOfWork unitOfWork;

        public PositionService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Position CreatePosition(Position position)
        {
            this.unitOfWork.Repository<Position>().Insert(position);
            this.unitOfWork.Save();

            return position;
        }

        public IEnumerable<Position> GetPositions()
        {
            return this.unitOfWork.Repository<Position>().Get();
        }
    }
}