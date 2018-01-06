/*
 * Author: Besmir SILKA
 * Date: 19.12.2017
 * Project: SnakeGame
 * File: FormInitViews.cs
 * Project description: a simple SnakeGame.
 */

using System;
using System.Windows.Forms;

namespace SnakeGameMultiViews
{
    public partial class FormInitViews : Form
    {
        private const string DEFAULT_NAME = "SNAKE";
        private int counter = 1;

        public SGModel Model { get; set; }

        public FormInitViews()
        {
            InitializeComponent();
            this.Model = new SGModel();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumUDViews.Value; i++)
            {
                new SGView(DEFAULT_NAME + counter++, this.Model).Show();
            }
        }
    }
}
