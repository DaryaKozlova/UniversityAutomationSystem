using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityAutomationSystem.Migrations
{
    public partial class splitname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTeacher_TeacherType_TeacherTypeId",
                table: "SubjectTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_TeacherType_TeacherTypeId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_TeacherTypeId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_SubjectTeacher_TeacherTypeId",
                table: "SubjectTeacher");

            migrationBuilder.DropColumn(
                name: "TeacherTypeId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "TeacherTypeId",
                table: "SubjectTeacher");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teacher",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teacher");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Teacher",
                newName: "Name");

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherTypeId",
                table: "Teacher",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherTypeId",
                table: "SubjectTeacher",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_TeacherTypeId",
                table: "Teacher",
                column: "TeacherTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_TeacherTypeId",
                table: "SubjectTeacher",
                column: "TeacherTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTeacher_TeacherType_TeacherTypeId",
                table: "SubjectTeacher",
                column: "TeacherTypeId",
                principalTable: "TeacherType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_TeacherType_TeacherTypeId",
                table: "Teacher",
                column: "TeacherTypeId",
                principalTable: "TeacherType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
