using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationG1.Data.Migrations
{
    public partial class Depto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Depto",
                table: "Ciudades");

            migrationBuilder.AddColumn<int>(
                name: "DeptoId",
                table: "Ciudades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Deptos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deptos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DeptoId",
                table: "Ciudades",
                column: "DeptoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Deptos_DeptoId",
                table: "Ciudades",
                column: "DeptoId",
                principalTable: "Deptos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Deptos_DeptoId",
                table: "Ciudades");

            migrationBuilder.DropTable(
                name: "Deptos");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_DeptoId",
                table: "Ciudades");

            migrationBuilder.DropColumn(
                name: "DeptoId",
                table: "Ciudades");

            migrationBuilder.AddColumn<int>(
                name: "Depto",
                table: "Ciudades",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
