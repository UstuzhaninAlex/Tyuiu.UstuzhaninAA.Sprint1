using Tyuiu.UstuzhaninAA.Sprint1.Task2.V0.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 158;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(4.013, res);
        }
    }
}
