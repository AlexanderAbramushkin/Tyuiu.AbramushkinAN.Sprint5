using Tyuiu.AbramushkinAN.Sprint5.Task6.V16.Lib;

namespace Tyuiu.AbramushkinAN.Sprint5.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\Desktop\DataSprint5\InPutDataFileTask6V16.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\Desktop\DataSprint5\InPutDataFileTask6V16.txt";

            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(6, res);
        }
    }
}