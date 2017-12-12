using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Tests {
    [TestClass()]
    public class FaceTests {

        [TestMethod()]
        public void FaceTest() {
            Face face = new Face("2");

            Assert.AreEqual("2", face.Symbol);
        }
    }
}