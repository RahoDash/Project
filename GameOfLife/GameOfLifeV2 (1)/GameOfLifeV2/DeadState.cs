/**
 * Author: SILKA Besmir
 * Version : 1.0
 * Date : 27.02.2018
 * File Descritpion : State of a dead cell
 **/

namespace GameOfLifeV1
{
    class DeadState : CellState
    {
        public DeadState(CellState paramState): this(paramState.Cell)
        {
            this.Cell = paramState.Cell;
        }

        public DeadState(Cell paramCell)
        {
            this.Cell = paramCell;
        }

        public override bool IsAlive { get ; set ; }

        public override void Die()
        {
            this.Cell.IsAlive = false;
            Toggle();
        }

        public override void Live()
        {
            this.Cell.IsAlive = true;
            Toggle();
        }

        public override void Toggle()
        {
            if (!this.Cell.IsAlive)
            {
                this.Cell.CellState = new AliveState(this);
            }
        }
    }
}
