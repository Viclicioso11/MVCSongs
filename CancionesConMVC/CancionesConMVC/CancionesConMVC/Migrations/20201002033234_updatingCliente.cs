using Microsoft.EntityFrameworkCore.Migrations;

namespace CancionesConMVC.Migrations
{
    public partial class updatingCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Empleados_EmpleadoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EmpleadoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_SoporteId",
                table: "Clientes",
                column: "SoporteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Empleados_SoporteId",
                table: "Clientes",
                column: "SoporteId",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Empleados_SoporteId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_SoporteId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EmpleadoId",
                table: "Clientes",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Empleados_EmpleadoId",
                table: "Clientes",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
