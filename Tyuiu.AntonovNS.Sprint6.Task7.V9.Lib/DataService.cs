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
            int[,] res = { { 16, -15, -14, -16, -9, -10, -17, 12, -20, -12 }, { 7, 20, -16, 13, 19, 15, -13, -4, 9, 18 }, { -4, 18, 8, 9, -3, 14, -17, 18, -12, -11 }, { -13, 5, 7, -13, 2, -9, 19, 19, -16, 1 }, { 12, 7, 7, -6, 11, -7, 17, -8, -11, -4 }, { -8, -16, -13, -16, 3, -3, -13, 20, -15, 6 }, { 11, 18, -17, -5, -14, 18, 5, 9, -4, -17 }, { 6, 9, 18, 14, 15, -4, 3, -7, -18, 14 }, { 3, 5, 11, 15, -17, 8, 9, -1, 11, 19 }, { 11, -20, 17, 12, 16, 13, -15, 3, 16, 7 } };
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
