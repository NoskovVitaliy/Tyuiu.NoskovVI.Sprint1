using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NoskovVI.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            return Convert.ToInt32(Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
        }
    }
}
