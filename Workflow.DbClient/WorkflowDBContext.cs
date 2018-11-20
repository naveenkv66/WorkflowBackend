using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Model;
namespace Workflow.DbClient
{
    public class WorkflowDBContext : DbContext
    {
      
        public WorkflowDBContext(DbContextOptions<WorkflowDBContext> options)
          : base(options)
        {

        }
        public DbSet<User> Users {get; set;}
        public DbSet<Model.Task> Tasks { get; set; }
        public DbSet<WorkflowConfiguration> WorkflowConfigurations { get; set; }
        public DbSet<WorkflowConfigurationDetail> WorkflowConfigurationDetails { get; set; }

    }
}
