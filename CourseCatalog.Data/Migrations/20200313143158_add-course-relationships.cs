using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseCatalog.Data.Migrations
{
    public partial class addcourserelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeginSequence",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BeginYear",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseLevelId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseTypeId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CreditAdvancementAvailable",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CreditRecoveryAvailable",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditTypes",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CreditUnits",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EndSequence",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EndYear",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HighGradeId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LowGradeId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectAreaId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseLevel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLevelCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseTypeCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsCore = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseLevelId",
                table: "Courses",
                column: "CourseLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseTypeId",
                table: "Courses",
                column: "CourseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_HighGradeId",
                table: "Courses",
                column: "HighGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LowGradeId",
                table: "Courses",
                column: "LowGradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseLevel_CourseLevelId",
                table: "Courses",
                column: "CourseLevelId",
                principalTable: "CourseLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseType_CourseTypeId",
                table: "Courses",
                column: "CourseTypeId",
                principalTable: "CourseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Grade_HighGradeId",
                table: "Courses",
                column: "HighGradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Grade_LowGradeId",
                table: "Courses",
                column: "LowGradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseLevel_CourseLevelId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseType_CourseTypeId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Grade_HighGradeId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Grade_LowGradeId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CourseLevel");

            migrationBuilder.DropTable(
                name: "CourseType");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseLevelId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseTypeId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_HighGradeId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_LowGradeId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "BeginSequence",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "BeginYear",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseLevelId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseTypeId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreditAdvancementAvailable",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreditRecoveryAvailable",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreditTypes",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreditUnits",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EndSequence",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EndYear",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HighGradeId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LowGradeId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SubjectAreaId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Courses");
        }
    }
}
