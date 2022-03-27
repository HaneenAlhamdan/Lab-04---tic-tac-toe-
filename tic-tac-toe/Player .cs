using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    class Player
    {
		public string Name { get; set; }
		/// <summary>
		/// playerX is X and playerO will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Giving an indication of the role of the player who will play
		/// </summary>
		public bool IsTurn { get; set; }

		/// <summary>
		/// Gets the location from the user 
		/// </summary>
		/// <param name="board"></param>
		/// <returns> position of the location that the player selected </returns>
		public Position GetPosition(Game_Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please enter your position number ");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}

		/// <summary>
		/// Translates the location the user entered to 
		/// a location on the GameBoard.
		/// </summary>
		/// <param name="position"></param>
		/// <returns> a position on the GameBoard. </returns>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // 1
				case 2: return new Position(0, 1); // 2
				case 3: return new Position(0, 2); // 3
				case 4: return new Position(1, 0); // 4
				case 5: return new Position(1, 1); // 5
				case 6: return new Position(1, 2); // 6
				case 7: return new Position(2, 0); // 7
				case 8: return new Position(2, 1); // 8 
				case 9: return new Position(2, 2); // 9

				default: return null;
			}
		}

		/// <summary>
		/// He tells the player that it is his turn and checks the place he chose if it has been used or not
		/// </summary>
		/// <param name="board"></param>
		public void TakeTurn(Game_Board board)
		{
			IsTurn = true;
		ChoosePosition:
			Console.WriteLine($"{Name} : Now it's your turn to play");

			Position position = GetPosition(board);

			if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
			{
				board.GameBoard[position.Row, position.Column] = Marker;
			}
			else
			{
				Console.WriteLine("This place has been used");
				board.DisplayGame_Board();
				goto ChoosePosition;
			}
		}
	}
}
