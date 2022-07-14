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
                if(value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The name cannot be less thand 3 or more than 50 characters");
                }
                this.orderName = value;
            }
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
