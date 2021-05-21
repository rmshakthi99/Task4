using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileMVCProject.Migrations
{
    public partial class MyMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticePeriod = table.Column<int>(type: "int", nullable: false),
                    CurrentCTC = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.PersonId);
                });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "PersonId", "CurrentCTC", "IsEmployed", "Name", "NoticePeriod", "age", "qualification" },
                values: new object[] { 1, 3f, "yes", "abi", 3, 21, "B.E" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
