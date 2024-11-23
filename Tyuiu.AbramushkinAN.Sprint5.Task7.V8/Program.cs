﻿using Tyuiu.AbramushkinAN.Sprint5.Task7.V8.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V8.txt, в котором есть        *");
            Console.WriteLine("* набор символьных данных.Заменить все заглавные русские буквы на         *");
            Console.WriteLine("* строчные. Полученный результат сохранить в файл                         *");
            Console.WriteLine("* OutPutDataFileTask7V8.txt.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\User\Desktop\DataSprint5\InPutDataFileTask7V8.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string PathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine($"Данные находятся в файле");
            Console.WriteLine(PathSaveFile);
        }
    }
}
