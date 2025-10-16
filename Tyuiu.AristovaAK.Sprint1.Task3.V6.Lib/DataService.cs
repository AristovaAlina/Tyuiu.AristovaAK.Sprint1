using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AristovaAK.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            gasFlow = gasFlow / 100;
            var res = distance * gasFlow * gasPrice;
            return (Math.Round(res, 2) * 2);
        }
    }
}
