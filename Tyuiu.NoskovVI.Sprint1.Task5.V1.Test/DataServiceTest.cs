using Tyuiu.NoskovVI.Sprint1.Task5.V1.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DotsTest()
        {
            DataService ds = new DataService();
            double x1, x2, y1, y2;
            x1 = 5;
            x2 = 2;
            y1 = 3;
            y2 = 1;
            double res = 4;
            Assert.AreEqual(res, ds.DistanceBetweenDots(x1, y1, x2, y2));
        }
    }
}