using System;
using System.Collections.Generic;
using System.Linq;

namespace GameShop
{
    public class Shop : IInformation
    {
        private List<Game> games = new List<Game>();

        public Shop()
        {
        }
        public bool CheckId(int id)
        {
            Game gameInList = games.FirstOrDefault(i => i.Id.Equals(id));
            if (gameInList != null) return true;
            return false;
        }
        public void AddGame(Game game)
        {
            try
            {
                if (CheckId(game.Id))
                {
                    throw new ArgumentException("ID is existed!! please try again");
                }
                else
                {
                    games.Add(game);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }   
        }


        public bool RemoveGameById(int id)
        {
            Game gameInList = games.FirstOrDefault(i => i.Id.Equals(id));
            if (gameInList != null)
            {
                games.Remove(gameInList);
                return true;
            };
            return false;
        }

        public string PrintInformation()
        {
            string result = "";
            foreach (var b in games)
            {
                result = result + b.PrintInformation();
            }
            return result;
        }

        public string FindGamesByName(string title)
        {
            string result = "";
            foreach (var b in games.Where(n => n.Title.Equals(title)))
            {
                result = result + b.PrintInformation();
            }
            return result;
        }

        public bool UpdateGameById(int id, string title, string studio, double price, int quantity)
        {
            try
            {
                Game gameInList = games.FirstOrDefault(i => i.Id.Equals(id));
                if (gameInList != null)
                {
                    gameInList.Title = title;
                    gameInList.Studio = studio;
                    gameInList.Price = price;
                    return true;
                }
            }
            catch(ArgumentException ae)
            {
                IO.ToScreen(ae.Message);
            }
            return false;
        }
    }
}

