using Tyuiu.VoytovichKA.Sprint1.Task4.V4.Lib;

namespace Tyuiu.VoytovichKA.Sprint1.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsAccurate()
        {
            DataService ds = new DataService();
            double x = -5, y = -4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(7, res);
        }
    }
}
