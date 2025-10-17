using Tyuiu.AristovaAK.Sprint1.Task5.V5.Lib;
namespace Tyuiu.AristovaAK.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int d = 5;
            Assert.AreEqual(d, ds.Calculate(x));
        }
    }
}
