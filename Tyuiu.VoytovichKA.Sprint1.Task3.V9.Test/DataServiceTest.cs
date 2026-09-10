using Tyuiu.VoytovichKA.Sprint1.Task3.V9.Lib;
namespace Tyuiu.VoytovichKA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int t = 150;
            var res = ds.ConvertMinutesToHours(t);
            Assert.AreEqual(2.5, res);
        }
    }
}
