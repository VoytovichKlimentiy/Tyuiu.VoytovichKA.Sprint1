using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VoytovichKA.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {
            double a = minutes;
            return Math.Round(a/60, 3);
        }
    }
}
