using Tyuiu.PuzinaDA.Sprint4.Task0.V5.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7};
            int res = ds.GetSumEvenArrEl(array);
            int wait = 24;
            Assert.AreEqual(res, wait);
        }
    }
}