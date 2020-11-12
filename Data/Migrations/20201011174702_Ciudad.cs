using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationG1.Data.Migrations
{
    public partial class Ciudad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CiudadID",
                table: "Personas",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Depto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CiudadID",
                table: "Personas",
                column: "CiudadID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Ciudades_CiudadID",
                table: "Personas",
                column: "CiudadID",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Ciudades_CiudadID",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropIndex(
                name: "IX_Personas_CiudadID",
                table: "Personas");

            migrationBuilder.AlterColumn<string>(
                name: "CiudadID",
                table: "Personas",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 5);
        }
    }
}
