using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PuzinaDA.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        public int GetSumEvenArrEl(int[] array)
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
