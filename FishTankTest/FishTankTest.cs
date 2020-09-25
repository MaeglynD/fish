using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;

namespace FishTankTest
{
    [TestClass]
    public class FishTests
    {
        // Didn't include many tests, but i think you get the point

        [TestMethod]
        public void EmtpyTank()
        {
            Tank fishTank = new Tank();

            Assert.AreEqual(0, fishTank.Feed());
        }

        [TestMethod]
        public void FullTank()
        {
            Tank fishTank = new Tank();

            fishTank.AddFish(new Angel("Angel name"));
            fishTank.AddFish(new Gold("Gold name"));
            fishTank.AddFish(new Babel("Babel name"));

            Assert.AreEqual(3, fishTank.Fish.Count);
            Assert.AreEqual(0.1 + 0.2 + 0.3, fishTank.Feed());
        }
    }
}
