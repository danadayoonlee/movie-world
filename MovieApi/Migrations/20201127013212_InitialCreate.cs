using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReleased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Actor", "DateReleased", "Description", "Genre", "ImageUrl", "Sales", "Title" },
                values: new object[,]
                {
                    { 1, "Daniel Kaluuya, Allison Williams, Bradley Whitford", new DateTime(2017, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young African American man visits his European American girlfriend's family estate where he learns that many of its residents, who are black, have gone missing, and he soon learns the horrible truth when another frantic African-American warns him to \"get out\". He soon learns this is easier said than done.", "Horror, Mystery", "https://images-na.ssl-images-amazon.com/images/M/MV5BNTE2Nzg1NjkzNV5BMl5BanBnXkFtZTgwOTgyODMyMTI@._V1_SY500_CR0,0,315,500_AL_.jpg", 30, "Get Out" },
                    { 2, "Chris Buck, Jennifer Lee", new DateTime(2013, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Her sister Anna teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition.", "Animation", "https://m.media-amazon.com/images/I/61Mbpe16YOL._AC_UL640_FMwebp_QL65_.jpg", 37, "Frozen" },
                    { 3, "Matt Damon, Tommy Lee Jones", new DateTime(2016, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The CIA's most dangerous former operative is drawn out of hiding to uncover more explosive truths about his past.", "Actio, Thriller", "https://m.media-amazon.com/images/I/81-1hXkdqDL._AC_UL640_FMwebp_QL65_.jpg", 28, "Jason Bourne" },
                    { 4, "Kevin Hart, Tiffany Haddish", new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "A group of high school dropouts are forced to attend night school in hope that they'll pass the GED exam to finish high school.", "Comedy", "https://m.media-amazon.com/images/I/71bmSNavewL._AC_UL640_FMwebp_QL65_.jpg", 110, "Night School" },
                    { 5, "Tye Sheridan, Olivia Cooke", new DateTime(2018, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "When the creator of a virtual reality called the OASIS dies, he makes a posthumous challenge to all OASIS users to find his Easter Egg, which will give the finder his fortune and control of his world.", "Action, Adventure, Sci-Fi", "https://m.media-amazon.com/images/I/A11LXrQIW3L._AC_UL480_FMwebp_QL65_.jpg", 52, "Ready Player One" },
                    { 6, "James Corden, Judi Dench", new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A tribe of cats called the Jellicles must decide yearly which one will ascend to the Heaviside Layer and come back to a new Jellicle life.", "Comedy, Drama, Family, Fantasy, Musical", "https://m.media-amazon.com/images/I/81cJ6tvF7tL._AC_UL320_.jpg", 7, "Cats" },
                    { 7, "Benedict Cumberbatch, Cameron Seely ", new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "A grumpy Grinch (Benedict Cumberbatch) plots to ruin Christmas for the village of Whoville.", "Animation, Comedy, Family, Fantasy", "https://m.media-amazon.com/images/I/71v9+cEXjVL._AC_UL640_FMwebp_QL65_.jpg", 35, "Dr. Seuss' the Grinch" },
                    { 8, "Mel Gibson, Walton Goggins", new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit man to kill Santa after receiving a lump of coal in his stocking.", "Action, Comedy, Fantasy, Thriller", "https://m.media-amazon.com/images/I/81hsWnSLycL._AC_UY327_FMwebp_QL65_.jpg", 17, "Fatman" },
                    { 9, "Lily James, Armie Hammer", new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young newlywed arrives at her husband's imposing family estate on a windswept English coast and finds herself battling the shadow of his first wife, Rebecca, whose legacy lives on in the house long after her death.", "Drama, Mystery, Romance, Thriller", "https://m.media-amazon.com/images/I/91Uh9XHJPVL._AC_UL640_FMwebp_QL65_.jpg", 32, "Rebecca" },
                    { 10, "Joaquin Phoenix, Robert De Niro", new DateTime(2019, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.", "Crime, Drama, Thriller", "https://m.media-amazon.com/images/I/71YUVzV5OwL._AC_UY436_FMwebp_QL65_.jpg", 120, "Joker" },
                    { 11, "Saoirse Ronan, Emma Watson", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the years after the Civil War, Jo March (Saoirse Ronan) lives in New York City and makes her living as a writer, while her sister Amy March (Florence Pugh) studies painting in Paris.", "Drama, Romance", "https://m.media-amazon.com/images/I/61NVfk2uAXL._AC_UY654_FMwebp_QL65_.jpg", 117, "Little Women" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
