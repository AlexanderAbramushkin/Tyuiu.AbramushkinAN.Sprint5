using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramushkinAN.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            var culture = new CultureInfo("en-US");
            string data = File.ReadAllText(path);
            string[] strings = data.Split(' ');
            foreach (string s in strings)
            {
                foreach (char c in s)
                {
                    if (c >= 65 && c <= 90 || c >= 97 && c <= 122)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
