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
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGameMultiViews
{
    public partial class SGView : Form
    {
        #region Consts

        private const int DEFAULT_WIDTH_IN_SQUARES = 20;
        private const int DEFAULT_HEIGHT_IN_SQUARES = 20;

        #endregion

        #region Fields

        private SGModel _model;

        #endregion

        #region Properties

        public SGModel Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        Image image = null;
        Graphics graphicsFromImage = null;
        Graphics graphicsFromPictureBox = null;

        #endregion

        #region Constructors


        public SGView(string pName, SGModel pModel)
        {
            InitializeComponent();
            this.Model = pModel;


            this.Model.Views.Add(this);

        }

        #endregion

        #region Methods

        private void SGView_Load(object sender, EventArgs e)
        {
            this.UpdateView();
        }

        private void SGView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.Model.SetDirection(1);
            }
            else if (e.KeyCode == Keys.Right)
            {
                this.Model.SetDirection(2);
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.Model.SetDirection(3);
            }
            else if (e.KeyCode == Keys.Left)
            {
                this.Model.SetDirection(4);
            }
        }

        public void UpdateView()
        {
            image = new Bitmap(pictureBoxGameArea.Width, pictureBoxGameArea.Height);
            graphicsFromImage = Graphics.FromImage(image);
            graphicsFromPictureBox = pictureBoxGameArea.CreateGraphics();

            // Init
            int gameWidthInPixels = pictureBoxGameArea.Width, gameHeightInPixels = pictureBoxGameArea.Height;
            const int offsetInsideSquare = 2; // Padding for snake's squares

            Pen pen = new Pen(Color.LightGray, 1);
            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush brushBody = new SolidBrush(Color.Black);
            SolidBrush brushHead = new SolidBrush(Color.Green);
            SolidBrush brushFood = new SolidBrush(Color.Red);

            graphicsFromImage.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, gameWidthInPixels, gameHeightInPixels));

            // DRAW FIELD

            // Draw columns
            int posX = 0;
            for (int i = 0; i <= DEFAULT_WIDTH_IN_SQUARES; i++)
            {
                posX = (gameWidthInPixels / DEFAULT_WIDTH_IN_SQUARES) * i;
                graphicsFromImage.DrawLine(pen, posX, 0, posX, gameHeightInPixels);
            }

            // Draw lines
            int posY = 0;
            for (int i = 0; i <= DEFAULT_HEIGHT_IN_SQUARES; i++)
            {
                posY = (gameHeightInPixels / DEFAULT_HEIGHT_IN_SQUARES) * i;
                graphicsFromImage.DrawLine(pen, 0, posY, gameWidthInPixels, posY);
            }

            // DRAW SNAKE
            int pX = 0, pY = 0, sizeX = 0, sizeY = 0;
            for (int i = 0; i < this.Model.Points.Count; i++)
            {
                pX = this.Model.Points[i].X * (gameWidthInPixels / DEFAULT_WIDTH_IN_SQUARES) + offsetInsideSquare;
                pY = this.Model.Points[i].Y * (gameHeightInPixels / DEFAULT_HEIGHT_IN_SQUARES) + offsetInsideSquare;
                sizeX = gameWidthInPixels / DEFAULT_WIDTH_IN_SQUARES - (offsetInsideSquare + 1);
                sizeY = gameHeightInPixels / DEFAULT_HEIGHT_IN_SQUARES - (offsetInsideSquare + 1);

                graphicsFromImage.FillRectangle(i == 0 ? brushHead : brushBody, pX, pY, sizeX, sizeY);
            }

            // DRAW FOOD
            pX = this.Model.Food.X * (gameWidthInPixels / DEFAULT_WIDTH_IN_SQUARES);
            pY = this.Model.Food.Y * (gameHeightInPixels / DEFAULT_HEIGHT_IN_SQUARES);
            sizeX = gameWidthInPixels / DEFAULT_WIDTH_IN_SQUARES;
            sizeY = gameHeightInPixels / DEFAULT_HEIGHT_IN_SQUARES;
            graphicsFromImage.FillEllipse(brushFood, pX, pY, sizeX, sizeY);

            // DRAW STRING
            // Create string to draw.
            String drawString = "Snake Size : " + this.Model.Points.Count;

            // Create font and brush.
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x = 1.0F;
            float y = 1.0F;
            float width = 100.0F;
            float height = 15.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Black, 1);
            graphicsFromImage.DrawRectangle(blackPen, x, y, width, height);

            // Set format of string.
            StringFormat drawFormat = new StringFormat
            {
                Alignment = StringAlignment.Center
            };

            // Draw string to screen.
            graphicsFromImage.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

            // DRAW ON THE FORM
            graphicsFromPictureBox.DrawImage(image, 0, 0);
            pictureBoxGameArea.Image = image;

            // Test if snake is crossed
            if (this.Model.IsCrossed())
            {
                this.Model.tmrMain.Stop();
                DialogResult dialogResult = MessageBox.Show("You Snake is " + this.Model.Points.Count + " blocks long! Do you want to retry?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Model.Restart();
                    this.UpdateView();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        #endregion

        private void SGView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Model.UnregisterView(this);
        }
    }
}
