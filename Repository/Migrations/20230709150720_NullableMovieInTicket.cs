using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class NullableMovieInTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Movies_MovieId",
                table: "Ticket");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Movies_MovieId",
                table: "Ticket",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Movies_MovieId",
                table: "Ticket");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Movies_MovieId",
                table: "Ticket",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
