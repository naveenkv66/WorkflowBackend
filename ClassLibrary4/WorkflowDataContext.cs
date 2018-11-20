using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Workflow.Entites;

namespace DbClient
{
    public class WorkflowDataContext: DbContext
    {
        public WorkflowDataContext(DbContextOptions<WorkflowDataContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<WorkflowConfiguration> WorkflowConfigurations { get; set; }
        public DbSet<WorkflowConfigurationDetail> WorkflowConfigurationDetails { get; set; }

    }
}
