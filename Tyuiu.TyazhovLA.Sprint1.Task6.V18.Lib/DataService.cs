using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TyazhovLA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            int i = 0;
            bool result = int.TryParse(value, out i);
            return result;





        }
    }
}
