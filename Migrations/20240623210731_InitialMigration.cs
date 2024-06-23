using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP7.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "Employees",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Employees",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "VARCHAR",
                oldMaxLength: 50);
        }
    }
}
