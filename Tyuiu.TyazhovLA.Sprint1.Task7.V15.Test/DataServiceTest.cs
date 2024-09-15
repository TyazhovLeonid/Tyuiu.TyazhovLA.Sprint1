using Tyuiu.TyazhovLA.Sprint1.Task7.V15.Lib;
namespace Tyuiu.TyazhovLA.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {   
            DataService ds = new DataService();
            double z = 1.0;
            double wait = 0.539;
            double result = ds.Calculate(z);
            Assert.AreEqual(wait, result);
        }
    }
}