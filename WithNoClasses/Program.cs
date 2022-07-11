using System;

namespace WithNoClasses
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
                    ReleasedOn = "Dec 19 1997",
                    Genre = "Action"
                },
                new
                {
                    Title = "Titanic",
                    Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious," +
                    " ill-fated R.M.S. Titanic.",
                    ReleasedOn = "March 31 1999",
                    Genre = "Drama"
                }
            };
            
        }
    }
}
