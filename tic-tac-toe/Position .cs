using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    class Position
    {
		public int Row { get; set; }
		public int Column { get; set; }

		/// <summary>
		/// The site is being prepared on the game
		/// </summary>
		/// <param name="row">row number</param>
		/// <param name="column">column number</param>
		public Position(int row, int column)
		{
			Row = row;
			Column = column;
		}
	}
}
