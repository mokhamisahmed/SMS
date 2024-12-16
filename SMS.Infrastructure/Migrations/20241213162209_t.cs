using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class t : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentRegistrationExams_Exams_examId",
                table: "StudentRegistrationExams");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Exams_ExamId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ExamId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "examId",
                table: "StudentRegistrationExams",
                newName: "ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentRegistrationExams_examId",
                table: "StudentRegistrationExams",
                newName: "IX_StudentRegistrationExams_ExamId");

            migrationBuilder.AddColumn<int>(
                name: "ExamId1",
                table: "StudentRegistrationExams",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "ExamTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistrationExams_ExamId1",
                table: "StudentRegistrationExams",
                column: "ExamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentRegistrationExams_Exams_ExamId",
                table: "StudentRegistrationExams",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentRegistrationExams_Exams_ExamId1",
                table: "StudentRegistrationExams",
                column: "ExamId1",
                principalTable: "Exams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentRegistrationExams_Exams_ExamId",
                table: "StudentRegistrationExams");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentRegistrationExams_Exams_ExamId1",
                table: "StudentRegistrationExams");

            migrationBuilder.DropIndex(
                name: "IX_StudentRegistrationExams_ExamId1",
                table: "StudentRegistrationExams");

            migrationBuilder.DropColumn(
                name: "ExamId1",
                table: "StudentRegistrationExams");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "StudentRegistrationExams",
                newName: "examId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentRegistrationExams_ExamId",
                table: "StudentRegistrationExams",
                newName: "IX_StudentRegistrationExams_examId");

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "type",
                table: "ExamTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ExamId",
                table: "Students",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentRegistrationExams_Exams_examId",
                table: "StudentRegistrationExams",
                column: "examId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Exams_ExamId",
                table: "Students",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");
        }
    }
}
