using Tyuiu.PuzinaDA.Sprint4.Task6.V24.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [`Компьютер`, `Телефон`, `Планшет`,         *");
            Console.WriteLine("* `Принтер`,`Сканер`, `Монитор`, `Клавиатура`], используя класс Array,    *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 7 символов.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            string[] array = ["Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура"];
            foreach (string i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(array);
            Console.WriteLine("Элементы массива, длина которых больше 7 символов: ");
            foreach (string i in res)
            {
                Console.Write(i + " ");
            }
        }
    }
}
