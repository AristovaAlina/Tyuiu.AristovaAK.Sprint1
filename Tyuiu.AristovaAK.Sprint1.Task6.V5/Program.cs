using Tyuiu.AristovaAK.Sprint1.Task6.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова,     *");
        Console.WriteLine("* которые являются симметричными (например: казак, шалаш).                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите строку:");
        string x = Console.ReadLine() ?? ""; ///результат = значение слева ?? значение справа на случай null;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.CheckSymmetricalWords(x));

        Console.ReadKey();
    }
}