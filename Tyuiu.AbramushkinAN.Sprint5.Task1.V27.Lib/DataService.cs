using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramushkinAN.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double ResOfCalculate;
            string StrRes;
            
            for (int x = startValue; x <= stopValue; x++) 
            {
                ResOfCalculate = Math.Round((3*x -1.5) / (Math.Sin(x)-3+x) + 2,2);
                if (double.IsNaN(ResOfCalculate) || double.IsInfinity(ResOfCalculate))
                {
                    ResOfCalculate = 0;
                }
                StrRes = Convert.ToString(ResOfCalculate);
                if (ResOfCalculate != stopValue)
                {
                    File.AppendAllText(path, StrRes + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, StrRes);
                }

            }
            return path;
        }
    }
}
