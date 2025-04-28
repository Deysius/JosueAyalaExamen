using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosueAyalaExamen.Migrations
{
    /// <inheritdoc />
    public partial class Holaxd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Recompensa_RecompensaId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_RecompensaId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "RecompensaId",
                table: "Cliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecompensaId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_RecompensaId",
                table: "Cliente",
                column: "RecompensaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Recompensa_RecompensaId",
                table: "Cliente",
                column: "RecompensaId",
                principalTable: "Recompensa",
                principalColumn: "RecompensaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
