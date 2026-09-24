using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task2.V0.Lib
{
    public class DataService : ISprint1Task2V19
    {
        public double ConvertInchToKm(int value)
        {
            return Math.Round(value * 0.0254, 3);
        }
        
    }
}
