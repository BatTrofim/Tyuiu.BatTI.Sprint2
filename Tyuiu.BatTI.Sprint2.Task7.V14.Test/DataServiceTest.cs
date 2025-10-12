using Tyuiu.BatTI.Sprint2.Task7.V14.Lib;

namespace Tyuiu.BatTI.Sprint2.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = 0.75;
            var res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
