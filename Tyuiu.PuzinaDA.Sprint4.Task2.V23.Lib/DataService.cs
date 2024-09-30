using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PuzinaDA.Sprint4.Task2.V23.Lib
{
    public class DataService : ISprint4Task2V23
    {
        public int Calculate(int[] array)
        {
            int count = 0;
            foreach (int x in array)
            {
                if (x % 2 == 0)
                {
                    count += x;
                }
            }
            return count;
        }
    }
}
