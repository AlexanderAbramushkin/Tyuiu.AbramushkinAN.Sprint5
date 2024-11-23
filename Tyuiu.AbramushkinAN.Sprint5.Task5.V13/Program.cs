using Tyuiu.AbramushkinAN.Sprint5.Task5.V13.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V13.txt, в котором есть       *");
            Console.WriteLine("* набор значений. Найти среднее значение всех чисел в файле, которые      *");
            Console.WriteLine("* находятся в промежутке от -1.5 до 1.5. Полученный результат вывести     *");
            Console.WriteLine("* на консоль. У вещественных значений округлить до трёх знаков            *");
            Console.WriteLine("*  после запятой.                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\User\Desktop\DataSprint5\InPutDataFileTask5V13.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Среднее значение всех чисел в файле: {res}");
        }
    }
}
