using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAuthenticate.Migrations.DriverDb
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Drivers",
            //    columns: table => new
            //    {
            //        DriverId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IdNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        OTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        OTPExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Car_Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CarPlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CarColour = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CarSeats = table.Column<int>(type: "int", nullable: false),
            //        CurrentLongitude = table.Column<double>(type: "float", nullable: false),
            //        CurrentLatitude = table.Column<double>(type: "float", nullable: false),
            //        LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Rating = table.Column<float>(type: "real", nullable: false),
            //        IsActive = table.Column<bool>(type: "bit", nullable: false),
            //        Enabled = table.Column<bool>(type: "bit", nullable: false),
            //        UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        SecurityQuestionOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AnswerOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        SecurityQuestionTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AnswerTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        GUID = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Drivers", x => x.DriverId);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Drivers");
        }
    }
}
