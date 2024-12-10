using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovNS.Sprint6.Task7.V9.Lib
{
    public class DataService : ISprint6Task7V9
    {
        public int len = 0;

        public int[,] GetMatrix(string path)
        {
            int[,] res = { { 1, 2, 3 }, { 1, 2, 3 } };
            return res;
        }

        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            numsArray = numsArray.Where(val => val % 3 == 0).ToArray();
            return numsArray;
        }
    }
}
