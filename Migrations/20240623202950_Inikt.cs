using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP7.Migrations
{
    /// <inheritdoc />
    public partial class Inikt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Department",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Department",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
