using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS174Website.Migrations
{
    /// <inheritdoc />
    public partial class SeedTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SprintNumber = table.Column<int>(type: "int", nullable: false),
                    PointValue = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "Name", "PointValue", "SprintNumber", "Status" },
                values: new object[,]
                {
                    { 1, "Basic layout", "Create Base Page", 3, 1, "To Do" },
                    { 2, "Decoration", "Add Decoration", 5, 1, "In Progress" },
                    { 3, "QA checks", "Testing", 2, 2, "QA" },
                    { 4, "QA checks", "Testing", 23, 55, "QA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
