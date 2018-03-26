using GoalSetter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoalSetter.Controllers
{
    public class Goals_CRUDController : Controller
    {
        private readonly IGoalsService_CRUD _service;

        public Goals_CRUDController(IGoalsService_CRUD service)
        {
            _service = service;
        }
        
    }
}