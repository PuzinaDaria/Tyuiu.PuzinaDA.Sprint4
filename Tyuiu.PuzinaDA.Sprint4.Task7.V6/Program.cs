using Tyuiu.PuzinaDA.Sprint4.Task7.V6.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #7                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр `458963214789`. Преобразуйте ее в     *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int n = 3, m = 4, check = 0;
            string value = "458963214789";
            int[] mas2 = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                mas2[i] = Convert.ToInt32(value[i].ToString());
            }

            Console.Write("Массив: ");
            int[,] mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = mas2[check];
                    Console.Write(mas[i, j] + " ");
                    check++;
                    
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, value);
            Console.WriteLine("Сумма нечётных чисел = " + res);
        }
    }
}
