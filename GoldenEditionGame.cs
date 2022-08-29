using System;
namespace GameShop
{
    public class GoldenEditionGame : Game, IInformation
    {
        public GoldenEditionGame(int id, string title, string studio, double price, int quantity)
            : base(id, title, studio, price, quantity)
        {
        }
        public override double Price { get => base.Price+39; 
            set => base.Price = value; }
        
    }
}

