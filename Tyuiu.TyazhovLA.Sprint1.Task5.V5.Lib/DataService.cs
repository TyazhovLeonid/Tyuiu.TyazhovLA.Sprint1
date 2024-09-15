using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TyazhovLA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            x = Math.Round(x, 3);
            int d = (int)(((x - (int)x) * 1000000))/100000;
            return d;

        }
    }
 }
