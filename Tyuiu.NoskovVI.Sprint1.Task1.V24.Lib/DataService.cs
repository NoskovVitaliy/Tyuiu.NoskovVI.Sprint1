using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NoskovVI.Sprint1.Task1.V24.Lib
{
    public class DataService : ISprint1Task1V24
    {
        public double Calculate(double x, double y)
        {
            return x / (1 - y);
        }
    }
}
