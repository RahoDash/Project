using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeV3 {
  public abstract class CellState {
    public abstract bool IsAlive { get; }
    public abstract CellState Live();
    public abstract CellState Die();
    public abstract CellState Toggle();
  }
}
