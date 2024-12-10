using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovNS.Sprint6.Task2.V5.Lib
{
    public class DataService : ISprint6Task2V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = GetMassFunction(-5, 5);
            for (int i = 0; i < res.Length; i++)
            {
                if (i == -2)
                {
                    res[i] = 0;
                }
                else
                {
                    res[i] = Math.Round((2*i-3)/(Math.Cos(i) - 2 * i) + 5*i - 6, 2);
                }
            }
            return res;
        }
    }
}
