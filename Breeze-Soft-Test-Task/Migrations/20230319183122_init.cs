using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Breeze_Soft_Test_Task.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Producer = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EnginePower = table.Column<float>(type: "real", nullable: false),
                    Engine = table.Column<int>(type: "integer", nullable: false),
                    AmountOfCylinders = table.Column<byte>(type: "smallint", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: false),
                    ProducedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Available = table.Column<bool>(type: "boolean", nullable: false),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
                migrationBuilder.InsertData("Cars",
                   columns: new[] { "Producer", "Name", "EnginePower", "Engine", "AmountOfCylinders", "Color", "ProducedDate", "Available" },
                   values: new object[,]
                   {
                        { "Mercedes", "GL500", 8.3, 2, 12,"Red", DateTime.Now, true},
                        { "Fiat", "Tipo", 16.35, 4, 3,"Black", DateTime.Now, false }
                   });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
