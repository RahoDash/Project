/**
 * Author: SILKA Besmir
 * Version : 1.0
 * Date : 27.02.2018
 * File Descritpion : State of a dead cell
 **/

using System;
using System.Windows.Forms;

namespace GameOfLifeV1 {
  static class Program {
    /// <summary>
    /// Point d'entrée principal de l'application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmGoLView(new GoLModel()));
    }
  }
}
