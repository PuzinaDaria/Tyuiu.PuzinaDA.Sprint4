using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PuzinaDA.Sprint4.Task1.V6.Lib
{
    public class DataService : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int count = 1;
            foreach (int x in array)
            {
                if (x % 2 == 0)
                {
                    count = count * x;
                }
            }
            return count;
        }
    }
}
