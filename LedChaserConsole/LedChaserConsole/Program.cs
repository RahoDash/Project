/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : C. Marechal
Description : project for illustrating Decorator Design Pattern
 * File : Program.cs, main file for validating LCCModel
*/
using System;

namespace LedChaserConsole {
  class Program {
    static void PrintLedInfos(string paramInstanceName, Led paramLed) {
      Console.WriteLine("Instance = \"{0,-10}\", Name = \"{1,-21}\", colors = 0x{2:X2}, 0x{3:X2}, 0x{4:X2}",
        paramInstanceName,
        paramLed.Name,
        paramLed.LightColor.Red,
        paramLed.LightColor.Green,
        paramLed.LightColor.Blue);
    }

    static void Main(string[] args) {
      Led aLed = new RectangularLed();
      PrintLedInfos("aLed", aLed);

      Console.WriteLine("--- Decorator validation");
      // add decorators
      aLed = new RedOption(aLed);
      PrintLedInfos("aLed", aLed);

      aLed = new GreenOption(aLed);
      PrintLedInfos("aLed", aLed);

      aLed = new BlueOption(aLed);
      PrintLedInfos("aLed", aLed);
      aLed = new BlueOption(aLed);
      PrintLedInfos("aLed", aLed);

      Console.WriteLine("--- Model validation");
      // instanciate a LCSModel
      LCSModel aModel = new LCSModel(10);

      // first Led is Rectangular + red + green + blue
      int idLed = 0;
      aModel.Chaser[idLed] = new RectangularLed();
      aModel.Chaser[idLed] = new RedOption(aModel.Chaser[idLed]);
      aModel.Chaser[idLed] = new GreenOption(aModel.Chaser[idLed]);
      aModel.Chaser[idLed] = new BlueOption(aModel.Chaser[idLed]);

      // odd Leds are Rounded and red
      // even Leds are green
      for (idLed = 1; idLed < aModel.Chaser.Length - 1; idLed++) {
        aModel.Chaser[idLed] = new RoundLed();
        if ((idLed + 1) % 2 == 0) {
          aModel.Chaser[idLed] = new RedOption(aModel.Chaser[idLed]);
        }
        else {
          aModel.Chaser[idLed] = new GreenOption(aModel.Chaser[idLed]);
        }
      }

      // last Led is Rectangular and red + green + blue
      idLed = aModel.Chaser.Length - 1;
      aModel.Chaser[idLed] = new RectangularLed();
      aModel.Chaser[idLed] = new RedOption(aModel.Chaser[idLed]);
      aModel.Chaser[idLed] = new GreenOption(aModel.Chaser[idLed]);
      aModel.Chaser[idLed] = new BlueOption(aModel.Chaser[idLed]);


      int counterLed = 0;
      foreach (Led item in aModel.Chaser) {
        PrintLedInfos(String.Format("Chaser[{0}]", counterLed++), item);
      }

      // Bonus 1
      //Console.WriteLine("aLed is containing Red color option = {0}", (aLed as OptionDecorator).IsContaining(typeof(RedOption)) ? "yes" : "no");
      //Console.WriteLine("aLed is containing Green color option = {0}", (aLed as OptionDecorator).IsContaining(typeof(GreenOption)) ? "yes" : "no");
      //Console.WriteLine("aLed is containing Blue color option = {0}", (aLed as OptionDecorator).IsContaining(typeof(BlueOption)) ? "yes" : "no");
      //Console.WriteLine("Chaser[1] is containing Blue color option = {0}", (aModel.Chaser[1] as OptionDecorator).IsContaining(typeof(BlueOption)) ? "yes" : "no");
    }
  }
}
