using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestLaboratorDAW.Migrations
{
    /// <inheritdoc />
    public partial class Migratie4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaProdus_Comanda_id_produs",
                table: "ComandaProdus");

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaProdus_Comanda_id_comanda",
                table: "ComandaProdus",
                column: "id_comanda",
                principalTable: "Comanda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaProdus_Comanda_id_comanda",
                table: "ComandaProdus");

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaProdus_Comanda_id_produs",
                table: "ComandaProdus",
                column: "id_produs",
                principalTable: "Comanda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
