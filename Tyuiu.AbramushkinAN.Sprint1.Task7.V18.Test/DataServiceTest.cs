using Tyuiu.AbramushkinAN.Sprint1.Task7.V18.Lib;
namespace Tyuiu.AbramushkinAN.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate1()
        {
            DataService ds = new DataService();
            double x, y;
            x = 2; y = 3;
            double wait = 2.493;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculate2()
        {
            DataService ds = new DataService();
            double x, y;
            x = 5.4; y = 43.2;
            double wait = 5.669;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}