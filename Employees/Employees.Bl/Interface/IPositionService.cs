using System.Collections.Generic;
using Employees.Core;

namespace Employees.Bl.Interface
{
    public interface IPositionService
    {
        Position CreatePosition(Position position);
        IEnumerable<Position> GetPositions();
    }
}