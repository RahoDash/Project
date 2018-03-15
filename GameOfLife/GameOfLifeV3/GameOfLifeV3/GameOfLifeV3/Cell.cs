/* $Id: Cell.cs 8128 2018-02-21 21:36:01Z marechal $ */
/* CFPT-EI 03/2016
Project : "Conway Game of Life"
Author : C. Marechal
Description : class for a cell
*/
using System.Collections.Generic;

namespace GameOfLifeV3 {
  public class Cell {
    private const bool DEFAULT_CELL_STATE = false;
    private List<Cell> _neighbours;
    public bool IsAlive { get => State.IsAlive; }
    public List<Cell> Neighbours { get => _neighbours; set => _neighbours = value; }

    private CellState _state;

    public CellState State { get => _state; set => _state = value; }

    public Cell()
      : this(DEFAULT_CELL_STATE) {
      // no code
    }

    /// <summary>
    /// designated constructor
    /// </summary>
    /// <param name="paramIsAlive"></param>
    public Cell(bool paramIsAlive) {
      this.State = (paramIsAlive) ? AliveState.CreateInstance() as CellState : DeadState.CreateInstance() as CellState;
      this.Neighbours = new List<Cell>();
    }

    public int CountAliveNeighbours() {
      int nbCellsAlive = 0;
      foreach (Cell c in this.Neighbours) {
        if (c.IsAlive)
          nbCellsAlive++;
      }
      return nbCellsAlive;
    }

    public void Live() {
      this.State = State.Live();
    }
    public void Die() {
      this.State = State.Die();
    }
    public void Toggle() {
      this.State = State.Toggle();
    }
  }
}
