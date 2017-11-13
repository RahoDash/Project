using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ResistorCalculator.Tests
{
    [TestClass()]
    public class RCModelTests
    {
        //[TestMethod()]
        //public void RCModelTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void RCModelTest1()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void ConvertFromColorBandsTest1()
        {
            RCModel rc = new RCModel();
            double target = rc.ConvertFromColorBands(0, 0, 0, 0);
            Assert.AreEqual(0.0, target);
        }

        [TestMethod()]
        public void ConvertFromColorBandsTest2()
        {
            RCModel rc = new RCModel();
            double target = rc.ConvertFromColorBands(4, 3, 2, 1);
            Assert.AreEqual(4320.0, target);
        }

        [TestMethod()]
        public void ConvertFromColorBandsTest3()
        {
            RCModel rc = new RCModel();
            double target = rc.ConvertFromColorBands(4, 5, 6, 7);
            Assert.AreEqual(456.0e7, target);
        }

        [TestMethod()]
        public void ConvertFromColorBandsTest4()
        {
            RCModel rc = new RCModel();
            double target = rc.ConvertFromColorBands(9, 8, 7, 3);
            Assert.AreEqual(987.0e3, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest1()
        {
            RCModel rc = new RCModel(123);
            double target = rc.GetNearestStandardValue(123, 24);
            Assert.AreEqual(120, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest2()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(10833, 24);
            Assert.AreEqual(10000, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest3()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(10833, 48);
            Assert.AreEqual(10500, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest4()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(10833, 96);
            Assert.AreEqual(10700, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest5()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(9999, 24);
            Assert.AreEqual(9100, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest6()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(9999, 192);
            Assert.AreEqual(9880, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest7()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(0, 24);
            Assert.AreEqual(0, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest8()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(0.52, 24);
            Assert.AreEqual(0.51, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest9()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(0.52, 48);
            Assert.AreEqual(0.511, target);
        }

        [TestMethod()]
        public void GetNearestStandardValueTest10()
        {
            RCModel rc = new RCModel();
            double target = rc.GetNearestStandardValue(0.52, 192);
            Assert.AreEqual(0.517, target);
        }
    }
}