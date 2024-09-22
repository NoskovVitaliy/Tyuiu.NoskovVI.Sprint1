using Tyuiu.NoskovVI.Sprint1.Task6.V2.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestHello()
        {
            DataService ds = new DataService();
            string greet = "Hello, I'm Jeff";
            bool res = true;
            Assert.AreEqual(res, ds.CheckHello(greet));
        }
    }
}