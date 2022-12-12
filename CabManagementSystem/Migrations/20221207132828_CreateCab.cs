using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CabManagementSystem.Migrations
{
    public partial class CreateCab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cabs");
        }
    }
}
