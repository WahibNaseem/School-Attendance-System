using Microsoft.EntityFrameworkCore.Migrations;

namespace KhssData.Migrations
{
    public partial class khssdbv2111AlterForeignkeyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_StudentClasses_ClassId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_SectionId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_StudentId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_StudentClassesRefId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "StudentClassesRefId",
                table: "Attendances");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_ClassRefId",
                table: "StudentClasses",
                column: "ClassRefId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_SectionRefId",
                table: "StudentClasses",
                column: "SectionRefId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_StudentRefId",
                table: "StudentClasses",
                column: "StudentRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentClassRefId",
                table: "Attendances",
                column: "StudentClassRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassRefId",
                table: "Attendances",
                column: "StudentClassRefId",
                principalTable: "StudentClasses",
                principalColumn: "StudentClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Classes_ClassRefId",
                table: "StudentClasses",
                column: "ClassRefId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Sections_SectionRefId",
                table: "StudentClasses",
                column: "SectionRefId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Students_StudentRefId",
                table: "StudentClasses",
                column: "StudentRefId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_StudentClasses_StudentClassRefId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_Classes_ClassRefId",
                table: "StudentClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_Sections_SectionRefId",
                table: "StudentClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_Students_StudentRefId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_ClassRefId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_SectionRefId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_StudentRefId",
                table: "StudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_StudentClassRefId",
                table: "Attendances");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "StudentClasses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "StudentClasses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentClasses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentClassesRefId",
                table: "Attendances",
                nullable: true);

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
    }
}
