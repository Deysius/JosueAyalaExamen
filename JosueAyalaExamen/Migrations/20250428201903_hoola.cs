using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosueAyalaExamen.Migrations
{
    /// <inheritdoc />
    public partial class hoola : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanDeRecompensasId",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PlanDeRecompensasId",
                table: "Cliente",
                column: "PlanDeRecompensasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Recompensa_PlanDeRecompensasId",
                table: "Cliente",
                column: "PlanDeRecompensasId",
                principalTable: "Recompensa",
                principalColumn: "RecompensaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Recompensa_PlanDeRecompensasId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_PlanDeRecompensasId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "PlanDeRecompensasId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Cliente");
        }
    }
}
