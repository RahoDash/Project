using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Tests
{
    [TestClass()]
    public class DiceGameModelTests
    {
        [TestMethod()]
        public void DiceGameModelTest()
        {
            DiceGameModel model = new DiceGameModel();
            int nbOfFace = model.Die.Faces.Count();
            Assert.AreEqual(6, nbOfFace);

        }

        [TestMethod()]
        public void DiceGameModelTest1()
        {
            DiceGameModel model = new DiceGameModel(8);
            Assert.AreEqual(8, model.Die.NbFaces);

        }
    }
}