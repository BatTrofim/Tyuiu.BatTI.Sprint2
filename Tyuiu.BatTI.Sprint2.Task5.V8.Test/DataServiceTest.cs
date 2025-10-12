using Tyuiu.BatTI.Sprint2.Task5.V8.Lib;

namespace Tyuiu.BatTI.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int m = 11;
            int n = 29;
            var res = ds.FindDateOfPreviousDay(m, n);
            string wait = "28.11";
            Assert.AreEqual(wait, res);
        }
    }
}
