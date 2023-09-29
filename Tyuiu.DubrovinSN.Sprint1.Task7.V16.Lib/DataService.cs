using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DubrovinSN.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double one = Math.Sin(Math.Sqrt(Math.Pow(x, 2)));
            double two = Math.Cos(Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));
            double three = Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1));
            double res = Math.Round(one + two - three, 3);
            return res;
        }
    }
}
