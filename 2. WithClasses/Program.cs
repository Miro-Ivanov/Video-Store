using System;

namespace _2._WithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie TheMatrix = new Movie();
            TheMatrix.Title = "The Matrix";
            TheMatrix.Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld," +
                    " he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.";
            TheMatrix.genre = Genre.action;
            TheMatrix.ReleasedOn = new DateTime(1999, 31, 3);
            TheMatrix.RentPrice = 2.99m;
            TheMatrix.SalePrice = 9.99m;

            Movie Titanic = new Movie();
            Titanic.Title = "Titanic";
            Titanic.Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious," +
                    " ill-fated R.M.S. Titanic.";
            Titanic.genre = Genre.drama;
            Titanic.ReleasedOn = new DateTime(1997, 12, 19);
            Titanic.RentPrice = 8.99m;
            Titanic.SalePrice = 3.99m;
        }
    }
    class Movie
    {
        public string Title;
        public string Description;
        public DateTime ReleasedOn;
        public Genre genre;
        public decimal RentPrice;
        public decimal SalePrice;
    }
    public enum Genre
    {
        action,
        drama,
        comedy
    }
}
