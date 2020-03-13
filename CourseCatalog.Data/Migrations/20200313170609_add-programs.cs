using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseCatalog.Data.Migrations
{
    public partial class addprograms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BeginYear = table.Column<int>(nullable: false),
                    EndYear = table.Column<int>(nullable: false),
                    TraditionalForMales = table.Column<bool>(nullable: true),
                    TraditionalForFemales = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programs");
        }
    }
}
