/** 
 * version 1.0
 * CHAUCHE Benoit
 * MENDEZ Gregory
 * ROSSET Alexandre
 * Date : 02.11.2017 16:06:35
 * 
 * Updated by SILKA Besmir
 * version 2.0
 * 07.11.2017
 */

using System;
using System.Windows.Forms;

namespace DiceGame
{
    static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiceGameView());
        }
    }
}
