using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAuthenticate.Migrations.CustomerDb
{
    public partial class initialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Customers",
            //    columns: table => new
            //    {
            //        CustomerId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        OTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        OTPExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsActive = table.Column<bool>(type: "bit", nullable: false),
            //        Enabled = table.Column<bool>(type: "bit", nullable: false),
            //        UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        SecurityQuestionOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        AnswerOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SecurityQuestionTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        AnswerTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customers", x => x.CustomerId);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Customers");
        }
    }
}
