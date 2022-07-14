using System;
using System.Collections.Generic;
using System.Text;

namespace _5._WithOrder
{
    class Order
    {
        private string orderName;
        private DateTime orderedOn;
        private List<Movie> movies;

        public Order(string orderName)
        {
            this.OrderName = orderName;
            this.orderedOn = DateTime.Now;
            this.movies = new List<Movie>();
        }

        public string OrderName
        {
            get
            {
                return this.orderName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The name cannot be less thand 3 or more than 50 characters");
                }
                this.orderName = value;
            }
        }

        public void AddMovie(Movie movie) // We can avoid exposing the collection to the outside world
        {                                 // So we can give access only to the add function and if the movie is already there
            if (movies.Contains(movie)) // it won't be added again
            {
                throw new InvalidOperationException($"Movie with name {movie.Title} already exist");
            }
            movies.Add(movie);
        }

        public string OrderInfo()
        {
            StringBuilder result = new StringBuilder();
            if (movies.Count < 1)
            {
                result.AppendLine("No movies in your order");
            }
            foreach (var m in movies)
            {
                result.AppendLine(m.DisplaySaletInfo());
            }
            result.AppendLine("Ordered On: " + this.orderedOn.ToString());
            return result.ToString();
        }
    }
}
