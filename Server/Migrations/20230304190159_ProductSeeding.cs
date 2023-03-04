using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagenUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "X 100pre is the debut studio album by Puerto Rican rapper Bad Bunny. It was released on December 24, 2018 on Christmas Eve, by Rimas Entertainment.", "https://media.pitchfork.com/photos/5c2cdf59673bd655963c817c/1:1/w_320/X%20100PRE_Bad%20Bunny.jpg", 9.99m, "X100pre" },
                    { 2, "Microdosis, which has 15 songs and the same number of music videos, also includes a collaboration with Latin artist Elena Rose and Feid, Mora's representatives detailed in a press release.", "https://i.scdn.co/image/ab67616d0000b273851222dc5c5681bd4c3119d3", 9.99m, "Microdosis" },
                    { 3, "Sentimiento, Elegancia, & Maldad (S.E.M.) (English: Sentiment, Elegance, & Malice) is the first studio album by singer-songwriter Arcángel. It was released on November 19, 2013, by Pina Records. The first single from the album, Hace Mucho Tiempo, was released on June 21, 2013.", "https://upload.wikimedia.org/wikipedia/en/d/d3/Sentimiento%2CEleganciaYMaldad.JPEG", 9.99m, "S.E.M" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
