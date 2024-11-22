using Tyuiu.AbramushkinAN.Sprint5.Task1.V27.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                             3x-1,5                                      *");
            Console.WriteLine("*  Дана функция      F(x) = ---------- + 2                                *");
            Console.WriteLine("*                           sin(x)-3+x                                    *");
            Console.WriteLine("* f(x) на заданном диапазон [-5; 5] с шагом 1. Произвести проверку        *");
            Console.WriteLine("* деления на ноль. При делении на ноль вернуть значение 0.                *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести      *");
            Console.WriteLine("* на консоль в таблицу. Значения округлить до двух знаков после запятой.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"Начало шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");
        }
    }
}
