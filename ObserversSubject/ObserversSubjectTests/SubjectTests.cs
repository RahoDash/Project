using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserversSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversSubject.Tests
{
    public class MockObserver : Observer
    {
        public bool WasUpdated { get; private set; }

        public override void UpdateObserver() => this.WasUpdated = true;
    }

    [TestClass]
    public class SubjectTests
    {
        [TestMethod]
        public void SubjectCtorTest1()
        {
            Subject target = new Subject();
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void SubjectCtorTest2()
        {
            Subject target = new Subject();
            Assert.IsNotNull(new PrivateObject(target).GetProperty("Observers"));
        }

        [TestMethod]
        public void SubjectRegisterObserverTest1()
        {
            object someObserver = new object();

            Subject target = new Subject();
            target.RegisterObserver(someObserver);

            Assert.IsTrue((new PrivateObject(target).GetProperty("Observers") as List<object>).Contains(someObserver));
        }

        [TestMethod]
        public void SubjectRegisterObserverTest2()
        {
            Subject target = new Subject();
            target.RegisterObserver(null);

            Assert.AreEqual(0, (new PrivateObject(target).GetProperty("Observers") as List<object>).Count);
        }

        [TestMethod]
        public void SubjectUnregisterObserverTest1()
        {
            object someObserver = new object();

            Subject target = new Subject();
            target.RegisterObserver(someObserver);
            target.UnregisterObserver(someObserver);

            Assert.IsFalse((new PrivateObject(target).GetProperty("Observers") as List<object>).Contains(someObserver));
        }

        [TestMethod]
        public void SubjectUpdateObserversTest1()
        {
            MockObserver observer = new MockObserver();

            Subject target = new Subject();
            target.RegisterObserver(observer);

            new PrivateObject(target).Invoke("UpdateObservers");

            Assert.IsTrue(observer.WasUpdated);
        }

        [TestMethod]
        public void SubjectRateChangeTest1()
        {
            MockObserver observer = new MockObserver();

            Subject target = new Subject();
            target.RegisterObserver(observer);

            target.Rate += 0.42;

            Assert.IsTrue(observer.WasUpdated);
        }

        [TestMethod]
        public void SubjectRateChangeTest2()
        {
            MockObserver observer = new MockObserver();

            Subject target = new Subject();
            target.RegisterObserver(observer);

            target.Rate += 0.05;

            Assert.IsFalse(observer.WasUpdated);
        }
    }
}