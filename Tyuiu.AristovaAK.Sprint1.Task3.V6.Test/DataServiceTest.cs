using Tyuiu.AristovaAK.Sprint1.Task3.V6.Lib;
namespace Tyuiu.AristovaAK.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double distance = 67;
            double petrol = 8.5;
            double price = 6.5;
            Assert.AreEqual(74.04, ds.TravelCost(distance, petrol, price));
        }
    }
}
