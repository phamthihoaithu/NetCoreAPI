using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTTH.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeDiaChi",
                table: "DaiLy",
                newName: "DiaChi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "DaiLy",
                newName: "DeDiaChi");
        }
    }
}
