using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    class Game
    {
		/// <summary>
		/// Set player X, player O, winner , Game_Board.
		/// </summary>
		public Player PlayerX { get; set; }
		public Player PlayerO { get; set; }
		public Player Winner { get; set; }
		public Game_Board Board { get; set; }


		/// <summary>
		/// Require players and a board to start a game. 
		/// </summary>
		/// <param name="pX">Player 1</param>
		/// <param name="pO">Player 2</param>
		public Game(Player pX, Player pO)
		{
			PlayerX = pX;
			PlayerO = pO;
			Board = new Game_Board();
		}

		/// <summary>
		/// The game starts showing the game boardEach time the player's turn comes and chooses until 
		/// one of the players wins and you show him the winner,or if there is a tie or there is no winner
		/// </summary>
		/// <returns> Winner or null if there is no winner(tie/draw)</returns>
		public Player Play()
		{
			int counter = 1;
			Board.DisplayGame_Board();
			while (counter < 10)
			{
				SwitchPlayer();
				Player currentPlayer = NextPlayer();
				currentPlayer.TakeTurn(Board);
				if (CheckForWinner(Board) == true)
				{
					Board.DisplayGame_Board();
					Console.WriteLine($"WE HAVE WINNER : '+ {currentPlayer.Name}");
					return currentPlayer;
				}
				Board.DisplayGame_Board();
				counter++;
			}
			return null;


		}

		/// <summary>
		/// Check if winner exists
		/// </summary>
		/// <param name="board">current state of the board</param>
		/// <returns>if winner exists</returns>
		public bool CheckForWinner(Game_Board board)
		{
			int[][] winners = new int[][]
			{
				new[] {1,2,3},
				new[] {4,5,6},
				new[] {7,8,9},

				new[] {1,4,7},
				new[] {2,5,8},
				new[] {3,6,9},

				new[] {1,5,9},
				new[] {3,5,7}
			};


			for (int i = 0; i < winners.Length; i++)
			{
				Position p1 = Player.PositionForNumber(winners[i][0]);
				Position p2 = Player.PositionForNumber(winners[i][1]);
				Position p3 = Player.PositionForNumber(winners[i][2]);

				string a = Board.GameBoard[p1.Row, p1.Column];
				string b = Board.GameBoard[p2.Row, p2.Column];
				string c = Board.GameBoard[p3.Row, p3.Column];


				if (a == b && a == c)
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Determine next player
		/// </summary>
		/// <returns>next player</returns>
		public Player NextPlayer()
		{
			return (PlayerX.IsTurn) ? PlayerX : PlayerO;
		}

		/// <summary>
		/// End one players turn and activate the other
		/// </summary>
		public void SwitchPlayer()
		{
			if (PlayerX.IsTurn)
			{

				PlayerX.IsTurn = false;


				PlayerO.IsTurn = true;
			}
			else
			{
				PlayerX.IsTurn = true;
				PlayerO.IsTurn = false;
			}
		}
	}
}
