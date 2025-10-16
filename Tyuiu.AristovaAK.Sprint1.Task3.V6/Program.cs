using Tyuiu.AristovaAK.Sprint1.Task3.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
        Console.WriteLine("* (туда и обратно).                                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double Distance = 67;
        double GasFlow = 8.5;
        double GasPrice = 6.5;

        Console.WriteLine("Расстояние до дачи (км) -> " + Distance);
        Console.WriteLine("Расход бензина (литров на 100 км пробега) -> " + GasFlow);
        Console.WriteLine("Цена литра бензина (руб.) -> " + GasPrice);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Поездка на дачу и обратно обойдется в " + ds.TravelCost(Distance, GasFlow, GasPrice) + " руб.");

        Console.ReadKey();
    }
}