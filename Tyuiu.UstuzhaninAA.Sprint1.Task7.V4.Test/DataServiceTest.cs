using Tyuiu.UstuzhaninAA.Sprint1.Task7.V4.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
           DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double expected = -0.247;
            double actual = ds.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
