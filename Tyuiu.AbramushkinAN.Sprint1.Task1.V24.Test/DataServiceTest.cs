using Tyuiu.AbramushkinAN.Sprint1.Task1.V24.Lib;
namespace Tyuiu.AbramushkinAN.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 2.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(-1,res);
        }
    }
}