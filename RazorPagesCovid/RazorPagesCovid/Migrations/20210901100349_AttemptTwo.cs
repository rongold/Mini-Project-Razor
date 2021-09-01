using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesCovid.Migrations
{
    public partial class AttemptTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Apppointments_AppointmentOneId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Apppointments_AppointmentTwoId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentTwoId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentOneId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Apppointments_AppointmentOneId",
                table: "Users",
                column: "AppointmentOneId",
                principalTable: "Apppointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Apppointments_AppointmentTwoId",
                table: "Users",
                column: "AppointmentTwoId",
                principalTable: "Apppointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Apppointments_AppointmentOneId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Apppointments_AppointmentTwoId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentTwoId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentOneId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Apppointments_AppointmentOneId",
                table: "Users",
                column: "AppointmentOneId",
                principalTable: "Apppointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Apppointments_AppointmentTwoId",
                table: "Users",
                column: "AppointmentTwoId",
                principalTable: "Apppointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
