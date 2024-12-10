using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovNS.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public int len = 0;
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains('h'))
                    {
                        resStr = resStr + "" + line;
                    }
                }
            }
            return "UpGwjzkBH OHcr KgepHrKCHa";
        }
    }
}
