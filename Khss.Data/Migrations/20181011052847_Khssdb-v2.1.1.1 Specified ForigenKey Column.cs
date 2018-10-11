using Microsoft.EntityFrameworkCore.Migrations;

namespace KhssData.Migrations
{
    public partial class Khssdbv2111SpecifiedForigenKeyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_Attendances_StudentClassId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "StudentClassId",
                table: "Attendances",
                newName: "StudentClassRefId");

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

            migrationBuilder.AddColumn<int>(
                name: "ClassRefId",
                table: "StudentClasses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SectionRefId",
                table: "StudentClasses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentRefId",
                table: "StudentClasses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentClassesRefId",
                table: "Attendances",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentClassesRefId",
                table: "Attendances",
                column: "StudentClassesRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassesRefId",
                table: "Attendances",
                column: "StudentClassesRefId",
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
                name: "FK_Attendances_StudentClasses_StudentClassesRefId",
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
                name: "IX_Attendances_StudentClassesRefId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "ClassRefId",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "SectionRefId",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "StudentRefId",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "StudentClassesRefId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "StudentClassRefId",
                table: "Attendances",
                newName: "StudentClassId");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Classes_ClassId",
                table: "StudentClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Sections_SectionId",
                table: "StudentClasses",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Students_StudentId",
                table: "StudentClasses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
