using GoalSetter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalSetter.Service.Interface
{
    public interface IGoalsService_CRUD
    {
        void SaveGoal(Goals goal);
    }
}
