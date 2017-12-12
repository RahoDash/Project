/*
 * version 1.0
 * CHAUCHE Benoit
 * MENDEZ Gregory
 * ROSSET Alexandre
 * Date : 02.11.2017 16:06:35
 * 
 * Updated by SILKA Besmir
 * version 2.0
 * 07.11.2017
 **/

using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceGame
{
    public class Die {

        //random
        private static Random _rand = new Random();

        //const
        const int DEFAULT_NB_FACES = 6;
        const int DEFAULT_INDEX_OF_TOP_FACE = 0;

        //fileds
        private int _nbFaces;
        private int _topFace;
        private List<Face> _Faces;
        
        //properties
        public int NbFaces { get => _nbFaces; set => _nbFaces = (value <= 24 && value >= 2) ? value : DEFAULT_NB_FACES; }
        public List<Face> Faces { get => _Faces; set => _Faces = value; }
        private static Random Rand { get => _rand; set => _rand = value; }
        public int TopFace { get => _topFace; set => _topFace = value; }

        //Default constructor
        public Die() : this(DEFAULT_NB_FACES) { }
        
        //Constructor
        public Die(int nbFaces) : this(nbFaces, DEFAULT_INDEX_OF_TOP_FACE) { }
        
        //Constructor
        public Die(int nbFaces, int topFace) : this(nbFaces,topFace, new List<Face>())
        {
            for (int i = 0; i < this.NbFaces; i++)
            {
                this.Faces.Add(new Face((i + 1).ToString()));
            }
        }

        //Designed constructor
        public Die(int nbFaces, int topFace, List<Face> faces)
        {
            this.NbFaces = nbFaces;
            this.TopFace = topFace;
            this.Faces = faces;
        }

        //constructor for only a list of face
        public Die(List<Face> pLstFaces) {
            this.Faces = pLstFaces;
            this.NbFaces = this.Faces.Count();
            this.TopFace = DEFAULT_INDEX_OF_TOP_FACE;
        }

        /// <summary>
        /// Roll the dice form 0 to the number of faces
        /// </summary>
        /// <returns>random number from 0 to number of faces</returns>
        public int Roll() {
            return Die.Rand.Next(0, this.NbFaces);
        }

        /// <summary>
        /// Will get the index of the top face of the die
        /// </summary>
        /// <returns>the index number of the die</returns>
        public Face GetTopFace()
        {
            return this.Faces[this.TopFace];
        }
    }
}
