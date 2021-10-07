using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlAsistencia.Data.Migrations
{
    public partial class InitialCreateBDControldeAsistencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programa",
                columns: table => new
                {
                    ProgramaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programa", x => x.ProgramaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programa");
        }
    }
}
