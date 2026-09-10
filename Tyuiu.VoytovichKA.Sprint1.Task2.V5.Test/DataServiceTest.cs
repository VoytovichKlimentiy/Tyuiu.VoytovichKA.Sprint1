using System.Formats.Asn1;
using Tyuiu.VoytovichKA.Sprint1.Task2.V5.Lib;
namespace Tyuiu.VoytovichKA.Sprint1.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            var res = ds.CalculateSideSquare(a);
            Assert.AreEqual(150, res);
        }
    }
}
