using GoalSetter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoalSetter.Service;

namespace GoalSetter.Goal
{
    public partial class CreateGoal : System.Web.UI.Page
    {
        private GoalsService _service = new GoalsService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveGoal_Click(object sender, EventArgs e)
        {
            Goals goalsObject = new Goals();
            goalsObject.Name = tbGoalName.Text;
            goalsObject.Duration = Convert.ToInt32(ddlGoalDuration.SelectedValue);
            goalsObject.Type = ddlGoalPersonal.SelectedValue;

            
        }
    }
}