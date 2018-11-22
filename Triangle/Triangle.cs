using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public double FindHypotenuseOfRight(double side1, double side2)
        {
            double total;
            total = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

            return total;
        }
    }
}
