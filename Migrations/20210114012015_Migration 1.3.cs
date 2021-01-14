using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netCoreMVC_CRUD.Migrations
{
    public partial class Migration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Classroom_Grades_GradeId",
                table: "Classroom");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudents_Classroom_ClassroomId",
                table: "ClassroomStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Guardian_Students_StudentId",
                table: "Guardian");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Classroom_ClassroomId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGuardian_Guardian_GuardianId",
                table: "StudentGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGuardian_Students_StudentId",
                table: "StudentGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Classroom_ClassroomId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_ClassroomId",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentGuardian",
                table: "StudentGuardian");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian");

            migrationBuilder.DropIndex(
                name: "IX_Guardian_StudentId",
                table: "Guardian");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Guardian");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "StudentGuardian",
                newName: "StudentGuardians");

            migrationBuilder.RenameTable(
                name: "Guardian",
                newName: "Guardians");

            migrationBuilder.RenameTable(
                name: "Classroom",
                newName: "Classrooms");

            migrationBuilder.RenameTable(
                name: "Attendance",
                newName: "Attendances");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_ClassroomId",
                table: "Teachers",
                newName: "IX_Teachers_ClassroomId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGuardian_GuardianId",
                table: "StudentGuardians",
                newName: "IX_StudentGuardians_GuardianId");

            migrationBuilder.RenameIndex(
                name: "IX_Classroom_GradeId",
                table: "Classrooms",
                newName: "IX_Classrooms_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendances",
                newName: "IX_Attendances_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentGuardians",
                table: "StudentGuardians",
                columns: new[] { "StudentId", "GuardianId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians",
                column: "GuardianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms",
                column: "ClassroomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Grades_GradeId",
                table: "Classrooms",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudents_Classrooms_ClassroomId",
                table: "ClassroomStudents",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGuardians_Guardians_GuardianId",
                table: "StudentGuardians",
                column: "GuardianId",
                principalTable: "Guardians",
                principalColumn: "GuardianId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGuardians_Students_StudentId",
                table: "StudentGuardians",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Classrooms_ClassroomId",
                table: "Teachers",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Grades_GradeId",
                table: "Classrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudents_Classrooms_ClassroomId",
                table: "ClassroomStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGuardians_Guardians_GuardianId",
                table: "StudentGuardians");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGuardians_Students_StudentId",
                table: "StudentGuardians");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Classrooms_ClassroomId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentGuardians",
                table: "StudentGuardians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "StudentGuardians",
                newName: "StudentGuardian");

            migrationBuilder.RenameTable(
                name: "Guardians",
                newName: "Guardian");

            migrationBuilder.RenameTable(
                name: "Classrooms",
                newName: "Classroom");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "Attendance");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_ClassroomId",
                table: "Teacher",
                newName: "IX_Teacher_ClassroomId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGuardians_GuardianId",
                table: "StudentGuardian",
                newName: "IX_StudentGuardian_GuardianId");

            migrationBuilder.RenameIndex(
                name: "IX_Classrooms_GradeId",
                table: "Classroom",
                newName: "IX_Classroom_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendance",
                newName: "IX_Attendance_StudentId");

            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "StudentCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Guardian",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentGuardian",
                table: "StudentGuardian",
                columns: new[] { "StudentId", "GuardianId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian",
                column: "GuardianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom",
                column: "ClassroomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_ClassroomId",
                table: "StudentCourses",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardian_StudentId",
                table: "Guardian",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classroom_Grades_GradeId",
                table: "Classroom",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudents_Classroom_ClassroomId",
                table: "ClassroomStudents",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guardian_Students_StudentId",
                table: "Guardian",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Classroom_ClassroomId",
                table: "StudentCourses",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGuardian_Guardian_GuardianId",
                table: "StudentGuardian",
                column: "GuardianId",
                principalTable: "Guardian",
                principalColumn: "GuardianId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGuardian_Students_StudentId",
                table: "StudentGuardian",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Classroom_ClassroomId",
                table: "Teacher",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
