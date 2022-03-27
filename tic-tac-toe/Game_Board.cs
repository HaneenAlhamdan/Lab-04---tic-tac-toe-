using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    class Game_Board
    {
		// <summary>
		//  Game board states
		// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayGame_Board()
		{

			/// <summary>
			///  Gameboard screen.
			/// </summary>
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write($"|{GameBoard[i, j]}|");
				}
				Console.WriteLine("");
			}

		}
	}

}
