using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Start_Game();
        }

        static void Start_Game()
        {
            Player playerX = new Player();
            Console.Write("Please enter your name player X : ");
            playerX.Name = Console.ReadLine();
            playerX.Marker = "X";

            Player playerO = new Player();
            Console.Write("Please enter your name for player O : ");
            playerO.Name = Console.ReadLine();
            playerO.Marker = "O";

            Game game = new Game(playerX, playerO);
            Player winner = game.Play();

            if (winner == null)
            {
                Console.WriteLine("No winner Game Over");
            }
        }
    }
}
