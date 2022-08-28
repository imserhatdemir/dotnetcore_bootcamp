using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentID",
                table: "comments",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "PointScore",
                table: "comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointScore",
                table: "comments");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "comments",
                newName: "CommentID");
        }
    }
}
