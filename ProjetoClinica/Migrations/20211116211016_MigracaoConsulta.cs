using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoClinica.Migrations
{
    public partial class MigracaoConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBConsulta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paciente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Medico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraConsulta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBConsulta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBConsulta");
        }
    }
}
