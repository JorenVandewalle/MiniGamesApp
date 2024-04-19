using MiniGamesAppLibrary;

namespace MiniGamesApp
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the MiniGameApp.");
                Console.WriteLine("Here you can choose and play a game. HAVE FUN!!!");
                Console.Write("Choose a game:");

                int gameNumber = Convert.ToInt32(Console.ReadLine());

                switch (gameNumber)
                {
                    case 1:
                        HigherLower higherLowerGame = new HigherLower();
                        higherLowerGame.HigherLowerMain();
                        break;
                    default:
                        Console.WriteLine("Not a valid number");
                        break;
                }
            }
        }
    }
}
