using Tyuiu.AbramushkinAN.Sprint5.Task4.V28.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\Desktop\DataSprint5\InPutDataFileTask4V28.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}