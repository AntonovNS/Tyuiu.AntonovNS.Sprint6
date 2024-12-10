using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovNS.Sprint6.Task0.V27.Lib
{
    public class DataService : ISprint6Task0V27
    {
        public double Calculate(int x)
        {
            double res = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            return Math.Round(res, 3);
        }
    }
}
