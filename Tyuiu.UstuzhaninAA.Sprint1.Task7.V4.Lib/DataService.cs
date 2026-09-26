using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double part1 = y - System.Math.Sqrt(System.Math.Abs(x));
            double denominator = x + (System.Math.Pow(x, 2) / 4);
            double part2 = x - (y / denominator);
            double expressionInsideAbs = part1 * part2;
            double result = System.Math.Log(System.Math.Abs(expressionInsideAbs));
            return System.Math.Round(result, 3);
        }
    }
}
