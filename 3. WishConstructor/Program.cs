using System;

namespace _3._WishConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie TheMatrix = new Movie("The Matrix", "When a beautiful stranger leads computer hacker Neo to a forbidding underworld," +
                    " he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", new DateTime(1999, 3, 31), Genre.action, 2.99m, 9.99m);

            Movie Titanic = new Movie("Titanic", "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious," +
                    " ill-fated R.M.S. Titanic.", new DateTime(1997, 12, 19), Genre.action, 3.99m, 8.99m);
        }
    }
    class Movie
    {
        public string Title;
        public string Description;
        public DateTime ReleasedOn;
        public Genre Genre;
        public decimal RentPrice;
        public decimal SalePrice;

        public Movie(string title, string description, DateTime ReleasedOn, Genre genre, decimal rentPrice, decimal salePrice)
        {
            this.Title = title;
            this.Description = description;
            this.ReleasedOn = ReleasedOn;
            this.Genre = genre;
            this.RentPrice = rentPrice;
            this.SalePrice = salePrice;
        }
    }
    public enum Genre
    {
        action,
        drama,
        comedy
    }
}
