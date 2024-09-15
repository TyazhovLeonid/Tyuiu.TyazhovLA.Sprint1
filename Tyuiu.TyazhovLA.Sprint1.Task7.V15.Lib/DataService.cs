using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TyazhovLA.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            return Math.Round(Math.Abs(x*x-x*x*x)-(Math.Cos(Math.Pow(x,3))+7*Math.Pow(x,2))/(x*x*x-15*x),3);
        }
    }
}
