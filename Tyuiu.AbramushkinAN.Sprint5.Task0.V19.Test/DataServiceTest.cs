using Tyuiu.AbramushkinAN.Sprint5.Task0.V19.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);

        }
    }
}