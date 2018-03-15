/* $Id: GoLModel.cs 8128 2018-02-21 21:36:01Z marechal $ */
/* CFPT-EI 03/2016
Project : "Conway Game of Life"
Author : C. Marechal
Muraro : V1
Rosset : V2
Tchakalov : V3 Singleton
Description : Model class (MVC design pattern)
*/
using System;

namespace GameOfLifeV3 {
  public class GoLModel {
    public const int DEFAULT_NB_COLUMNS = 3;
    public const int DEFAULT_NB_ROWS = 3;
    public readonly int MAX_NB_COLUMNS = 100;
    public readonly int MAX_NB_ROWS = 100;
    public const int PERCENTAGE_OF_ALIVE_CELLS_IN_RANDOM = 20;

    private int _nbColumns;
    private int _nbRows;

    public int NbColumns {
      get { return _nbColumns; }
      set { _nbColumns = Math.Min(value, MAX_NB_COLUMNS); }
    }

    public int NbRows {
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
      : this(DEFAULT_NB_COLUMNS, DEFAULT_NB_ROWS) {
      // no code
    }

    /// <summary>
    /// designated constructor
    /// </summary>
    /// <param name="paramNbColumns"></param>
    /// <param name="paramNbRows"></param>
    public GoLModel(int paramNbColumns, int paramNbRows) {
      this.NbColumns = paramNbColumns;
      this.NbRows = paramNbRows;

      this.BuildEmptyCellsArray(this.NbColumns, this.NbRows);
    }

    public void FillArrayWithRandomCells() {
      this.FillArrayWithRandomCells(this.Cells);
    }

    public void FillArrayWithRandomCells(Cell[,] paramCells) {
      // random alive cell
      Random rand = new Random();
      for (int i = 0; i < this.NbColumns * this.NbRows / (100 / PERCENTAGE_OF_ALIVE_CELLS_IN_RANDOM); i++) {
        this.SetCell(true, rand.Next(0, this.NbColumns), rand.Next(0, this.NbRows));
      }
    }

    private void BuildEmptyCellsArray(int paramNbColumns, int paramNbRows) {
      this.Cells = new Cell[this.NbColumns, this.NbRows];
      for (int i = 0; i < this.NbColumns; i++) {
        for (int j = 0; j < this.NbRows; j++) {
          this.Cells[i, j] = new Cell();
        }
      }
      for (int i = 0; i < this.NbColumns; i++) {
        for (int j = 0; j < this.NbRows; j++) {
          for (int x = -1; x <= 1; x++) {
            for (int y = -1; y <= 1; y++) {
              if (i + x >= 0 &&
                  i + x < this.NbColumns &&
                  j + y >= 0 &&
                  j + y < this.NbRows) {
                this.Cells[i, j].Neighbours.Add(this.Cells[i + x, j + y]);
              }
            }
            this.Cells[i, j].Neighbours.Remove(this.Cells[i, j]);
          }
        }
      }
    }

    /// <summary>
    /// Build next generation of cells to Conway Game of Life rules
    /// </summary>
    public void BuildNextGeneration() {
      Cell[,] nextGenCells = new Cell[this.NbColumns, this.NbRows];

      // apply rules
      for (int x = 0; x < this.NbColumns; x++) {
        for (int y = 0; y < this.NbRows; y++) {
          nextGenCells[x, y] = new Cell();
          int nbNeighbours = this.Cells[x, y].CountAliveNeighbours();

          // death
          if (this.Cells[x, y].IsAlive &&
              ((nbNeighbours < 2) || (nbNeighbours > 3))
             ) {
            nextGenCells[x, y].Die(); //.IsAlive = false;
          }

          // survive
          if (this.Cells[x, y].IsAlive &&
              ((nbNeighbours == 2) || (nbNeighbours == 3))
             ) {
            nextGenCells[x, y].Live(); //.IsAlive = true;
          }

          // birth
          if (!this.Cells[x, y].IsAlive &&
              (nbNeighbours == 3)
             ) {
            nextGenCells[x, y].Live(); //.IsAlive = true;
          }
        } // end for y
      } // end for x

      for (int i = 0; i < this.NbColumns; i++) {
        for (int j = 0; j < this.NbRows; j++) {
          this.Cells[i, j].State = nextGenCells[i, j].State;
        }
      }
    }

    /// <summary>
    /// Count neightbours of a cell according to Conway Game of Life rules
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public int CountNeighbours(int x, int y) {
      int nbNeighbours = 0;
      for (int i = -1; i <= +1; i++) {
        for (int j = -1; j <= +1; j++) {
          if ((x + i) >= 0 && (x + i) < this.NbColumns &&
              (y + j) >= 0 && (y + j) < this.NbRows) {
            if (this.Cells[x + i, y + j].IsAlive) {
              nbNeighbours += 1;
            }
          }
        }
      }
      if (this.Cells[x, y].IsAlive)
        nbNeighbours -= 1; // a cell is not its own neighbour
      return nbNeighbours;
    }

    public void SetCell(bool paramIsAlive, int x, int y) {
      if (paramIsAlive) {
        this.Cells[x, y].Live();
      } else {
        this.Cells[x, y].Die();
      }
    }

    public Cell GetCell(int x, int y) {
      return this.Cells[x, y];
    }

    public void ClearArrayOfCells() {
      this.BuildEmptyCellsArray(this.NbColumns, this.NbRows);
    }

    public bool[,] GetGridContent() {
      bool[,] gridContent = new bool[this.NbColumns, this.NbRows];
      for (int i = 0; i < this.NbColumns; i++) {
        for (int j = 0; j < this.NbRows; j++) {
          gridContent[i, j] = this.Cells[i, j].IsAlive;
        }
      }
      return gridContent;
    }
  }
}
