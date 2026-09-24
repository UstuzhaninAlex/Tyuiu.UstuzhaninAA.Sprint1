using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double consumption, double price)
        {
            double totalDistance = distance * 2;
            double totalLitres = totalDistance / 100;
            totalLitres *= consumption;
            double totalPrice = totalLitres;
            totalPrice *= price;
            return Math.Round(totalPrice, 3);
        }

        
        
        
    }
}
