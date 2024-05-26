using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ARD.Migrations
{
    /// <inheritdoc />
    public partial class updatetowatchedpositions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NickName",
                table: "AspNetUsers",
                newName: "Nickname");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WatchedPositions",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "WatchedPositions");

            migrationBuilder.RenameColumn(
                name: "Nickname",
                table: "AspNetUsers",
                newName: "NickName");
        }
    }
}
