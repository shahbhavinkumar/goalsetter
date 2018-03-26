using GoalSetter.DTO;
using GoalSetter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoalSetter.Service
{
    public class GoalsService_CRUD: IGoalsService_CRUD
    {
        private readonly goalsetterEntities _context;

        public GoalsService_CRUD(goalsetterEntities context)
        {
            _context = context;
        }

        public void SaveGoal(Goals goal)
        {
            using (_context)
            {
                var std = new goal()
                {
                    name = goal.Name,
                    duration = goal.Duration,
                    type = goal.Type
                    
                };
                _context.goals.Add(std);
                _context.SaveChanges();
            }
        }
    }
}