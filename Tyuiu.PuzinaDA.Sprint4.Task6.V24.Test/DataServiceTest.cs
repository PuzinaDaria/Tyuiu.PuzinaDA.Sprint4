using Tyuiu.PuzinaDA.Sprint4.Task6.V24.Lib;
namespace Tyuiu.PuzinaDA.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string[] array = ["���������", "�������", "�������", "�������", "������", "�������", "����������"];
            string[] wait = ["�������", "�������", "�������", "�������"];
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}