using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ant.Infra.Data.Migrations
{
    public partial class AddTableSMS_SendRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SMS_SendRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Body = table.Column<string>(type: "mediumtext", maxLength: 4, nullable: false),
                    Status = table.Column<sbyte>(type: "tinyint(4)", maxLength: 4, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    IP = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Receiver = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    SMSTemplateID = table.Column<int>(nullable: true),
                    SMSType = table.Column<sbyte>(type: "tinyint(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMS_SendRecord", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SMS_SendRecord");
        }
    }
}
