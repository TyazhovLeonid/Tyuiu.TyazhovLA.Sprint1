using Tyuiu.TyazhovLA.Sprint1.Task4.V17.Lib;
namespace Tyuiu.TyazhovLA.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 14.0; double y = 1.0; double wait = 0.333;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}