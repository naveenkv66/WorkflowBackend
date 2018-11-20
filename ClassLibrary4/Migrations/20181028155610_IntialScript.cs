using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbClient.Migrations
{
    public partial class IntialScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestTypeDesc = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WF_Task",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionUserId = table.Column<long>(nullable: true),
                    ActionGroupId = table.Column<long>(nullable: true),
                    WorkflowStateId = table.Column<byte>(nullable: false),
                    WorkflowConfigurationId = table.Column<long>(nullable: false),
                    WorkflowInstanceId = table.Column<Guid>(nullable: false),
                    IsEscalated = table.Column<bool>(nullable: false),
                    IsNotResponded = table.Column<bool>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Action = table.Column<byte>(nullable: false),
                    Approver = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    IsDelegated = table.Column<bool>(nullable: false),
                    DelegatedFrom = table.Column<long>(nullable: true),
                    DelegatedBy = table.Column<string>(nullable: true),
                    DelegationComments = table.Column<string>(nullable: true),
                    DelegatedDate = table.Column<DateTime>(nullable: true),
                    IsActionOnlyRequiredTask = table.Column<bool>(nullable: false),
                    IsGroupTask = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    AssignedTo = table.Column<long>(nullable: true),
                    AssignedBy = table.Column<long>(nullable: true),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WF_Task", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WF_User",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Displayname = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WF_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WF_WorkflowConfiguration",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkflowName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RequestTypeId = table.Column<long>(nullable: false),
                    EndpointSystemId = table.Column<long>(nullable: true),
                    ApplicableUserTypes = table.Column<string>(nullable: true),
                    ApplicableAccountTypes = table.Column<string>(nullable: true),
                    ApplicableActionTypes = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WF_WorkflowConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WF_WorkflowConfiguration_RequestType_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequestType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WF_WorkflowConfigurationDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkflowConfigurationId = table.Column<long>(nullable: false),
                    SequenceNumber = table.Column<byte>(nullable: false),
                    ApprovalUserType = table.Column<byte>(nullable: false),
                    Approver = table.Column<int>(nullable: false),
                    ResponseTimeInDays = table.Column<int>(nullable: false),
                    IsActionRequired = table.Column<bool>(nullable: false),
                    RequiresApprovalFromAll = table.Column<bool>(nullable: false),
                    IsMockGroup = table.Column<bool>(nullable: false),
                    IsReminderRequired = table.Column<bool>(nullable: false),
                    ReminderIntervalInDays = table.Column<int>(nullable: true),
                    IsEscalationRequired = table.Column<bool>(nullable: false),
                    DaysToWaitAfterEscalation = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WF_WorkflowConfigurationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WF_WorkflowConfigurationDetail_WF_WorkflowConfiguration_WorkflowConfigurationId",
                        column: x => x.WorkflowConfigurationId,
                        principalTable: "WF_WorkflowConfiguration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WF_WorkflowConfiguration_RequestTypeId",
                table: "WF_WorkflowConfiguration",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WF_WorkflowConfigurationDetail_WorkflowConfigurationId",
                table: "WF_WorkflowConfigurationDetail",
                column: "WorkflowConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WF_Task");

            migrationBuilder.DropTable(
                name: "WF_User");

            migrationBuilder.DropTable(
                name: "WF_WorkflowConfigurationDetail");

            migrationBuilder.DropTable(
                name: "WF_WorkflowConfiguration");

            migrationBuilder.DropTable(
                name: "RequestType");
        }
    }
}
