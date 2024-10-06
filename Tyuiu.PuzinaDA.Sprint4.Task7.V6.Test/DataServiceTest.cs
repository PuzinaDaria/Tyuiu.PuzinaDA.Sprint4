using Tyuiu.PuzinaDA.Sprint4.Task7.V6.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string value = "458963214789";
            int n = 3, m = 4;
            int count = ds.Calculate(n, m, value);
            int wait = 34;
            Assert.AreEqual(wait, count);
        }
    }
}