using Tyuiu.AbramushkinAN.Sprint5.Task3.V28.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckecExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}