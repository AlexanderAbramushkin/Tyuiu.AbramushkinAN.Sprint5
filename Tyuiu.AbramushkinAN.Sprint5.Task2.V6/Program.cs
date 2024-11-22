using Tyuiu.AbramushkinAN.Sprint5.Task2.V6.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds= new DataService();
            
            Console.Title = "Спринт #5 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
            Console.WriteLine("* вывести на консоль.                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = { {-2, 1, 8 },
                             {-4, -7, 8 },
                             {6, 5, 5 } };

            int RowsOfArray = matrix.GetUpperBound(0) + 1;
            int ColumnsOfArray = matrix.GetUpperBound(1) + 1;

            Console.WriteLine("Массив:");
            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    Console.Write($"{matrix[i, j]}  \t");
                }
                Console.WriteLine();
            }

            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");
        }
    }
}
