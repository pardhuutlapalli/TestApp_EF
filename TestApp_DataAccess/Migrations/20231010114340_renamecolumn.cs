using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class renamecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Books",
                newName: "ISBNNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISBNNumber",
                table: "Books",
                newName: "ISBN");
        }
    }
}
