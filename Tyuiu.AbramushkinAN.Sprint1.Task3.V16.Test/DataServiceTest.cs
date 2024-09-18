using Tyuiu.AbramushkinAN.Sprint1.Task3.V16.Lib;
namespace Tyuiu.AbramushkinAN.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 5.0;
            double wait = -8;
            var res = Math.Round(ds.CoeffOfQuadraticEquation(x, y),3,MidpointRounding.AwayFromZero);
            Assert.AreEqual(wait, res);
        }
    }
}