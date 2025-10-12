using Tyuiu.BatTI.Sprint2.Task6.V3.Lib;

namespace Tyuiu.BatTI.Sprint2.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int value = 1;
            var res = ds.FindDayName(value);
            string wait = "понедельник";
            Assert.AreEqual(wait, res);
        }
    }
}