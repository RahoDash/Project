/**
 * Title : PlayerUnitTestsWithMoq
 * Author : B.SILKA
 * Date : 15/10/18
 * Description : Simple application of dies game. Application using the frameworks of 
 *               Moq and FluentAssertions for unit tests.
**/

using System;

namespace PlayerUnitTestsWithMoq
{
    public class Die
    {
        const int DEFAULT_NB_OF_FACES = 6;
        const int DEFAULT_TOP_FACE = 1;
        static readonly int[] DEFAULT_FACES = { 1, 2, 3, 4, 5, 6 };

        private int _numberOfFaces;
        private int _topFace;
        private int [] _faces;
        private Random _rnd;

        public int NumberOfFaces { get => _numberOfFaces; set => _numberOfFaces = value; }
        public int TopFace { get => _topFace; set => _topFace = value; }
        private int [] Faces { get => _faces; set => _faces = value; }
        public Random Rnd { get => _rnd; set => _rnd = value; }


        public Die() : this(DEFAULT_NB_OF_FACES, DEFAULT_TOP_FACE, DEFAULT_FACES) { }
        public Die(int nbOfFaces) : this(nbOfFaces, DEFAULT_TOP_FACE, DEFAULT_FACES) { }
        public Die(int nbOfFaces, int topFace) : this(nbOfFaces,topFace,DEFAULT_FACES) { }
        public Die(int nbOfFaces, int topFace, int[] faces)
        {
            this.NumberOfFaces = nbOfFaces;
            this.TopFace = topFace;
            this.Faces = faces;
        }

        public virtual int Roll()
        {
            this.TopFace = Rnd.Next(this.NumberOfFaces - 1);
            
            return this.TopFace;
        }

        public int GetTopFace()
        {
            return this.TopFace;
        }

    }
}
