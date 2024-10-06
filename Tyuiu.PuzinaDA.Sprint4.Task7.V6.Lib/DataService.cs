using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PuzinaDA.Sprint4.Task7.V6.Lib
{
    public class DataService : ISprint4Task7V6
    {
        public int Calculate(int n, int m, string value)
        {
            int[] mas2 = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                mas2[i] = Convert.ToInt32(value[i].ToString());
            }
            int check = 0;
            int count = 0;
            int[,] mas = new int[n, m]; 
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = mas2[check];
                    check++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] % 2 != 0)
                    {
                        count += mas[i, j];
                    }

                }
            }
            return count;
        }
    }
}
