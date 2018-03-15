/* $Id: frmGoLView.cs 8128 2018-02-21 21:36:01Z marechal $ */
/* CFPT-EI 03/2016
Project : "Conway Game of Life"
Author : C. Marechal
Description : View class (MVC design pattern)
*/
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace GameOfLifeV3 {
  public partial class frmGoLView : Form {
    private const int MIN_NB_COLUMNS = 3;
    private const int MIN_NB_ROWS = 3;
    private readonly Color CELL_FILL_COLOR = Color.Blue;
    private readonly Color GRID_DRAW_COLOR = Color.Gray;

    private GoLController Controller { get; set; }

    public Panel PnlCellsArea {
      get { return pnlCellsArea; }
      set { pnlCellsArea = value; }
    }

    /// <summary>
    /// designated constructor
    /// </summary>
    public frmGoLView() {
      InitializeComponent();
      // workaround for setting DoubleBuffered property of Panel class, property which is protected.
      typeof(Panel).InvokeMember("DoubleBuffered",
        BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
        null,
        pnlCellsArea,
        new object[] { true });
      this.Controller = new GoLController(this, (int)nudNbColumns.Value, (int)nudNbRows.Value);
    }

    private void frmGoLView_Load(object sender, EventArgs e) {
      this.nudNbColumns.Maximum = this.Controller.NbMaxColumns;
      this.nudNbRows.Maximum = this.Controller.NbMaxRows;
      this.nudNbColumns.Minimum = MIN_NB_COLUMNS;
      this.nudNbRows.Minimum = MIN_NB_ROWS;

      this.tbCycle.Value = this.tbCycle.Maximum / 2;
      this.timer1.Interval = (int)(1000 / tbCycle.Value);
    }

    // Buttons events for driving user interface
    private void btnStep_Click(object sender, EventArgs e) {
      this.Controller.BuildNextGeneration();
      this.pnlCellsArea.Invalidate();
    }

    private void btnTimerStartStop_Click(object sender, EventArgs e) {
      timer1.Enabled = !timer1.Enabled;
      btnTimerStartStop.Text = timer1.Enabled == true ? "Stop" : "Start";
    }

    private void btnClear_Click(object sender, EventArgs e) {
      this.Controller.ClearCells();
      this.pnlCellsArea.Invalidate();
    }

    private void btnRandom_Click(object sender, EventArgs e) {
      this.Controller.GenerateRandomCells();
      this.pnlCellsArea.Invalidate();
    }

    private void tbCycle_Scroll(object sender, EventArgs e) {
      this.timer1.Interval = (int)(1000 / tbCycle.Value);
    }

    /// <summary>
    /// event (triggered by the timer)
    /// Simulate a Step button click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Tick(object sender, EventArgs e) {
      btnStep.PerformClick();
    }

    /// <summary>
    /// event for cell input from mouse
    /// Mouse coordinates are translated in Cell position for the Controller
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pnlCellsArea_MouseClick(object sender, MouseEventArgs e) {
      int xCell = e.X / (pnlCellsArea.Width / this.Controller.NbColumns);
      int yCell = e.Y / (pnlCellsArea.Height / this.Controller.NbRows);
      bool cellState = this.Controller.GetCellValue(xCell, yCell);
      this.Controller.SetCellValue(!cellState, xCell, yCell);
      (sender as Panel).Invalidate();
    }

    /// <summary>
    /// event for drawing  in the panel : 
    /// - grid
    /// - cells
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pnlCellsArea_Paint(object sender, PaintEventArgs e) {
      Graphics g = e.Graphics;
      Panel panel = (sender as Panel);

      // draw grid
      Pen pen = new Pen(GRID_DRAW_COLOR);
      // fill cells
      SolidBrush fillColorBrush = new SolidBrush(CELL_FILL_COLOR);

      int columnsWidthPixels = panel.Width / this.Controller.NbColumns;
      int rowHeightPixels = panel.Height / this.Controller.NbRows;

      // draw vertical lines
      for (int x = 0; x < panel.Width; x += columnsWidthPixels) {
        g.DrawLine(pen, x, 0, x, panel.Height);
      }

      // draw horizontal lines
      for (int y = 0; y < panel.Height; y += rowHeightPixels) {
        g.DrawLine(pen, 0, y, panel.Width, y);
      }

      // fill alive cells
      SolidBrush solidBrush = new SolidBrush(Color.Blue);
      bool[,] gridContent = this.Controller.GetGridContent();
      for (int i = 0; i < this.Controller.NbColumns; i++) {
        for (int j = 0; j < this.Controller.NbRows; j++) {
          if (gridContent[i, j]) {
            g.FillRectangle(fillColorBrush, i * columnsWidthPixels + 1, j * rowHeightPixels + 1, columnsWidthPixels - 1, rowHeightPixels - 1);
          }
        }
      }
    }

    private void pnlCellsArea_Resize(object sender, EventArgs e) {
      (sender as Panel).Invalidate();
    }

    /// <summary>
    /// new geometry of the grid (width or/and height) needs to generate  new Controller/Model objects
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void nudGeneric_ValueChanged(object sender, EventArgs e) {
      this.Controller = new GoLController(this, (int)nudNbColumns.Value, (int)nudNbRows.Value);
      this.pnlCellsArea.Invalidate();
    }
  }
}
