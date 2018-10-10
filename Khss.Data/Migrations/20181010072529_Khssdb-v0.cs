using Microsoft.EntityFrameworkCore.Migrations;

namespace KhssData.Migrations
{
    public partial class Khssdbv0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentClasses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "StudentClasses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "StudentClasses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StudentClassId",
                table: "Attendances",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_ClassId",
                table: "StudentClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_SectionId",
                table: "StudentClasses",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_StudentId",
                table: "StudentClasses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentClassId",
                table: "Attendances",
                column: "StudentClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassId",
                table: "Attendances",
                column: "StudentClassId",
                principalTable: "StudentClasses",
                principalColumn: "StudentClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Classes_ClassId",
                table: "StudentClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Sections_SectionId",
                table: "StudentClasses",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Students_StudentId",
                table: "StudentClasses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_Classes_ClassId",
                table: "StudentClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_Sections_SectionId",
                table: "StudentClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_Students_StudentId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_ClassId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_SectionId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_StudentId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_StudentClassId",
                table: "Attendances");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentClasses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "StudentClasses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "StudentClasses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentClassId",
                table: "Attendances",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
