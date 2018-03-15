using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeV3 {
  public class DeadState : CellState {

    private static DeadState uniqueInstance;
    public override bool IsAlive { get => false; }

    private DeadState() {

    }

    public static DeadState CreateInstance() {

      if (uniqueInstance == null) {
        uniqueInstance = new DeadState();
      }

      return uniqueInstance;
    }

    public override CellState Live() {
      return AliveState.CreateInstance();
    }
    public override CellState Die() {
      return this;
    }
    public override CellState Toggle() {
      return Live();
    }
  }
}
