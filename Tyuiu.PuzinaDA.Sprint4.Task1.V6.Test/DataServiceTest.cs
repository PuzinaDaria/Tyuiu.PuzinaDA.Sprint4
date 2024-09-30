using Tyuiu.PuzinaDA.Sprint4.Task1.V6.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {

            DataService ds = new DataService();
            int[] array = {2, 4, 4, 7, 2, 5, 4, 3, 3, 4};
            int res = ds.Calculate(array);
            int wait = 1024;
            Assert.AreEqual(res, wait);
        }
    }
}