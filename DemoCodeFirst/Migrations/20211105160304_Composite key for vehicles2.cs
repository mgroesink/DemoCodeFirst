using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoCodeFirst.Migrations
{
    public partial class Compositekeyforvehicles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Vehicles_VehicleLicensePlate",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_VehicleLicensePlate",
                table: "Appointments");

            migrationBuilder.AddColumn<DateTime>(
                name: "VehicleStartDate",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                columns: new[] { "LicensePlate", "StartDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VehicleLicensePlate_VehicleStartDate",
                table: "Appointments",
                columns: new[] { "VehicleLicensePlate", "VehicleStartDate" });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Vehicles_VehicleLicensePlate_VehicleStartDate",
                table: "Appointments",
                columns: new[] { "VehicleLicensePlate", "VehicleStartDate" },
                principalTable: "Vehicles",
                principalColumns: new[] { "LicensePlate", "StartDate" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Vehicles_VehicleLicensePlate_VehicleStartDate",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_VehicleLicensePlate_VehicleStartDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "VehicleStartDate",
                table: "Appointments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "LicensePlate");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VehicleLicensePlate",
                table: "Appointments",
                column: "VehicleLicensePlate");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Vehicles_VehicleLicensePlate",
                table: "Appointments",
                column: "VehicleLicensePlate",
                principalTable: "Vehicles",
                principalColumn: "LicensePlate",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
