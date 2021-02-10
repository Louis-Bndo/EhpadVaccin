using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EhpadVaccin.ORM.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nom = table.Column<string>(type: "TEXT", nullable: true),
                    prenom = table.Column<string>(type: "TEXT", nullable: true),
                    dateNaissace = table.Column<DateTime>(type: "TEXT", nullable: false),
                    sexe = table.Column<int>(type: "INTEGER", nullable: false),
                    role = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Injections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    personneId = table.Column<int>(type: "INTEGER", nullable: true),
                    dateInjection = table.Column<DateTime>(type: "TEXT", nullable: false),
                    dateRappel = table.Column<DateTime>(type: "TEXT", nullable: false),
                    numLot = table.Column<int>(type: "INTEGER", nullable: false),
                    typeVaccinId = table.Column<int>(type: "INTEGER", nullable: true),
                    marque = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Injections_Personnes_personneId",
                        column: x => x.personneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Injections_Vaccins_typeVaccinId",
                        column: x => x.typeVaccinId,
                        principalTable: "Vaccins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Injections_personneId",
                table: "Injections",
                column: "personneId");

            migrationBuilder.CreateIndex(
                name: "IX_Injections_typeVaccinId",
                table: "Injections",
                column: "typeVaccinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Injections");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Vaccins");
        }
    }
}
