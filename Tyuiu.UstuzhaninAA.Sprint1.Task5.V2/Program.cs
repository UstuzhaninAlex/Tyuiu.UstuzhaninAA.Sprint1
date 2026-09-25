using Tyuiu.UstuzhaninAA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.UstuzhaninAA.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Устюжанин А. А. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Устюжанин Алексей Андреевич | ИСПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
            Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому         *");
            Console.WriteLine("* с помощью класса Convert.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите температуру в градусах Фаренгейта: ");
            double tempFahrenheit = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int tempCelsius = ds.FahrenheitToСelsius(tempFahrenheit);

            Console.WriteLine($"Температура в градусах Цельсия: {tempCelsius}");
            Console.ReadKey();
        }
    }
}