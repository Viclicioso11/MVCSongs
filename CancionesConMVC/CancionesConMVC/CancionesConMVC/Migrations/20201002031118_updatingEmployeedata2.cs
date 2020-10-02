using Microsoft.EntityFrameworkCore.Migrations;

namespace CancionesConMVC.Migrations
{
    public partial class updatingEmployeedata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_JefeDirecto",
                table: "Empleados",
                column: "JefeDirecto");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Empleados_JefeDirecto",
                table: "Empleados",
                column: "JefeDirecto",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Empleados_JefeDirecto",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_JefeDirecto",
                table: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoJefeEmpleadoId",
                table: "Empleados",
                type: "int",
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
    }
}
