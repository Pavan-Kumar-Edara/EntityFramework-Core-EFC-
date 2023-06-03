using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class SportsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cricketers",
                columns: table => new
                {
                    cricketerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cricketerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cricketerLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cricketers", x => x.cricketerId);
                });

            migrationBuilder.CreateTable(
                name: "Footballers",
                columns: table => new
                {
                    footballerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    footballerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    footballerLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footballers", x => x.footballerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cricketers");

            migrationBuilder.DropTable(
                name: "Footballers");
        }
    }
}
