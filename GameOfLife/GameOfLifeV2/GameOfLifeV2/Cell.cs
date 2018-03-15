/* $Id: Cell.cs 8128 2018-02-21 21:36:01Z marechal $ */
/* CFPT-EI 03/2016
Project : "Conway Game of Life"
Author : C. Marechal
Description : class for a cell
******************************************
Update By : B.Silka
Version : 2.0
Date : 27.02.2018
Descritpion of the update : Changed the method "Cell.CountNeighbours()" for an approach "tell" and not "ask"
*/
using System;
using System.Collections.Generic;

namespace GameOfLifeV1
{
    public class Cell
    {
        private const bool DEFAULT_IS_ALIVE = false;


        private List<Cell> _neighbours;
        private CellState _cellState;

        public bool IsAlive { get; set; }
        public List<Cell> Neighbours { get => _neighbours; set => _neighbours = value; }
        public CellState CellState { get => _cellState; set => _cellState = value; }

        public Cell()
          : this(DEFAULT_IS_ALIVE)
        {
            // no code
        }

        /// <summary>
        /// designated constructor
        /// </summary>
        /// <param name="paramIsAlive"></param>
        public Cell(bool paramIsAlive)
        {
            this.Neighbours = new List<Cell>();
            this.IsAlive = paramIsAlive;
            this.CellState = new DeadState(this);
        }

        public int CountNeighbours(int x, int y, Cell[,] cells, int NbColumns, int NbRows)
        {
            this.Neighbours.Clear();
            for (int i = -1; i <= +1; i++)
            {
                for (int j = -1; j <= +1; j++)
                {
                    if ((x + i) >= 0 && (x + i) < NbColumns &&
                        (y + j) >= 0 && (y + j) < NbRows)
                    {
                        if (cells[x + i, y + j].IsAlive)
                        {
                            this.Neighbours.Add(cells[x + i, y + j]);
                        }
                    }
                }
            }
            if (cells[x, y].IsAlive)
                this.Neighbours.Remove(cells[x, y]); // a cell is not its own neighbour
            return this.Neighbours.Count;
        }

        public void Die()
        {
            CellState.Die();
        }

        public void Live()
        {
            CellState.Live();
        }
    }
}
