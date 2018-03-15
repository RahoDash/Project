/* $Id: GoLModelTests.cs 8128 2018-02-21 21:36:01Z marechal $ */
/* CFPT-EI 03/2016
Project : "Conway Game of Life"
Author : C. Marechal
Description : Model unit tests class
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GameOfLifeV3.Tests {
  [TestClass()]
  public class GoLModelTests {
    
    /// <summary>
    /// each unit test initialize a model with 3 x 3 = 9 cells.
    /// It calls 1, 2 or 3 times the BuildNextGeneration method
    /// Sucessive generations are checked with Assert.AreEqual() function calls.
    /// </summary>
    [TestMethod()]
    public void GoLModelTest1() {
      /*  ..*       ...       
       *  .*.  -->  .**  -->  nothing
       *  .*.       ...
       * 
       */
      GoLModel model = new GoLModel();
      model.SetCell(true, 2, 0);
      model.SetCell(true, 1, 1);
      model.SetCell(true, 1, 2);
      
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);
    }

    [TestMethod()]
    public void GoLModelTest2() {
      /*  .*.       ...       .*.
       *  .*.  -->  ***  -->  .*.  --> repeat
       *  .*.       ...       .*. 
       * 
       */
      GoLModel model = new GoLModel();
      model.SetCell(true, 1, 0);
      model.SetCell(true, 1, 1);
      model.SetCell(true, 1, 2);

      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);
    }

    [TestMethod()]
    public void GoLModelTest3() {
      /*  **.       **.       **.
       *  *..  -->  **.  -->  **.  --> stable
       *  ...       ...       ... 
       * 
       */
      GoLModel model = new GoLModel();
      model.SetCell(true, 0, 0);
      model.SetCell(true, 0, 1);
      model.SetCell(true, 1, 0);

      Assert.AreEqual(true, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(true, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(true, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);
    }

    [TestMethod()]
    public void GoLModelTest4() {
      /*  ..*       ...
       *  .*.  -->  .*.  -->  nothing
       *  *..       ...
       * 
       */
      GoLModel model = new GoLModel();
      model.SetCell(true, 0, 2);
      model.SetCell(true, 1, 1);
      model.SetCell(true, 2, 0);

      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);
    }

    [TestMethod()]
    public void GoLModelTest5() {
      /* cells on the first column */
      /*  *..       ...
       *  *..  -->  **.  -->  empty
       *  *..       ...
       * 
       */
      GoLModel model = new GoLModel();
      model.SetCell(true, 0, 0);
      model.SetCell(true, 0, 1);
      model.SetCell(true, 0, 2);

      Assert.AreEqual(true, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);
    }

    [TestMethod()]
    public void GoLModelTest6() {
      /* cells on the first row */
      /*  ***       .*.
       *  ...  -->  .*.  -->  empty
       *  ...       ...
       * 
       */
      GoLModel model = new GoLModel();
      model.SetCell(true, 0, 0);
      model.SetCell(true, 1, 0);
      model.SetCell(true, 2, 0);

      Assert.AreEqual(true, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(true, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);

      model.BuildNextGeneration();
      Assert.AreEqual(false, model.Cells[0, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[0, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[1, 2].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 0].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 1].IsAlive);
      Assert.AreEqual(false, model.Cells[2, 2].IsAlive);
    }
    [TestMethod()]
    public void GoLModelTest7() {
      /*  **.       **.       **.
       *  *..  -->  **.  -->  **.  --> stable
       *  ...       ...       ... 
       * 
       */

      // Checks the reference of the singleton AliveState
      GoLModel model = new GoLModel();
      model.SetCell(true, 0, 0);
      model.SetCell(true, 0, 1);
      model.SetCell(true, 1, 0);

      Assert.AreEqual(model.Cells[0, 0].State.GetHashCode(),
                      model.Cells[0, 1].State.GetHashCode());
    }

    [TestMethod()]
    public void GoLModelTest8() {
      /*  **.       **.       **.
       *  *..  -->  **.  -->  **.  --> stable
       *  ...       ...       ... 
       * 
       */

      // Checks the reference of the singleton DeadState
      GoLModel model = new GoLModel();
      model.SetCell(false, 0, 0);
      model.SetCell(false, 0, 1);
      model.SetCell(false, 1, 0);

      Assert.AreEqual(model.Cells[0, 0].State.GetHashCode(),
                      model.Cells[0, 1].State.GetHashCode());
    }

  }
}
