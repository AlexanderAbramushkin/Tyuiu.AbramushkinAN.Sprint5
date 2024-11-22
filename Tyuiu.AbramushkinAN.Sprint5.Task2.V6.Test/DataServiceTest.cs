using Tyuiu.AbramushkinAN.Sprint5.Task2.V6.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckecExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}