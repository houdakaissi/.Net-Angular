using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP7.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigratiokn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "VARCHAR", maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }
    }
}
