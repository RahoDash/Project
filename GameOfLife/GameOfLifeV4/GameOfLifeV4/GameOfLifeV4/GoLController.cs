/* $Id: GoLController.cs 8128 2018-02-21 21:36:01Z marechal $ */
/* CFPT-EI 03/2016
Project : "Conway Game of Life"
Author : C. Marechal
Description : Controller class (MVC design pattern)
 * - GoLModel : classic implementation with grid and neighbours counting
*/

namespace GameOfLifeV3 {
  class GoLController {
    private const int X_MARGIN = -1;
    private const int Y_MARGIN = -1;

    private frmGoLView View { get; set; }
    private GoLModel Model { get; set; }

    /// <summary>
    ///  Scale? will be used for computing rectangle size for a cell
    /// </summary>
    private float ScaleX { get; set; }
    private float ScaleY { get; set; }

    public int NbMaxColumns { get{ return this.Model.MAX_NB_COLUMNS;} }
    public int NbMaxRows { get{ return this.Model.MAX_NB_ROWS;} }
    public int NbColumns { get { return this.Model.NbColumns; } }
    public int NbRows { get { return this.Model.NbRows; } }

    public GoLController(frmGoLView paramView, int paramNbColumns, int paramNbLines) {
      this.View = paramView;
      this.Model = new GoLModel(paramNbColumns, paramNbLines);
    }

    /// <summary>
    /// Method which build a List of Rectangles from Model data and return it for refreshing the View
    /// </summary>
    /// <returns></returns>
    public bool[,] GetGridContent() {
      return this.Model.GetGridContent();
    }

    public void BuildNextGeneration() {
      this.Model.BuildNextGeneration();
    }

    public void SetCellValue(bool paramIsAlive,int x, int y) {
      this.Model.SetCell(paramIsAlive, x, y);
    }

    public bool GetCellValue(int x, int y) {
      return this.Model.GetCell(x, y).IsAlive;
    }

    public void ClearCells() {
      this.Model.ClearArrayOfCells();
    }

    public void GenerateRandomCells(){
      this.Model.FillArrayWithRandomCells();
    }
  }
}
