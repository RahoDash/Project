using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserversSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversSubject.Tests
{
    [TestClass]
    public class ObserverTests
    {
        [TestMethod]
        public void ObserverCtor1Test1()
        {
            Observer target = new Observer();
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void ObserverCtor2Test1()
        {
            Observer target = new Observer(42);
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void ObserverCtor2Test2()
        {
            Observer target = new Observer(42);
            Assert.AreEqual(42, new PrivateObject(target).GetProperty("Id"));
        }
    }
}