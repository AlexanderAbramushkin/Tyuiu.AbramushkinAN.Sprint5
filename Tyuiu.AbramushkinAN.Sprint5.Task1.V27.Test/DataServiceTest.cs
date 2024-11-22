using Tyuiu.AbramushkinAN.Sprint5.Task1.V27.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckecExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}