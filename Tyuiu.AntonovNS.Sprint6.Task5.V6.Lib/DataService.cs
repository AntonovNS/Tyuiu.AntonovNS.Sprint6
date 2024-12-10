using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovNS.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            string path1 = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask5V6.txt");
            using (StreamReader reader = new StreamReader(path1)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path1)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            numsArray = numsArray.Where(val => val%3==0).ToArray();
            return numsArray;
        }
    }
}
