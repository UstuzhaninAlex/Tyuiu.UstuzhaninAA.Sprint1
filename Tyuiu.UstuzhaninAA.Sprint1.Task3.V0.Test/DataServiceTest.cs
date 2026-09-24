using Tyuiu.UstuzhaninAA.Sprint1.Task3.V6.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double distance = 67;
            double consumption = 8.5;
            double price = 6.5;
            double res = ds.TravelCost(distance, consumption, price);
            Assert.AreEqual(74.035, res);
        }
    }
}
