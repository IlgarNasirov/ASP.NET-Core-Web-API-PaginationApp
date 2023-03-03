using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PaginationApp.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, "Several authors", "Religious", "The Bible" },
                    { 2, "Mao Zedong", "Political", "Quotations from Chairman Mao Tse-Tung" },
                    { 3, "Several authors", "Religious", "The Quran" },
                    { 4, "John Tolkien", "Fantasy", "The Lord Of The Rings" },
                    { 5, "Antoine de Saint-Exupery", "Children’s Novel", "The Little Prince" },
                    { 6, "Joanne Rowling", "Fantasy", "Harry Potter and the Philosopher’s Stone" },
                    { 7, "Robert Baden-Powell", "Manual / Instructional", "Scouting for Boys" },
                    { 8, "Agatha Christie", "Mystery Crime", "And Then There Were None" },
                    { 9, "John Tolkien", "Fantasy", "The Hobbit" },
                    { 10, "Cao Xueqin", "Novel", "The Dream Of The Red Chamber" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
