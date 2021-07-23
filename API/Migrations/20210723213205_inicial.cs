using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compromissos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dia = table.Column<DateTime>(type: "date", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compromissos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Compromissos",
                columns: new[] { "Id", "Dia", "Hora", "Local", "Tarefa" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 08, 02), new TimeSpan(8, 30, 0), "Escritorio", "Reunião" },
                    { 2, new DateTime(2021, 08, 07), new TimeSpan(19, 0, 0), "Casa da Julia", "Aniversario da Julia" },
                    { 3, new DateTime(2021, 08, 09), new TimeSpan(11, 30, 0), "Clinica", "Consulta Medica" },
                    { 4, new DateTime(2021, 08, 09), new TimeSpan(18, 30, 0), "Cinema", "Cinema" },
                    { 5, new DateTime(2021, 08, 14), new TimeSpan(7, 15, 0), "Supermercado", "Compras do Mês" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compromissos");
        }
    }
}
