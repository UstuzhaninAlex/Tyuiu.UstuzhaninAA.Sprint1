using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task4.V20.Lib
{
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            return (1 + x) / Math.Abs(x - Math.Sqrt(2 + y));
        }
    }
}
