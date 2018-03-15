using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeV3 {
  public class AliveState : CellState {

    private static AliveState uniqueInstance;
    public override bool IsAlive { get => true; }

    private AliveState() {

    }
    public static AliveState CreateInstance() {
      if (uniqueInstance == null) {
        uniqueInstance = new AliveState();
      }

      return uniqueInstance;
    }

    public override CellState Live() {
      return this;
    }
    public override CellState Die() {
      return DeadState.CreateInstance();
    }
    public override CellState Toggle() {
      return Die();
    }
  }
}
