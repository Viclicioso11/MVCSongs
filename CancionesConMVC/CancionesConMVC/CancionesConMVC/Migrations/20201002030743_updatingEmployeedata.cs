using Microsoft.EntityFrameworkCore.Migrations;

namespace CancionesConMVC.Migrations
{
    public partial class updatingEmployeedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Empleados_JefeDirectoEmpleadoId1",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_JefeDirectoEmpleadoId1",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "JefeDirectoEmpleadoId1",
                table: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoJefeEmpleadoId",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JefeDirecto",
                table: "Empleados",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_EmpleadoJefeEmpleadoId",
                table: "Empleados",
                column: "EmpleadoJefeEmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Empleados_EmpleadoJefeEmpleadoId",
                table: "Empleados",
                column: "EmpleadoJefeEmpleadoId",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Empleados_EmpleadoJefeEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_EmpleadoJefeEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "EmpleadoJefeEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "JefeDirecto",
                table: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "JefeDirectoEmpleadoId1",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_JefeDirectoEmpleadoId1",
                table: "Empleados",
                column: "JefeDirectoEmpleadoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Empleados_JefeDirectoEmpleadoId1",
                table: "Empleados",
                column: "JefeDirectoEmpleadoId1",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
