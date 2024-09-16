using Tyuiu.LavrinovichED.Sprint0.Task7.V0.Lib; 

namespace Tyuiu.LavrinovichED.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            //Длинна строки 75 символов
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #0                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #0                                                               *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать консольную программу C#, которая суммирует значения двух        *");
            Console.WriteLine("* одинаковых массивов по длинне.                                           *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            //Место решения задания
            int[] arrayNums1 = new int[] {1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resulArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массива равна: ");
                for (int i = 0; i < resulArray.Length; i++)
                {
                    Console.Write(resulArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey(); 

        }
    }
}
