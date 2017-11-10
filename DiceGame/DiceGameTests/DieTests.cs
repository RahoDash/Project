using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Tests {

    public class MockFace : Face {
        public MockFace(string symbol) : base(symbol) {
        }
    }

    [TestClass()]
    public class DieTests {
        [TestMethod()]
        public void DieTest() {

            Die die = new Die(2);

            int target = die.NbFaces;
            int nbFaceInList = die.Faces.Count();

            Assert.AreEqual(2, nbFaceInList);
            Assert.AreEqual(2, target);
        }

        [TestMethod()]
        public void DieTest1() {

            Die die = new Die(1);

            int target = die.NbFaces;
            int nbFaceInList = die.Faces.Count();

            Assert.AreEqual(6, nbFaceInList);
            Assert.AreEqual(6, target);
        }

        [TestMethod()]
        public void DieTest2() {

            Die die = new Die(25);

            int target = die.NbFaces;
            int nbFaceInList = die.Faces.Count();

            Assert.AreEqual(6, nbFaceInList);
            Assert.AreEqual(6, target);
        }

        [TestMethod()]
        public void DieTest3() {
            Die die = new Die(new List<Face>() { new MockFace("1"), new MockFace("2") });
            Assert.AreNotEqual(null, die);
        }

        [TestMethod()]
        public void DieTest4() {
            Die die = new Die(new List<Face>() { new MockFace("1"), new MockFace("2") });
            Assert.AreEqual(2, die.NbFaces);
        }

        [TestMethod()]
        public void DieTest5() {
            Die die = new Die(new List<Face>() { new MockFace("10"), new MockFace("20") });
            Assert.AreEqual("10", die.Faces[0].Symbol);
            Assert.AreEqual("20", die.Faces[1].Symbol);
        }

        [TestMethod()]
        public void RollTest() {

            Die die = new Die(6);
            bool[] foundFaces = new bool[6];
            int i = 0;

            while(i < 1000) 
            {

                foundFaces[die.Roll()] = true;

                i++;
            }
            
            for(int j = 0; j < foundFaces.Count(); j++) 
            {
                Assert.AreEqual(true, foundFaces[j]);
            }
            
        }

        [TestMethod()]
        public void RollMultipleDieTest() {

            Die die1 = new Die(6);
            Die die2 = new Die(6);

            int i = 0;
            int foundDraw = 0;

            while (i < 1000) {

                if(die1.Roll() == die2.Roll()) {
                    foundDraw++;
                }

                i++;
            }

            Assert.AreNotEqual(1000, foundDraw);

        }

        [TestMethod()]
        public void DieTest6()
        {
            Die die = new Die(9, 5);
            Assert.AreEqual(5, die.TopFace);
            Assert.AreEqual(9, die.NbFaces);
        }

        [TestMethod()]
        public void DieTest7()
        {
            Die die = new Die(9, 5);
            string target = die.GetTopFace().Symbol;
            Assert.AreEqual(5, die.TopFace);
            Assert.AreEqual(target, die.Faces[5].Symbol);
        }
    }
}