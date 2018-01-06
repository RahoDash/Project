/*
 * Author: Benoit CHAUCHE
 * Date: 09.12.2017
 * Project: SnakeGame
 * File: SGModel.cs
 * Project description: a simple SnakeGame.
 * 
 * Updated by : S.Besmir, 19.12.2017, version 2.0 multiviews
 */

using System;
using System.Collections.Generic;
using System.Timers;

namespace SnakeGameMultiViews
{
    public class SGModel : Object
    {
        #region Consts

        private const int SNAKE_SIZE_IN_SQUARE = 4;
        private const int DEFAULT_TIMER_INTERVAL = 200;

        private const int DEFAULT_WIDTH_IN_SQUARES = 20;
        private const int DEFAULT_HEIGHT_IN_SQUARES = 20;
        private const int DEFAULT_DIRECTION = 2;

        #endregion

        #region Fields

        private int _widthInSquares;
        private int _heightInSquares;
        private int _currentDirection;
        private bool _canChangeDirection;
        private Random _rnd;
        private List<SGPoint> _points;
        private SGPoint _food;
        private List<SGView> _views;
        public Timer tmrMain;

        #endregion

        #region Properties

        private int WidthInSquares
        {
            get
            {
                return _widthInSquares;
            }

            set
            {
                _widthInSquares = value;
            }
        }

        private int HeightInSquares
        {
            get
            {
                return _heightInSquares;
            }

            set
            {
                _heightInSquares = value;
            }
        }

        private int CurrentDirection
        {
            get
            {
                return _currentDirection;
            }

            set
            {
                if (this.Points.Count >= 2)
                {
                    if (value >= 1 && value <= 4)
                    {
                        if (value == 1)
                        {
                            if (this.Points[0].Y - 1 != this.Points[1].Y)
                            {
                                _currentDirection = value;
                            }
                        }
                        else if (value == 2)
                        {
                            if (this.Points[0].X + 1 != this.Points[1].X)
                            {
                                _currentDirection = value;
                            }
                        }
                        else if (value == 3)
                        {
                            if (this.Points[0].Y + 1 != this.Points[1].Y)
                            {
                                _currentDirection = value;
                            }
                        }
                        else if (value == 4)
                        {
                            if (this.Points[0].X - 1 != this.Points[1].X)
                            {
                                _currentDirection = value;
                            }
                        }
                    }
                }
                else
                {
                    _currentDirection = value;
                }
            }
        }

        private bool CanChangeDirection
        {
            get
            {
                return _canChangeDirection;
            }

            set
            {
                _canChangeDirection = value;
            }
        }

        private Random Rnd
        {
            get
            {
                return _rnd;
            }

            set
            {
                _rnd = value;
            }
        }

        public List<SGPoint> Points
        {
            get
            {
                return _points;
            }

            set
            {
                _points = value;
            }
        }

        public SGPoint Food
        {
            get
            {
                return _food;
            }

            set
            {
                _food = value;
            }
        }

        public List<SGView> Views { get => _views; set => _views = value; }

        #endregion

        #region Constructors

        public SGModel(int pWidthInSquares, int pHeightInSquares)
        {
            // Init
            this.WidthInSquares = pWidthInSquares;
            this.HeightInSquares = pHeightInSquares;
            this.Rnd = new Random();
            this.Points = new List<SGPoint>();
            this.Food = new SGPoint();
            this.tmrMain = new Timer(DEFAULT_TIMER_INTERVAL);
            this.tmrMain.Elapsed += Tick;
            this.Views = new List<SGView>();
            this.tmrMain.Start();

            // Create snake
            int startPosX = this.Rnd.Next(0, this.WidthInSquares - 1);
            int startPosY = this.Rnd.Next(0, this.HeightInSquares - 1);

            for (int i = 0; i < SNAKE_SIZE_IN_SQUARE; i++)
            {
                this.Points.Add(new SGPoint(startPosX, startPosY));
                this.Points[i].X = startPosX - i;
                this.Points[i].Y = startPosY;
            }

            this.CurrentDirection = DEFAULT_DIRECTION; // Have to be after this.Points initialization

            // Create new food
            this.CreateNewFood();
        }

