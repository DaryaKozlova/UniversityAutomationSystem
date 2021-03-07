using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityAutomationSystem.Migrations
{
    public partial class teachertype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeacherTypeId",
                table: "Teacher",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_TeacherTypeId",
                table: "Teacher",
                column: "TeacherTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_TeacherType_TeacherTypeId",
                table: "Teacher",
                column: "TeacherTypeId",
                principalTable: "TeacherType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_TeacherType_TeacherTypeId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_TeacherTypeId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "TeacherTypeId",
                table: "Teacher");
        }
    }
}
