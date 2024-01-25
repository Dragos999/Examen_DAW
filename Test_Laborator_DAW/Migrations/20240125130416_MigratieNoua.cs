using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestLaboratorDAW.Migrations
{
    /// <inheritdoc />
    public partial class MigratieNoua : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    pret = table.Column<int>(type: "int", nullable: false),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    varsta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idutilizator = table.Column<Guid>(name: "id_utilizator", type: "uniqueidentifier", nullable: true),
                    adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    utilizatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comanda_Utilizator_utilizatorId",
                        column: x => x.utilizatorId,
                        principalTable: "Utilizator",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ComandaProdus",
                columns: table => new
                {
                    idcomanda = table.Column<Guid>(name: "id_comanda", type: "uniqueidentifier", nullable: false),
                    idprodus = table.Column<Guid>(name: "id_produs", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaProdus", x => new { x.idcomanda, x.idprodus });
                    table.ForeignKey(
                        name: "FK_ComandaProdus_Comanda_id_produs",
                        column: x => x.idprodus,
                        principalTable: "Comanda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComandaProdus_Produs_id_produs",
                        column: x => x.idprodus,
                        principalTable: "Produs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_utilizatorId",
                table: "Comanda",
                column: "utilizatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaProdus_id_produs",
                table: "ComandaProdus",
                column: "id_produs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComandaProdus");

            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.DropTable(
                name: "Produs");

            migrationBuilder.DropTable(
                name: "Utilizator");
        }
    }
}
