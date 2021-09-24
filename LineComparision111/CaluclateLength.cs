using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision111
{
    class CaluclateLength
    {
        public double LineLength(double X1,double Y1, double X2, double Y2) // calculates the length of the line
        {
            Console.WriteLine("finding the length of line:");
            // finding two lines RE EQUAL OR NOT
            double x_total, y_total, total;
            x_total = X1 - X2;
            y_total = Y1 - Y2;
            total = Math.Sqrt((x_total * x_total) + (y_total * y_total));
            return total;
        }
    }
}
