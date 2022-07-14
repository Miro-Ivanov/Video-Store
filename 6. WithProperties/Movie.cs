using System;
using System.Collections.Generic;
using System.Text;

namespace _5._WithOrder
{
    class Movie
    {
        public string title;
        public string description;
        public DateTime releasedOn;
        public Genre genre;
        public decimal rentPrice;
        public decimal salePrice;

        public Movie(string title, string description, DateTime ReleasedOn, Genre genre, decimal rentPrice, decimal salePrice)
        {
            this.Title = title;
            this.Description = description;
            this.ReleasedOn = ReleasedOn;
            this.Genre = genre;
            this.RentPrice = rentPrice;
            this.SalePrice = salePrice;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if(value.Length < 5 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Title must be between 5 and 50 characters long");
                }
                this.title = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if(value.Length < 10 || value.Length > 200)
                {
                    throw new ArgumentOutOfRangeException("Description must be between 10 and 200 characters");
                }
                this.description = value;
            }
        }

        public DateTime ReleasedOn
        {
            get
            {
                return this.releasedOn;
            }
            set
            {
                this.releasedOn = value;
            }
        }

        public Genre Genre
        {
            get
            {
                return this.genre;
            }
            set
            {
                this.genre = value;
            }
        }

        public decimal RentPrice
        {
            get
            {
                return this.rentPrice;
            }
            set
            {
                if(value < 0.00m || value > 4.99m)
                {
                    throw new ArgumentOutOfRangeException("Rent price cannot be less than 0 or more than 4.99");
                }
                this.rentPrice = value;
            }
        }

        public decimal SalePrice
        {
            get
            {
                return this.salePrice;
            }
            set
            {
                if (value < 0.00m || value > 24.99m)
                {
                    throw new ArgumentOutOfRangeException("Sale price cannot be less than 0 or more than 24.99");
                }
                this.salePrice = value;
            }
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
