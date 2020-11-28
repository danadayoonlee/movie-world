using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Get Out",
                    Description = "A young African American man visits his European American girlfriend's family estate where he learns that many of its residents, who are black, have gone missing, and he soon learns the horrible truth when another frantic African-American warns him to \"get out\". He soon learns this is easier said than done.",
                    DateReleased = DateTime.Parse("2017-2-24"),
                    Genre = "Horror, Mystery",
                    Actor = "Daniel Kaluuya, Allison Williams, Bradley Whitford",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTE2Nzg1NjkzNV5BMl5BanBnXkFtZTgwOTgyODMyMTI@._V1_SY500_CR0,0,315,500_AL_.jpg",
                    Sales = 30
                },
                new Movie
                {
                    Id = 2,
                    Title = "Frozen",
                    Description = "Her sister Anna teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition.",
                    DateReleased = DateTime.Parse("2013-11-27"),
                    Genre = "Animation",
                    Actor = "Chris Buck, Jennifer Lee",
                    ImageUrl = "https://m.media-amazon.com/images/I/61Mbpe16YOL._AC_UL640_FMwebp_QL65_.jpg",
                    Sales = 37
                },
                 new Movie
                 {
                     Id = 3,
                     Title = "Jason Bourne",
                     Description = "The CIA's most dangerous former operative is drawn out of hiding to uncover more explosive truths about his past.",
                     DateReleased = DateTime.Parse("2016-07-26"),
                     Genre = "Actio, Thriller",
                     Actor = "Matt Damon, Tommy Lee Jones",
                     ImageUrl = "https://m.media-amazon.com/images/I/81-1hXkdqDL._AC_UL640_FMwebp_QL65_.jpg",
                     Sales = 28
                 },
                 new Movie
                 {
                     Id = 4,
                     Title = "Night School",
                     Description = "A group of high school dropouts are forced to attend night school in hope that they'll pass the GED exam to finish high school.",
                     DateReleased = DateTime.Parse("2018-09-28"),
                     Genre = "Comedy",
                     Actor = "Kevin Hart, Tiffany Haddish",
                     ImageUrl = "https://m.media-amazon.com/images/I/71bmSNavewL._AC_UL640_FMwebp_QL65_.jpg",
                     Sales = 110
                 },
                 new Movie
                 {
                     Id = 5,
                     Title = "Ready Player One",
                     Description = "When the creator of a virtual reality called the OASIS dies, he makes a posthumous challenge to all OASIS users to find his Easter Egg, which will give the finder his fortune and control of his world.",
                     DateReleased = DateTime.Parse("2018-03-28"),
                     Genre = "Action, Adventure, Sci-Fi",
                     Actor = "Tye Sheridan, Olivia Cooke",
                     ImageUrl = "https://m.media-amazon.com/images/I/A11LXrQIW3L._AC_UL480_FMwebp_QL65_.jpg",
                     Sales = 52
                 },
                 new Movie
                 {
                     Id = 6,
                     Title = "Cats",
                     Description = "A tribe of cats called the Jellicles must decide yearly which one will ascend to the Heaviside Layer and come back to a new Jellicle life.",
                     DateReleased = DateTime.Parse("2019-12-20"),
                     Genre = "Comedy, Drama, Family, Fantasy, Musical",
                     Actor = "James Corden, Judi Dench",
                     ImageUrl = "https://m.media-amazon.com/images/I/81cJ6tvF7tL._AC_UL320_.jpg",
                     Sales = 7
                 },
                 new Movie
                 {
                     Id = 7,
                     Title = "Dr. Seuss' the Grinch",
                     Description = "A grumpy Grinch (Benedict Cumberbatch) plots to ruin Christmas for the village of Whoville.",
                     DateReleased = DateTime.Parse("2018-11-09"),
                     Genre = "Animation, Comedy, Family, Fantasy",
                     Actor = "Benedict Cumberbatch, Cameron Seely ",
                     ImageUrl = "https://m.media-amazon.com/images/I/71v9+cEXjVL._AC_UL640_FMwebp_QL65_.jpg",
                     Sales = 35
                 },
                 new Movie
                 {
                     Id = 8,
                     Title = "Fatman",
                     Description = "A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit man to kill Santa after receiving a lump of coal in his stocking.",
                     DateReleased = DateTime.Parse("2020-11-24"),
                     Genre = "Action, Comedy, Fantasy, Thriller",
                     Actor = "Mel Gibson, Walton Goggins",
                     ImageUrl = "https://m.media-amazon.com/images/I/81hsWnSLycL._AC_UY327_FMwebp_QL65_.jpg",
                     Sales = 17
                 },
                 new Movie
                 {
                     Id = 9,
                     Title = "Rebecca",
                     Description = "A young newlywed arrives at her husband's imposing family estate on a windswept English coast and finds herself battling the shadow of his first wife, Rebecca, whose legacy lives on in the house long after her death.",
                     DateReleased = DateTime.Parse("2020-10-21"),
                     Genre = "Drama, Mystery, Romance, Thriller",
                     Actor = "Lily James, Armie Hammer",
                     ImageUrl = "https://m.media-amazon.com/images/I/91Uh9XHJPVL._AC_UL640_FMwebp_QL65_.jpg",
                     Sales = 32
                 },
                 new Movie
                 {
                     Id = 10,
                     Title = "Joker",
                     Description = "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.",
                     DateReleased = DateTime.Parse("2019-10-04"),
                     Genre = "Crime, Drama, Thriller",
                     Actor = "Joaquin Phoenix, Robert De Niro",
                     ImageUrl = "https://m.media-amazon.com/images/I/71YUVzV5OwL._AC_UY436_FMwebp_QL65_.jpg",
                     Sales = 120
                 },
                 new Movie
                 {
                     Id = 11,
                     Title = "Little Women",
                     Description = "In the years after the Civil War, Jo March (Saoirse Ronan) lives in New York City and makes her living as a writer, while her sister Amy March (Florence Pugh) studies painting in Paris.",
                     DateReleased = DateTime.Parse("2019-12-25"),
                     Genre = "Drama, Romance",
                     Actor = "Saoirse Ronan, Emma Watson",
                     ImageUrl = "https://m.media-amazon.com/images/I/61NVfk2uAXL._AC_UY654_FMwebp_QL65_.jpg",
                     Sales = 117
                 }
            );
        }
    }
}
