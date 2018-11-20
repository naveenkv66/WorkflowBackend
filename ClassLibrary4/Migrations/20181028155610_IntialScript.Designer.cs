﻿// <auto-generated />
using System;
using DbClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbClient.Migrations
{
    [DbContext(typeof(WorkflowDataContext))]
    [Migration("20181028155610_IntialScript")]
    partial class IntialScript
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Workflow.Entites.RequestType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("RequestTypeDesc");

                    b.HasKey("Id");

                    b.ToTable("RequestType");
                });

            modelBuilder.Entity("Workflow.Entites.Task", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Action");

                    b.Property<DateTime?>("ActionDate");

                    b.Property<long?>("ActionGroupId");

                    b.Property<long?>("ActionUserId");

                    b.Property<string>("Approver");

                    b.Property<long?>("AssignedBy");

                    b.Property<long?>("AssignedTo");

                    b.Property<string>("Comments");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DelegatedBy");

                    b.Property<DateTime?>("DelegatedDate");

                    b.Property<long?>("DelegatedFrom");

                    b.Property<string>("DelegationComments");

                    b.Property<string>("GroupName");

                    b.Property<bool>("IsActionOnlyRequiredTask");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsCompleted");

                    b.Property<bool>("IsDelegated");

                    b.Property<bool>("IsEscalated");

                    b.Property<bool>("IsGroupTask");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsNotResponded");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("Remarks");

                    b.Property<long>("WorkflowConfigurationId");

                    b.Property<Guid>("WorkflowInstanceId");

                    b.Property<byte>("WorkflowStateId");

                    b.HasKey("Id");

                    b.ToTable("WF_Task");
                });

            modelBuilder.Entity("Workflow.Entites.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Displayname");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("WF_User");
                });

            modelBuilder.Entity("Workflow.Entites.WorkflowConfiguration", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicableAccountTypes");

                    b.Property<string>("ApplicableActionTypes");

                    b.Property<string>("ApplicableUserTypes");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<long?>("EndpointSystemId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<long>("RequestTypeId");

                    b.Property<string>("WorkflowName");

                    b.HasKey("Id");

                    b.HasIndex("RequestTypeId");

                    b.ToTable("WF_WorkflowConfiguration");
                });

            modelBuilder.Entity("Workflow.Entites.WorkflowConfigurationDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("ApprovalUserType");

                    b.Property<int>("Approver");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DaysToWaitAfterEscalation");

                    b.Property<bool>("IsActionRequired");

                    b.Property<bool>("IsEscalationRequired");

                    b.Property<bool>("IsMockGroup");

                    b.Property<bool>("IsReminderRequired");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<int?>("ReminderIntervalInDays");

                    b.Property<bool>("RequiresApprovalFromAll");

                    b.Property<int>("ResponseTimeInDays");

                    b.Property<byte>("SequenceNumber");

                    b.Property<long>("WorkflowConfigurationId");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowConfigurationId");

                    b.ToTable("WF_WorkflowConfigurationDetail");
                });

            modelBuilder.Entity("Workflow.Entites.WorkflowConfiguration", b =>
                {
                    b.HasOne("Workflow.Entites.RequestType", "RequestTypes")
                        .WithMany("WorkflowConfiguration")
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Workflow.Entites.WorkflowConfigurationDetail", b =>
                {
                    b.HasOne("Workflow.Entites.WorkflowConfiguration", "WorkflowConfigurations")
                        .WithMany("WorkflowConfigurationDetails")
                        .HasForeignKey("WorkflowConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
