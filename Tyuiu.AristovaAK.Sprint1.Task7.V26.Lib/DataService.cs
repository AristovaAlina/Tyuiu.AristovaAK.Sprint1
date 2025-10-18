using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AristovaAK.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double z = ((Math.Pow(Math.Sin(x), 2) + y) / (y + 1)) - ((x * y - 12) / (34 + x * x));
            return Math.Round(z, 3);
        }
    }
}
