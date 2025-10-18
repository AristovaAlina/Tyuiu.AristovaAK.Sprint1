using Tyuiu.AristovaAK.Sprint1.Task6.V5.Lib;
namespace Tyuiu.AristovaAK.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string s1 = "шалаш капуста дом казак Бульба abba";
            string s2 = "шалаш казак abba";
            Assert.AreEqual(s2, ds.CheckSymmetricalWords(s1));
        }
    }
}
