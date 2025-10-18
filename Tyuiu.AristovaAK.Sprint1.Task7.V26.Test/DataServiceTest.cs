using Tyuiu.AristovaAK.Sprint1.Task7.V26.Lib;
namespace Tyuiu.AristovaAK.Sprint1.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.5;
            double res = 1.223;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}
