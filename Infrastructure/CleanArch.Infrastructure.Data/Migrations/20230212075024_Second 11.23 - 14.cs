using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArch.Infrastructure.Data.Migrations
{
    public partial class Second112314 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "tblPerson",
                newName: "Family");

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "tblPerson",
                type: "nvarchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(150)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Family",
                table: "tblPerson",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "tblPerson",
                type: "char(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");
        }
    }
}
