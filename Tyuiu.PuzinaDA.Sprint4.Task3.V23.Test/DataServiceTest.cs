using Tyuiu.PuzinaDA.Sprint4.Task3.V23.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int[,] array =
            {
                {7, 5, 5, 6, 7},
                {8, 7, 8, 4, 3},
                {5, 6, 7, 8, 3},
                {4, 2, 3, 6, 4},
                {5, 2, 4, 2, 3}
            };
            int res = ds.Calculate(array);
            int wait = 13;
            Assert.AreEqual(res, wait);
        }
    }
}