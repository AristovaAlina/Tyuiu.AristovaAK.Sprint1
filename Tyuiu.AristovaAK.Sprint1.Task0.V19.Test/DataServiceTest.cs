using Tyuiu.AristovaAK.Sprint1.Task0.V19.Lib;

namespace Tyuiu.AristovaAK.Sprint1.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(10, res);
        }
    }
}
