using Tyuiu.NoskovVI.Sprint1.Task2.V26.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MinutesValid()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 59;
            var res = ds.CalculateMinutesSinceStart(value, valueTwo);
            Assert.AreEqual(179, res);
        }
    }
}