using System;
using System.Collections.Generic;
using System.Text;

namespace _5._WithOrder
{
    class Order
    {
        public string orderName;
        public DateTime orderedOn;
        public List<Movie> movies;

        public Order(string orderName)
        {
            this.orderName = orderName;
            orderedOn = DateTime.Now;
            this.movies = new List<Movie>();
        }

        public string OrderInfo()
        {
            StringBuilder result = new StringBuilder();
            if(movies.Count < 1)
            {
                result.AppendLine("No movies in your order");
            }
            foreach(var m in movies)
            {
                result.AppendLine(m.DisplaySaletInfo());
            }
            return result.ToString();
        }
    }
}