        public SGModel() : this(DEFAULT_WIDTH_IN_SQUARES, DEFAULT_HEIGHT_IN_SQUARES) { }

        #endregion

        #region Methods

        public void Restart()
        {
            // Init
            this.Rnd = new Random();
            this.Points = new List<SGPoint>();
            this.Food = new SGPoint();
            this.tmrMain.Start();

            // Create snake
            int startPosX = this.Rnd.Next(0, this.WidthInSquares - 1);
            int startPosY = this.Rnd.Next(0, this.HeightInSquares - 1);

            for (int i = 0; i < SNAKE_SIZE_IN_SQUARE; i++)
            {
                this.Points.Add(new SGPoint(startPosX, startPosY));
                this.Points[i].X = startPosX - i;
                this.Points[i].Y = startPosY;
            }

            this.CurrentDirection = DEFAULT_DIRECTION; // Have to be after this.Points initialization

            // Create new food
            this.CreateNewFood();
        }

        public void Move()
        {
            // Save last point, used if food eaten
            int lastPointPosX = this.Points[this.Points.Count - 1].X;
            int lastPointPosY = this.Points[this.Points.Count - 1].Y;

            // Move the queu of the snake
            for (int i = this.Points.Count - 1; i > 0; i--)
            {
                this.Points[i].X = this.Points[i - 1].X;
                this.Points[i].Y = this.Points[i - 1].Y;
            }

            // Move the head of the snake
            switch (this.CurrentDirection)
            {
                case 1:
                    this.Points[0].Y = this.Points[0].Y - 1;
                    break;

                case 2:
                    this.Points[0].X = this.Points[0].X + 1;
                    break;

                case 3:
                    this.Points[0].Y = this.Points[0].Y + 1;
                    break;

                case 4:
                    this.Points[0].X = this.Points[0].X - 1;
                    break;

                default:
                    break;
            }

            // Test if eat food
            if (this.Points[0].Equals(this.Food))
            {
                this.Points.Add(new SGPoint(lastPointPosX, lastPointPosY));
                this.CreateNewFood();
            }
        }

        public bool IsCrossed()
        {
            for (int i = 1; i < this.Points.Count; i++)
            {
                if (this.Points[0].Equals(this.Points[i]))
                {
                    return true;
                }
            }
            
            return false;
        }

        public void SetDirection(int pDirection)
        {
            this.CurrentDirection = pDirection;
        }

        private void CreateNewFood()
        {
            bool overlap = false;
            int posX = 0;
            int posY = 0;

            do
            {
                overlap = false;
                posX = this.Rnd.Next(0, this.WidthInSquares);
                posY = this.Rnd.Next(0, this.HeightInSquares);

                foreach (SGPoint sgp in this.Points)
                {
                    if (sgp.X == posX && sgp.Y == posY)
                    {
                        overlap = true;
                    }
                }

            } while (overlap);

            this.Food.X = posX;
            this.Food.Y = posY;
        }

        /// <summary>
        /// Methods only used for unit test, to remove when better solution found
        /// </summary>
        /// <returns></returns>
        public int MethodForUnitTest_GetDirection()
        {
            return this.CurrentDirection;
        }

        /// <summary>
        /// Methods only used for unit test, to remove when better solution found
        /// </summary>
        /// <returns></returns>
        public void MethodForUnitTest_CreateNewFood()
        {
            this.CreateNewFood();
        }

        private void Tick(object sender, EventArgs e)
        {
            this.Move();
            foreach (var view in Views)
            {
                (view as SGView).UpdateView();
            }
        }


        public void RegisterView(SGView paramView)
        {
            this.Views.Add(paramView);
        }

        public void UnregisterView(SGView paramView)
        {
            this.Views.Remove(paramView);
        }
        #endregion
    }
}
