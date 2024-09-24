using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTap07.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSuppliersToTheLoai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Suppliers",
                table: "TheLoai",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Suppliers",
                table: "TheLoai");
        }
    }
}
