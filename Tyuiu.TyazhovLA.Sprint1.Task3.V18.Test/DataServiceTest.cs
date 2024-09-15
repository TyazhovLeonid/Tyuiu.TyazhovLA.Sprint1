using Tyuiu.TyazhovLA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.TyazhovLA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 3.0; double b = 7.0; double c = 3.0; double wait = 2.333;
            double result = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait,result);
        }
    }
}