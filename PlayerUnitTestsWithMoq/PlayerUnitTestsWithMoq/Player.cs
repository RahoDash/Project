/**
 * Title : PlayerUnitTestsWithMoq
 * Author : B.SILKA
 * Date : 15/10/18
 * Description : Simple application of dies game. Application using the frameworks of 
 *               Moq and FluentAssertions for unit tests.
**/

namespace PlayerUnitTestsWithMoq
{
    public class Player
    {
        private Die _die;

        public Die Die { get => _die; set => _die = value; }

        public Player() : this(new Die())
        {
        }
        public Player(Die pDie)
        {
            this.Die = pDie;
        }

        public int Throw()
        {
            return this.Die.Roll();
        }

        public int GetTopFaceNumber()
        {
            return this.Die.GetTopFace();
        }
    }
}
