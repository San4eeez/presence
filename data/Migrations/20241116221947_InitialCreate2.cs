using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendance_status_statusid",
                table: "attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_attendance_students_studentsid",
                table: "attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_attendance_subject_subjectid",
                table: "attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSemesters_Groups_Groupsid",
                table: "GroupSemesters");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSemesters_semesters_semestersid",
                table: "GroupSemesters");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubjects_Groups_Groupsid",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubjects_subject_subjectid",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_students_Groups_Groupsid",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "subject",
                newName: "subject_id");

            migrationBuilder.RenameColumn(
                name: "Groupsid",
                table: "students",
                newName: "Groups_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "students",
                newName: "students_id");

            migrationBuilder.RenameIndex(
                name: "IX_students_Groupsid",
                table: "students",
                newName: "IX_students_Groups_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "status",
                newName: "status_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "semesters",
                newName: "semesters_id");

            migrationBuilder.RenameColumn(
                name: "subjectid",
                table: "GroupSubjects",
                newName: "subject_id1");

            migrationBuilder.RenameColumn(
                name: "Groupsid",
                table: "GroupSubjects",
                newName: "Groups_id");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubjects_subjectid",
                table: "GroupSubjects",
                newName: "IX_GroupSubjects_subject_id1");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubjects_Groupsid",
                table: "GroupSubjects",
                newName: "IX_GroupSubjects_Groups_id");

            migrationBuilder.RenameColumn(
                name: "semestersid",
                table: "GroupSemesters",
                newName: "semesters_id");

            migrationBuilder.RenameColumn(
                name: "Groupsid",
                table: "GroupSemesters",
                newName: "Groups_id");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSemesters_semestersid",
                table: "GroupSemesters",
                newName: "IX_GroupSemesters_semesters_id");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSemesters_Groupsid",
                table: "GroupSemesters",
                newName: "IX_GroupSemesters_Groups_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Groups",
                newName: "Groups_id");

            migrationBuilder.RenameColumn(
                name: "subjectid",
                table: "attendance",
                newName: "subject_id1");

            migrationBuilder.RenameColumn(
                name: "studentsid",
                table: "attendance",
                newName: "students_id");

            migrationBuilder.RenameColumn(
                name: "statusid",
                table: "attendance",
                newName: "status_id1");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "attendance",
                newName: "attendance_id");

            migrationBuilder.RenameIndex(
                name: "IX_attendance_subjectid",
                table: "attendance",
                newName: "IX_attendance_subject_id1");

            migrationBuilder.RenameIndex(
                name: "IX_attendance_studentsid",
                table: "attendance",
                newName: "IX_attendance_students_id");

            migrationBuilder.RenameIndex(
                name: "IX_attendance_statusid",
                table: "attendance",
                newName: "IX_attendance_status_id1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "attendance",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_status_status_id1",
                table: "attendance",
                column: "status_id1",
                principalTable: "status",
                principalColumn: "status_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_students_students_id",
                table: "attendance",
                column: "students_id",
                principalTable: "students",
                principalColumn: "students_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_subject_subject_id1",
                table: "attendance",
                column: "subject_id1",
                principalTable: "subject",
                principalColumn: "subject_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSemesters_Groups_Groups_id",
                table: "GroupSemesters",
                column: "Groups_id",
                principalTable: "Groups",
                principalColumn: "Groups_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSemesters_semesters_semesters_id",
                table: "GroupSemesters",
                column: "semesters_id",
                principalTable: "semesters",
                principalColumn: "semesters_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubjects_Groups_Groups_id",
                table: "GroupSubjects",
                column: "Groups_id",
                principalTable: "Groups",
                principalColumn: "Groups_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubjects_subject_subject_id1",
                table: "GroupSubjects",
                column: "subject_id1",
                principalTable: "subject",
                principalColumn: "subject_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_Groups_Groups_id",
                table: "students",
                column: "Groups_id",
                principalTable: "Groups",
                principalColumn: "Groups_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendance_status_status_id1",
                table: "attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_attendance_students_students_id",
                table: "attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_attendance_subject_subject_id1",
                table: "attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSemesters_Groups_Groups_id",
                table: "GroupSemesters");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSemesters_semesters_semesters_id",
                table: "GroupSemesters");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubjects_Groups_Groups_id",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubjects_subject_subject_id1",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_students_Groups_Groups_id",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "subject_id",
                table: "subject",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Groups_id",
                table: "students",
                newName: "Groupsid");

            migrationBuilder.RenameColumn(
                name: "students_id",
                table: "students",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_students_Groups_id",
                table: "students",
                newName: "IX_students_Groupsid");

            migrationBuilder.RenameColumn(
                name: "status_id",
                table: "status",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "semesters_id",
                table: "semesters",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "subject_id1",
                table: "GroupSubjects",
                newName: "subjectid");

            migrationBuilder.RenameColumn(
                name: "Groups_id",
                table: "GroupSubjects",
                newName: "Groupsid");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubjects_subject_id1",
                table: "GroupSubjects",
                newName: "IX_GroupSubjects_subjectid");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubjects_Groups_id",
                table: "GroupSubjects",
                newName: "IX_GroupSubjects_Groupsid");

            migrationBuilder.RenameColumn(
                name: "semesters_id",
                table: "GroupSemesters",
                newName: "semestersid");

            migrationBuilder.RenameColumn(
                name: "Groups_id",
                table: "GroupSemesters",
                newName: "Groupsid");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSemesters_semesters_id",
                table: "GroupSemesters",
                newName: "IX_GroupSemesters_semestersid");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSemesters_Groups_id",
                table: "GroupSemesters",
                newName: "IX_GroupSemesters_Groupsid");

            migrationBuilder.RenameColumn(
                name: "Groups_id",
                table: "Groups",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "subject_id1",
                table: "attendance",
                newName: "subjectid");

            migrationBuilder.RenameColumn(
                name: "students_id",
                table: "attendance",
                newName: "studentsid");

            migrationBuilder.RenameColumn(
                name: "status_id1",
                table: "attendance",
                newName: "statusid");

            migrationBuilder.RenameColumn(
                name: "attendance_id",
                table: "attendance",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_attendance_subject_id1",
                table: "attendance",
                newName: "IX_attendance_subjectid");

            migrationBuilder.RenameIndex(
                name: "IX_attendance_students_id",
                table: "attendance",
                newName: "IX_attendance_studentsid");

            migrationBuilder.RenameIndex(
                name: "IX_attendance_status_id1",
                table: "attendance",
                newName: "IX_attendance_statusid");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "date",
                table: "attendance",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_status_statusid",
                table: "attendance",
                column: "statusid",
                principalTable: "status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_students_studentsid",
                table: "attendance",
                column: "studentsid",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_subject_subjectid",
                table: "attendance",
                column: "subjectid",
                principalTable: "subject",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSemesters_Groups_Groupsid",
                table: "GroupSemesters",
                column: "Groupsid",
                principalTable: "Groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSemesters_semesters_semestersid",
                table: "GroupSemesters",
                column: "semestersid",
                principalTable: "semesters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubjects_Groups_Groupsid",
                table: "GroupSubjects",
                column: "Groupsid",
                principalTable: "Groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubjects_subject_subjectid",
                table: "GroupSubjects",
                column: "subjectid",
                principalTable: "subject",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_Groups_Groupsid",
                table: "students",
                column: "Groupsid",
                principalTable: "Groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
