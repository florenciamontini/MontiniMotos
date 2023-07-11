using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MontiniMotos.Migrations
{
    /// <inheritdoc />
    public partial class addmailproveedoraddmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Proveedors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Proveedors");
        }
    }
}
