using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace ApprovalActivity.CodeActivities
{

    public sealed class GetWorkflowConfiguration : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> Text { get; set; }
        public OutArgument<Workflow.Entites.WorkflowConfiguration> WorkflowConfiguration { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);

            var wfConfig = new Workflow.Model.WorkflowConfiguration()
            {
                WorkflowName = "OnboardingWorkFlow",
                CreatedBy = "System",
                IsActive = true,
                CreatedDate =DateTime.Now,
                WorkflowConfigurationDetails = new List<Workflow.Model.WorkflowConfigurationDetail>()
                {
                    new Workflow.Model.WorkflowConfigurationDetail(){SequenceNumber=1,CreatedDate=DateTime.Now,Approver =1,ApprovalUserType=Workflow.Infrastructure.Enums.ApprovalUserType.User,WorkflowConfigurationId =1},
                    new Workflow.Model.WorkflowConfigurationDetail(){SequenceNumber=1,CreatedDate=DateTime.Now,Approver =2,ApprovalUserType=Workflow.Infrastructure.Enums.ApprovalUserType.User,WorkflowConfigurationId =1},
                    new Workflow.Model.WorkflowConfigurationDetail(){SequenceNumber=1,CreatedDate=DateTime.Now,Approver =3,ApprovalUserType=Workflow.Infrastructure.Enums.ApprovalUserType.User,WorkflowConfigurationId =1},

                }

            };

            this.WorkflowConfiguration.Set(context, wfConfig);
        }
    }
}
