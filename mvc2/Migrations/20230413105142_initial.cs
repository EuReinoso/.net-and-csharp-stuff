using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc2.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    CLI_CODIGON = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CLI_CGC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLI_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.CLI_CODIGON);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
