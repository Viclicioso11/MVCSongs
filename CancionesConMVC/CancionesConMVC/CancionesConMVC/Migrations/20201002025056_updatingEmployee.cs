using Microsoft.EntityFrameworkCore.Migrations;

namespace CancionesConMVC.Migrations
{
    public partial class updatingEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Empleados_JefeDirectoEmpEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_JefeDirectoEmpEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "JefeDirecto",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "JefeDirectoEmpEmpleadoId",
                table: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "JefeDirectoEmpleadoId",
                table: "Empleados",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_JefeDirectoEmpleadoId",
                table: "Empleados",
                column: "JefeDirectoEmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Empleados_JefeDirectoEmpleadoId",
                table: "Empleados",
                column: "JefeDirectoEmpleadoId",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Empleados_JefeDirectoEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_JefeDirectoEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "JefeDirectoEmpleadoId",
                table: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "JefeDirecto",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JefeDirectoEmpEmpleadoId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_JefeDirectoEmpEmpleadoId",
                table: "Empleados",
                column: "JefeDirectoEmpEmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Empleados_JefeDirectoEmpEmpleadoId",
                table: "Empleados",
                column: "JefeDirectoEmpEmpleadoId",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
