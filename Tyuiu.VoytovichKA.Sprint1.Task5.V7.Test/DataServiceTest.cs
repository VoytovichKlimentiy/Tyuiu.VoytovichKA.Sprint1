using Tyuiu.VoytovichKA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.VoytovichKA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int res = ds.AngleToHoursMinutes(67);
            Assert.AreEqual(2, res);
            
        }
    }
}
