using Tyuiu.VoytovichKA.Sprint1.Task1.V1.Lib;
namespace Tyuiu.VoytovichKA.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 18.0;
            double y = 2.0;
            double a = 3.0;
            var res = ds.Calculate(a,x,y);
            Assert.AreEqual(21, res);
        }
    }
}
