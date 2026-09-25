using System.Diagnostics.Metrics;
using Tyuiu.UstuzhaninAA.Sprint1.Task3.V6.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Устюжанин А. А. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Устюжанин Алексей Андреевич | ИСПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* (туда и обратно).                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Растояние до дачи (км) ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Расход бензина (литров на 100 км пробега) ");
            double consumption = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Цена литра бензина (руб.) ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.TravelCost(distance, consumption, price);

            Console.WriteLine($"Поуздка на дачу и обратно обойдётся в {res} руб.");
            Console.ReadKey();



        }
    }
}