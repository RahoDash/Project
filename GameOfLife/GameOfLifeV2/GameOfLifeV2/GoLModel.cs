/* $Id: GoLModel.cs 8128 2018-02-21 21:36:01Z marechal $ */
/* CFPT-EI 03/2016
Project : "Conway Game of Life"
Author : C. Marechal
Description : Model class (MVC design pattern)
******************************************
Update By : B.Silka
Version : 2.0
Date : 27.02.2018
Descritpion of the update : Changed the method "GolModel.CountNeighbours()" in result of 
                            the "Cell" method "CountNeighbours()" with the approach "tell"
*/
using System;
using System.Collections.Generic;

namespace GameOfLifeV1
{
    public class GoLModel
    {
        public const int DEFAULT_NB_COLUMNS = 50;
        public const int DEFAULT_NB_ROWS = 50;
        public readonly int MAX_NB_COLUMNS = 100;
        public readonly int MAX_NB_ROWS = 100;
        public const int PERCENTAGE_OF_ALIVE_CELLS_IN_RANDOM = 20;

        private int _nbColumns;
        private int _nbRows;
        //private List<Object> _observer;

        public List<Object> Observers { get; private set; }

        public int NbColumns
        {
            get { return _nbColumns; }
            set { _nbColumns = Math.Min(value, MAX_NB_COLUMNS); }
        }

        public int NbRows
        {
            get { return _nbRows; }
            set { _nbRows = Math.Min(value, MAX_NB_ROWS); }
        }

        /// <summary>
        /// 2 dimensions array for cells storage
        /// </summary>
        public Cell[,] Cells { get; set; }
        

        /// <summary>
        /// convenience constructor
        /// </summary>
        public GoLModel()
          : this(DEFAULT_NB_COLUMNS, DEFAULT_NB_ROWS)
        {
            // no code
        }

        /// <summary>
        /// designated constructor
        /// </summary>
        /// <param name="paramNbColumns"></param>
        /// <param name="paramNbRows"></param>
        public GoLModel(int paramNbColumns, int paramNbRows)
        {
            this.NbColumns = paramNbColumns;
            this.NbRows = paramNbRows;
            this.Observers = new List<object>();

            this.BuildEmptyCellsArray(this.NbColumns, this.NbRows);
        }

        public void FillArrayWithRandomCells()
        {
            this.FillArrayWithRandomCells(this.Cells);
        }

        public void FillArrayWithRandomCells(Cell[,] paramCells)
        {
            // random alive cell
            Random rand = new Random();
            for (int i = 0; i < this.NbColumns * this.NbRows / (100 / PERCENTAGE_OF_ALIVE_CELLS_IN_RANDOM); i++)
            {
                this.SetCell(true, rand.Next(0, this.NbColumns), rand.Next(0, this.NbRows));
            }
        }

        //Remove an observer
        public void UnregisterController(Object paramObserver)
        {
            this.Observers.Remove(paramObserver);
        }


        //Register an observer
        public void RegisterObserver(Object paramObserver)
        {
            if (paramObserver != null)
            {
                this.Observers.Add(paramObserver);
            }
        }

        private void BuildEmptyCellsArray(int paramNbColumns, int paramNbRows)
        {
            this.Cells = new Cell[this.NbColumns, this.NbRows];
            for (int i = 0; i < this.NbColumns; i++)
            {
                for (int j = 0; j < this.NbRows; j++)
                {
                    this.Cells[i, j] = new Cell();
                }
            }
        }

        /// <summary>
        /// Build next generation of cells to Conway Game of Life rules
        /// </summary>
        public void BuildNextGeneration()
        {
            Cell[,] nextGenCells = new Cell[this.NbColumns, this.NbRows];

            // apply rules
            for (int x = 0; x < this.NbColumns; x++)
            {
                for (int y = 0; y < this.NbRows; y++)
                {
                    nextGenCells[x, y] = new Cell();
                    int nbNeighbours = this.CountNeighbours(x, y);

                    // death
                    if (this.Cells[x, y].IsAlive == true &&
                        ((nbNeighbours < 2) || (nbNeighbours > 3))
                       )
                    {
                        nextGenCells[x, y].Die();
                    }

                    // survive
                    if (this.Cells[x, y].IsAlive == true &&
                        ((nbNeighbours == 2) || (nbNeighbours == 3))
                       )
                    {
                        nextGenCells[x, y].Live();
                    }

                    // birth
                    if (this.Cells[x, y].IsAlive == false &&
                        (nbNeighbours == 3)
                       )
                    {
                        nextGenCells[x, y].Live();
                    }
                } // end for y
            } // end for x

            this.Cells = nextGenCells;

            Notify();
        }

        private void Notify()
        {
            this.Observers.ForEach(o => (o as GoLController)?.Notify());
        }

        /// <summary>
        /// Count neightbours of a cell according to Conway Game of Life rules
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int CountNeighbours(int x, int y)
        {
            return this.Cells[x, y].CountNeighbours(x, y, this.Cells, this.NbColumns, this.NbRows);
        }

        public void SetCell(bool paramIsAlive, int x, int y)
        {
            if (paramIsAlive) this.Cells[x, y].Live(); else this.Cells[x, y].Die();
            this.Notify();
        }

        public Cell GetCell(int x, int y)
        {
            return this.Cells[x, y];
        }

        public void ClearArrayOfCells()
        {
            this.BuildEmptyCellsArray(this.NbColumns, this.NbRows);
        }

        public bool[,] GetGridContent()
        {
            bool[,] gridContent = new bool[this.NbColumns, this.NbRows];
            for (int i = 0; i < this.NbColumns; i++)
            {
                for (int j = 0; j < this.NbRows; j++)
                {
                    gridContent[i, j] = this.Cells[i, j].IsAlive;
                }
            }
            return gridContent;
        }
    }
}
