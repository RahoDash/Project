/*
 * Author: Benoit CHAUCHE
 * Date: 09.12.2017
 * Project: SnakeGame
 * File: SGPoint.cs
 * Project description: a simple SnakeGame.
 */

using System;

namespace SnakeGameMultiViews
{
    public class SGPoint : Object
    {
        #region Consts

        private const int DEFAULT_X = 0;
        private const int DEFAULT_Y = 0;
        private const int MAX_VALUE_X = 19;
        private const int MAX_VALUE_Y = 19;

        #endregion

        #region Fields

        private int _x;
        private int _y;

        #endregion

        #region Properties

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                if (value < 0)
                {
                    _x = MAX_VALUE_X + (value + 1);
                }
                else if (value > MAX_VALUE_X)
                {
                    _x = 0;
                }
                else
                {
                    _x = value;
                }
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value < 0)
                {
                    _y = MAX_VALUE_Y + (value + 1);
                }
                else if (value > MAX_VALUE_Y)
                {
                    _y = 0;
                }
                else
                {
                    _y = value;
                }
            }
        }

        #endregion

        #region Constructors

        public SGPoint(int pX, int pY)
        {
            this.Set(pX, pY);
        }

        public SGPoint() : this(DEFAULT_X, DEFAULT_Y) { }

        #endregion

        #region Methods

        public void Set(int pX, int pY)
        {
            this.X = pX;
            this.Y = pY;
        }

        public bool Equals(SGPoint point)
        {
            return this.X == point.X && this.Y == point.Y;
        }

        #endregion
    }
}
