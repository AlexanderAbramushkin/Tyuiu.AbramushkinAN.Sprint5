using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramushkinAN.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int count = 0;
            string data = File.ReadAllText(path);
            string[] strings = data.Split(' ');
            var numbers = new List<double>();
            foreach (string s in strings)
            {
                double number = double.Parse(s,CultureInfo.InvariantCulture);
                numbers.Add(number);
            }

            foreach (double number in numbers)
            {
                res += number;
                count++;
            }

            return Math.Round(res / count,3);
        }
    }
}
