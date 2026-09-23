using Tyuiu.UstuzhaninAA.Sprint1.Task1.V0.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task1.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-2, res);
        }
    }
}
