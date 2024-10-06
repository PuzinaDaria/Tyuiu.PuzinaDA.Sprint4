using Tyuiu.PuzinaDA.Sprint4.Task5.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                {-3, 2, -5, 7, 3},
                {-4, -1, 6, 4, 5},
                {-2, 3, 1, -4, 5},
                {2, 3, 2, -1, 0},
                {2, 3, 3, -2, 6}
            };
            int wait = 16;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}