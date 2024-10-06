using Tyuiu.PuzinaDA.Sprint4.Task4.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8.  Заменить нечетные       *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int rows = 5;
            int columns = 5;
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Введите значения массива от 1 до 8: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {   
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    while (matrix[i, j] > 8 || matrix[i, j] < 1)
                    {
                        Console.WriteLine("Неверное значение. Введите число от 1 до 8: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            Console.Write("Массив: ");
            for (int i = 0;i < rows; i++)
            {
                Console.WriteLine();
                for(int j = 0;j < columns; j++)
                {
                    Console.Write(matrix [i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Все нечётные элементы заменены на 0");
            int[,] res = ds.Calculate(matrix);
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
            }

        }
    }
}
