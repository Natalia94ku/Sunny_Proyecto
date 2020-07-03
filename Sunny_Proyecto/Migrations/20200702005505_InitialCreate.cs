using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sunny_Proyecto.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Datos_Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido_paterno = table.Column<string>(nullable: true),
                    Apellido_materno = table.Column<string>(nullable: true),
                    curp = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: true),
                    Fecha_nacimiento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    Discapacidad = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Colonia = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    correo_tutor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos_Alumnos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datos_Alumnos");
        }
    }
}
