using Tyuiu.UstuzhaninAA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double tempFahrenhheit = 41;
            int expected = 5;
            DataService ds = new DataService();
            int actual = ds.FahrenheitToСelsius(tempFahrenhheit);
            Assert.AreEqual(expected, actual);
        }
    }
}
