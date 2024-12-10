using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovNS.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = GetMassFunction(-5, 5);
            for (int i = 0; i < res.Length; i++)
            {
                if (3*i + 1.2 == 0)
                {
                    res[i] = 0;
                }
                else
                {
                    res[i] = Math.Round((2*Math.Sin(i))/(3*i +1.2) + Math.Cos(i) - 7*i * 2, 2);
                }
            }
            return res;
        }
    }
}
