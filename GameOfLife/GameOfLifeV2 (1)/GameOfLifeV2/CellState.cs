/**
 * Author: SILKA Besmir
 * Version : 1.0
 * Date : 27.02.2018
 * File Descritpion : Abstract state for cellstate
 **/

namespace GameOfLifeV1
{
    public abstract class CellState
    {
        public Cell Cell { get; set; }
        public abstract bool IsAlive { get; set; }
        public abstract void Live();
        public abstract void Die();
        public abstract void Toggle();
    }
}
