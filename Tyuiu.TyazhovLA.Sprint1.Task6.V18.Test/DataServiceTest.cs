using Tyuiu.TyazhovLA.Sprint1.Task6.V18.Lib;
namespace Tyuiu.TyazhovLA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string f = "228";
            bool wait = true;
            var res = ds.CheckNumber(f);
            Assert.AreEqual(wait,res);
        }
    }
}