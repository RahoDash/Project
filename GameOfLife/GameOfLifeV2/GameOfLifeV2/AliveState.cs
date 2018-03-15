/**
 * Author: SILKA Besmir
 * Version : 1.0
 * Date : 27.02.2018
 * File Descritpion : State of an alive cell
 **/

namespace GameOfLifeV1
{
    class AliveState : CellState
    {
        public AliveState(CellState paramState)
        {
            this.Cell = paramState.Cell;
        }

        public AliveState(bool paramIsAlive)
        {
            this.Cell.IsAlive = paramIsAlive;
        }

        public override bool IsAlive { get; set; }


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
                this.Cell.CellState = new DeadState(this);
            }
        }
    }
}
