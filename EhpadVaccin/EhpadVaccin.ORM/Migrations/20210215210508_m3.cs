using Microsoft.EntityFrameworkCore.Migrations;

namespace EhpadVaccin.ORM.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "Vaccins",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "dateNaissace",
                table: "Personnes",
                newName: "dateNaissance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Vaccins",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "dateNaissance",
                table: "Personnes",
                newName: "dateNaissace");
        }
    }
}
