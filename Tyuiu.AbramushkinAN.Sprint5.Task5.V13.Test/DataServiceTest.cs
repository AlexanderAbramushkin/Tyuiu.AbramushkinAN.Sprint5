using Tyuiu.AbramushkinAN.Sprint5.Task5.V13.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\Desktop\DataSprint5\InPutDataFileTask5V13.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
}