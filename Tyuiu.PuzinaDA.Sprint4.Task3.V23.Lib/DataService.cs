using System.Xml.Serialization;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PuzinaDA.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j<colums; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
