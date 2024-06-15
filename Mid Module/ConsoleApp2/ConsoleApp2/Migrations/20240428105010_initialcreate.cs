using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Authorid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Authorname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Author__70DDC00C8D37A21F", x => x.Authorid);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Bookid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bookname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Authorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Book__3DE1DE3F2F7462C8", x => x.Bookid);
                    table.ForeignKey(
                        name: "FK_Book_ToTable",
                        column: x => x.Authorid,
                        principalTable: "Author",
                        principalColumn: "Authorid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Authorid",
                table: "Book",
                column: "Authorid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
