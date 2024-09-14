using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.NoskovVI.Sprint1.Task0.V18.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}