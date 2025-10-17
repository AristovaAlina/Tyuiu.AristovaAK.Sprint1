using Tyuiu.AristovaAK.Sprint1.Task4.V19.Lib;
namespace Tyuiu.AristovaAK.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.5;
            double y = 2.5;
            Assert.AreEqual(2.286, ds.Calculate(x, y));
        }
    }
}
