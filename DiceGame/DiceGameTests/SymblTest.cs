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
    public class SymbolTests
    {
        [TestMethod()]
        public void SymbolTest()
        {
            Symbol target = new Symbol();
            Assert.AreNotEqual("", target.Display());
        }

        [TestMethod()]
        public void SymbolTest1()
        {
            Symbol target = new Symbol();
            Assert.AreEqual("NONE", target.Display());
        }

        [TestMethod()]
        public void SymbolTest2()
        {
            Symbol target = new Symbol("swag");
            Assert.AreEqual("swag", target.Display());
        }

        [TestMethod()]
        public void SymbolTest3()
        {
            Symbol target = new Symbol("1");
            Assert.AreEqual("1", target.Display());
        }
    }
}