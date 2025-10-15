using Tyuiu.AristovaAK.Sprint1.Task2.V21.Lib;

namespace Tyuiu.AristovaAK.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 10;
            int res = ds.CalculateRectangleSquare(a, b);
            Assert.AreEqual(50, res);
        }
    }
}
