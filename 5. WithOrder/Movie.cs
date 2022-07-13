using System;
using System.Collections.Generic;
using System.Text;

namespace _5._WithOrder
{
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

        public string DisplayInfo()
        {
            return $"Title: {this.Title}\nDescription: {this.Description}\nReleased On: {this.ReleasedOn.ToShortDateString()}\nGengre: {this.Genre}\n";
        }
        
        public string DisplaySaletInfo()
        {
            return $"Title: {this.Title}\n{this.SalePrice}\n";
        }
    }
}
