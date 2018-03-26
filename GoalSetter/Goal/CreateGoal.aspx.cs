using GoalSetter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoalSetter.Service;
using GoalSetter.Service.Interface;
using GoalSetter.Controllers;

namespace GoalSetter.Goal
{
    public partial class CreateGoal : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnSaveGoal_Click(object sender, EventArgs e)
        {
            Goals goalsObject = new Goals();
            goalsObject.Name = tbGoalName.Text;
            goalsObject.Duration = ddlGoalDuration.SelectedValue;
            goalsObject.Type = ddlGoalPersonal.SelectedValue;
            
        }
    }
}