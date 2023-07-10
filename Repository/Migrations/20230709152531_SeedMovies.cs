using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id",  "Name", "Rating", "Director" },
                values: new object[] { Guid.NewGuid(), "The Shawshank Redemption", 9.2, "Frank Darabont" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Rating", "Director" },
                values: new object[] { Guid.NewGuid(), "The Godfather", 9.2, "Francis Ford Coppola" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Rating", "Director" },
                values: new object[] { Guid.NewGuid(), "The Dark Knight", 9.0, "Christopher Nolan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Rating", "Director" },
                values: new object[] { Guid.NewGuid(), "12 Angry Men", 9.0, "Sidney Lumet" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Rating", "Director" },
                values: new object[] { Guid.NewGuid(), "Schindler's List", 8.9, "Steben Spielberg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
