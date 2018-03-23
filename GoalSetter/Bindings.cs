using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoalSetter
{
    public class Bindings : NinjectModule

    {
        public override void Load()
        {
            Bind<goalsetterEntities>().To<goalsetterEntities>();
        }
    }
}