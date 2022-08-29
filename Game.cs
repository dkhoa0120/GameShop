using System;
using System.Collections.Generic;
using System.Linq;

namespace GameShop
{
    public class Game : IInformation
    {
        private int id;
        protected string title;
        private string studio;
        private double price;
        private int quantity;

        public Game(int id, string title, string studio, double price, int quantity)
        {
            this.Id = id;
            this.Title = title;
            this.Studio = studio;
            this.Price = price;
            this.Quantity = quantity;
        }
        public int Id { get => id; set => id = value; }

        public string Title
        {
            get => title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title must have more than 3 character!!! " +
                        "Please enter title again");
                }
                title = value;
            }
        }
        public string Studio
        {
            get => studio;
            set
            {
                bool containsInt = value.Any(char.IsDigit);
                if (containsInt)
                {
                    throw new ArgumentException("Studio not valid!");
                }
                studio = value;
            }
        }
        public virtual double Price
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public int Quantity { get => quantity; set => quantity = value; }

        public string PrintInformation()
        {
            return $"{GetType().Name} \t| ID: {Id} | Title: {Title} | Studio: {Studio} | Price: {Price} | Quantity: {Quantity}\n";
        }
    }
}

