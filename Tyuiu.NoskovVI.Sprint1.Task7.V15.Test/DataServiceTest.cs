using Tyuiu.NoskovVI.Sprint1.Task7.V15.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalc()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = 0.539;
            Assert.AreEqual(res, ds.Calculate(x));
        }
    }
}