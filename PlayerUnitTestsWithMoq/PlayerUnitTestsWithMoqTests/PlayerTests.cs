/**
 * Title : PlayerUnitTestsWithMoq
 * Author : B.SILKA
 * Date : 15/10/18
 * Description : Simple application of dies game. Application using the frameworks of 
 *               Moq and FluentAssertions for unit tests.
**/

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace PlayerUnitTestsWithMoq.Tests
{
    [TestClass()]
    public class PlayerTests
    {

        Mock<Die> mock = new Mock<Die>();

        /// <summary>
        /// Test if player object is instentied
        /// </summary>
        [TestMethod()]
        public void PlayerTest1()
        {
            Player player = new Player(mock.Object);

            Assert.IsNotNull(player);
        }


        /// <summary>
        /// Test if the method Throw() will return 6
        /// </summary>
        [TestMethod()]
        public void PlayerTest2()
        {
            this.mock.Setup(x => x.Roll()).Returns(6);

            Player player = new Player(mock.Object);

            Assert.AreEqual(6,player.Throw());
        }


        /// <summary>
        /// test if the methode Roll() of the mockup Die is called one time
        /// </summary>
        [TestMethod]
        public void PlayerTest3()
        {
            Player player = new Player(this.mock.Object);

            player.Throw();

            this.mock.Verify(x => x.Roll(), Times.Once());
        }


        /// <summary>
        /// Test if the sequence is returned
        /// </summary>
        [TestMethod]
        public void PlayerTest4()
        {
            this.mock.SetupSequence(x => x.Roll()).Returns(6).Returns(5).Returns(4).Returns(3);

            Player player = new Player(this.mock.Object);

            Assert.AreEqual(6, player.Throw());
            Assert.AreEqual(5, player.Throw());
            Assert.AreEqual(4, player.Throw());
            Assert.AreEqual(3, player.Throw());

            //this.mock.Verify(x => x.Roll(), Times.Exactly(4));
        }


        /// <summary>
        /// Test if player object is instentied
        /// With FluentAssertions
        /// </summary>
        [TestMethod()]
        public void PlayerTest1bis()
        {
            Player player = new Player(mock.Object);

            player.Should().NotBeNull();
        }


        /// <summary>
        /// Test if the method Throw() will return 6
        /// With FluentAssertions
        /// </summary>
        [TestMethod()]
        public void PlayerTest2bis()
        {
            this.mock.Setup(x => x.Roll()).Returns(6);

            Player player = new Player(mock.Object);

            player.Throw().Should().Be(6);
        }

        /// <summary>
        /// test if the methode Roll() of the mockup Die is called one time
        /// With FluentAssertions
        /// </summary>
        [TestMethod]
        public void PlayerTest3bis()
        {
            int count = 0;
            this.mock.Setup(x => x.Roll()).Callback(() => count++);

            Player player = new Player(this.mock.Object);

            player.Throw();

            count.Should().Be(1);
        }


        /// <summary>
        /// Test if the sequence is returned
        /// With FluentAssertions
        /// </summary>
        [TestMethod]
        public void PlayerTest4bis()
        {
            this.mock.SetupSequence(x => x.Roll()).Returns(6).Returns(5).Returns(4).Returns(3);

            Player player = new Player(this.mock.Object);

            player.Throw().Should().Be(6);
            player.Throw().Should().Be(5);
            player.Throw().Should().Be(4);
            player.Throw().Should().Be(3);

            this.mock.Verify(x => x.Roll(), Times.Exactly(4));
        }
    }
}