using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovNS.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue];
            for (int i = startValue; i < stopValue; i++) 
            {
                if (i == -2)
                {
                    res[i] = 0;
                }
                else
                {
                    res[i] = Math.Round(Math.Cos(i) + (Math.Cos(i)) / (i + 2) - 3 * i, 3);
                }
            }
            return res;
        }
    }
}
