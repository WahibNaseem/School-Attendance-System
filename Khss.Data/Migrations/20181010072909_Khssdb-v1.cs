using Microsoft.EntityFrameworkCore.Migrations;

namespace KhssData.Migrations
{
    public partial class Khssdbv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "AttendaceId",
                table: "Attendances",
                newName: "AttendanceId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentClassId",
                table: "Attendances",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassId",
                table: "Attendances",
                column: "StudentClassId",
                principalTable: "StudentClasses",
                principalColumn: "StudentClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "AttendanceId",
                table: "Attendances",
                newName: "AttendaceId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentClassId",
                table: "Attendances",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassId",
                table: "Attendances",
                column: "StudentClassId",
                principalTable: "StudentClasses",
                principalColumn: "StudentClassId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
