using GoalSetter.Service;
using GoalSetter.Service.Interface;
using Ninject.Modules;

namespace GoalSetter
{
    public class Bindings : NinjectModule

    {
        public override void Load()
        {
            Bind<goalsetterEntities>().To<goalsetterEntities>();
            Bind<IGoalsService_CRUD>().To<GoalsService_CRUD>();
        }
    }
}