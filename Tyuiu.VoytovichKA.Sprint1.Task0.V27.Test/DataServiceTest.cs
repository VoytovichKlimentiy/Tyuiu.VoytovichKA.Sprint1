using Tyuiu.VoytovichKA.Sprint1.Task0.V27.Lib;
namespace Tyuiu.VoytovichKA.Sprint1.Task0.V27.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(22, res);
        }
    }
}