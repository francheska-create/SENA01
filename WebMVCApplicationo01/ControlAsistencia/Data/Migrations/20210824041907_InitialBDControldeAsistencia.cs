using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlAsistencia.Data.Migrations
{
    public partial class InitialBDControldeAsistencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Programa",
                table: "Programa");

            migrationBuilder.RenameTable(
                name: "Programa",
                newName: "programa");

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "programa",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "programa",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "programa",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_programa",
                table: "programa",
                column: "ProgramaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_programa",
                table: "programa");

            migrationBuilder.RenameTable(
                name: "programa",
                newName: "Programa");

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "Programa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Programa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Programa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programa",
                table: "Programa",
                column: "ProgramaId");
        }
    }
}
