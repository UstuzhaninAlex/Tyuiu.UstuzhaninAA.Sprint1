using Tyuiu.UstuzhaninAA.Sprint1.Task6.V8.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "Hello Word";
            DataService ds = new DataService();
            string actual = ds.MoveLetterToEnd( strTest );
            string expected = "elloh orldw";
            Assert.AreEqual(expected, actual);
        }
    }
}

