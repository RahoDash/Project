/*
 * CHAUCHE Benoit
 * MENDEZ Gregory
 * ROSSET Alexandre
 * Date : 02.11.2017 16:06:35
 **/

using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceGame {
    public class Die {

        private static Random _rand = new Random();

        const int DEFAULT_NB_FACES = 6;
        const int DEFAULT_TOP_FACE = 1;
        private int _nbFaces;
        private int _topFace;
        private List<Face> _Faces;
        

        public int NbFaces { get => _nbFaces; set => _nbFaces = (value <= 24 && value >= 2) ? value : DEFAULT_NB_FACES; }
        public List<Face> Faces { get => _Faces; set => _Faces = value; }
        private static Random Rand { get => _rand; set => _rand = value; }
        public int TopFace { get => _topFace; set => _topFace = value; }

        public Die() : this(DEFAULT_NB_FACES) { }
        
        public Die(int nbFaces) : this(nbFaces, DEFAULT_TOP_FACE) { }
        

        public Die(int nbFaces, int topFace) : this(nbFaces,topFace, new List<Face>())
        {
            for (int i = 0; i < this.NbFaces; i++)
            {
                this.Faces.Add(new Face((i + 1).ToString()));
            }
        }

        public Die(int nbFaces, int topFace, List<Face> faces)
        {
            this.NbFaces = nbFaces;
            this.TopFace = topFace;
            this.Faces = faces;
        }

        public Die(List<Face> pLstFaces) {
            this.Faces = pLstFaces;
            this.NbFaces = this.Faces.Count();
            this.TopFace = DEFAULT_TOP_FACE;
        }

        public int Roll() {
            return Die.Rand.Next(0, this.NbFaces);
        }

        public Face GetTopFace()
        {
            this.TopFace = this.Roll();
            return this.Faces[this.TopFace];
        }
    }
}
