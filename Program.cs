using System;

namespace GameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            int input = Option.INIT;
            string inputGame = Option.INPUT_GAME;

            shop.AddGame(new Game(1, "The Marvel's Spider-Man", "Insomniac Games", 59.99, 2000));
            shop.AddGame(new Game(2, "Pro Evolution Soccer 2021", "Konami", 29.99, 1000));
            shop.AddGame(new Game(3, "Minecraft", "Mojang", 19.99, 900));
            shop.AddGame(new Game(4, "Red Dead Redemption II", "Rockstart Games", 59.99, 500));
            shop.AddGame(new Game(5, "Stray", "BlueTwelve Studio", 29.99, 200));
            shop.AddGame(new GoldenEditionGame(50, "AC Origins", "Ubisoft", 89, 25));
            shop.AddGame(new GoldenEditionGame(51, "FIFA 23", "EA Vancouver", 89, 100));
            shop.AddGame(new GoldenEditionGame(52, "Uncharted - Legacy Of Thieves Collection", "Naughty Dog", 89, 30));
            while (input != Option.EXIT)
            {
                input = IO.EnterMenuOptions();
                switch (input)
                {
                    case Option.ADD_GAME:
                        do
                        {
                            inputGame = IO.EnterGame();
                            switch (inputGame)
                            {
                                case Option.ADD_NORMAL_GAME:
                                    try
                                    {
                                        shop.AddGame(new Game(
                                        IO.EnterId(),
                                        IO.EnterTitle(),
                                        IO.EnterStudio(),
                                        IO.EnterPrice(),
                                        IO.EnterQuantity()));
                                    }catch(ArgumentException ae)
                                    {
                                        IO.ToScreen(ae.Message);
                                    }
                                    break;
                                case Option.ADD_GOLD_EDITION_GAME:
                                    try
                                    {
                                        shop.AddGame(new GoldenEditionGame(
                                        IO.EnterId(),
                                        IO.EnterTitle(),
                                        IO.EnterStudio(),
                                        IO.EnterPrice(),
                                        IO.EnterQuantity()));
                                    }catch (ArgumentException ae)
                                    {
                                        IO.ToScreen(ae.Message);
                                    }
                            break;
                                default:
                                    break;
                            }
                        } while (inputGame != Option.EXIT_ENTER_GAME);
                        break;
                    case Option.SHOW_ALL_GAMES:
                        IO.ToScreen(shop.PrintInformation());
                        break;
                    case Option.SHOW_BY_NAME:
                        IO.ToScreen(shop.FindGamesByName(IO.EnterTitle()));
                        break;
                    case Option.REMOVE_Game:
                        IO.ToScreen(IO.ShowMessage(shop.RemoveGameById(IO.EnterId())));
                        break;
                    case Option.UPDATE_Game:
                        IO.ToScreen(IO.ShowMessage(shop.UpdateGameById(
                            IO.EnterId(),
                            IO.EnterTitle(),
                            IO.EnterStudio(),
                            IO.EnterPrice(),
                            IO.EnterQuantity()
                            )));
                        break;
                    case Option.EXIT:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}

