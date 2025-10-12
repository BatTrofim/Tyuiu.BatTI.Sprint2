using Tyuiu.BatTI.Sprint2.Task4.V16.Lib;

namespace Tyuiu.BatTI.Sprint2.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);

        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = -1;
            Assert.AreEqual(wait, res);

        }
    }
}
