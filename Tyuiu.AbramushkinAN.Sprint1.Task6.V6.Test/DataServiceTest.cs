using Tyuiu.AbramushkinAN.Sprint1.Task6.V6.Lib;
namespace Tyuiu.AbramushkinAN.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string checkstr = "Ïונגמו סכמגמ, המנמזו געמנמדמ";
            string waitstr = "ונגמו כמגמ, מנמזו עמנמדמ";
            var res = ds.DeleteFirstLetter(checkstr);
            Assert.AreEqual(waitstr, res);

        }
    }
}