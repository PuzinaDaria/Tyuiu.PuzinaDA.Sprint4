using Tyuiu.PuzinaDA.Sprint4.Task5.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Random rd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -5 до 7. Найти количество          *");
            Console.WriteLine("* положительных элементов.                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows = 5;
            int colums = 5;
            int[,] matrix = new int [rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = rd.Next(-5, 7);
                }
            }
            Console.WriteLine("Массив: ");
            for (int i = 0;i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0;j < colums; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(matrix);
            Console.WriteLine("Количество положительных элементов = " + res);
        }
    }
}
