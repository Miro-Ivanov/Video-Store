using System;

namespace _1._WithNoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new[]
            {
                new
                {
                    Title = "The Matrix",
                    Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld," +
                    " he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                    ReleasedOn = "March 31 1999",
                    Genre = "Action",
                    SalePrice = 9.99,
                    RentPrice = 2.99
                },
                new
                {
                    Title = "Titanic",
                    Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious," +
                    " ill-fated R.M.S. Titanic.",
                    ReleasedOn = "Dec 19 1997",
                    Genre = "Drama",
                    SalePrice = 8.99,
                    RentPrice = 3.99
                }
            };
        }
    }
}
